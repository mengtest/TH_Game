local util = {}

---@param str string 要切割的字符串
---@param reps string 分隔符
---@return string[] 返回字符串数组
function util.splice(str, reps)
 local res = {}
 string.gsub(
     str,
     "[^" .. reps .. "]+",
     function(w)
         table.insert(res, w)
     end
 )
 return res
end

local function copy(o)
    if type(o) == "table" then
        local t = {}
        for k,v in pairs(o) do
            t[k] = copy(v)
        end
        return t
    else
        return o
    end
end

---深拷贝一个对象
---其实还是有一定的问题存在
---@param o table
function util.copy(o)
    return copy(o)
end

local setmetatableindex_
setmetatableindex_ = function(t, index)
    if type(t) == "userdata" then
        assert"生成新的类型时遇到了一些错误"
        --local peer = tolua.getpeer(t)
        --if not peer then
        --    peer = {}
        --    tolua.setpeer(t, peer)
        --end
        --setmetatableindex_(peer, index)
    else
        local mt = getmetatable(t)
        if not mt then mt = {} end
        if not mt.__index then
            mt.__index = index
            setmetatable(t, mt)
        elseif mt.__index ~= index then
            setmetatableindex_(mt, index)
        end
    end
end
setmetatableindex = setmetatableindex_

function util.clone(object)
    local lookup_table = {}
    local function _copy(object)
    if type(object) ~= "table" then
        return object
    elseif lookup_table[object] then
        return lookup_table[object]
    end
    local newObject = {}
    lookup_table[object] = newObject
    for key, value in pairs(object) do
        newObject[_copy(key)] = _copy(value)
    end
        return setmetatable(newObject, getmetatable(object))
    end
    return _copy(object)
end

---声明一个类
---@param classname string 新建的类的名称
function util.class(classname, ...)
    local cls = {__cname = classname}

    local supers = {...}
    for _, super in ipairs(supers) do
        local superType = type(super)
        assert(superType == "nil" or superType == "table" or superType == "function",
                string.format("class() - create class \"%s\" with invalid super class type \"%s\"",
                        classname, superType))

        if superType == "function" then
            assert(cls.__create == nil,
                    string.format("class() - create class \"%s\" with more than one creating function",
                            classname));
            -- if super is function, set it to __create
            cls.__create = super
        elseif superType == "table" then
            if super[".isclass"] then
                -- super is native class
                assert(cls.__create == nil,
                        string.format("class() - create class \"%s\" with more than one creating function or native class",
                                classname));
                cls.__create = function() return super:create() end
            else
                -- super is pure lua class
                cls.__supers = cls.__supers or {}
                cls.__supers[#cls.__supers + 1] = super
                if not cls.super then
                    -- set first super pure lua class as class.super
                    cls.super = super
                end
            end
        else
            error(string.format("class() - create class \"%s\" with invalid super type",
                    classname), 0)
        end
    end

    cls.__index = cls
    if not cls.__supers or #cls.__supers == 1 then
        setmetatable(cls, {__index = cls.super})
    else
        setmetatable(cls, {__index = function(_, key)
            local supers = cls.__supers
            for i = 1, #supers do
                local super = supers[i]
                if super[key] then return super[key] end
            end
        end})
    end

    if not cls.ctor then
        -- add default constructor
        cls.ctor = function() end
    end
    cls.new = function(...)
        local instance
        if cls.__create then
            instance = cls.__create(...)
        else
            instance = {}
        end
        setmetatableindex(instance, cls)
        instance.class = cls
        instance:ctor(...)
        return instance
    end
    cls.create = function(_, ...)
        return cls.new(...)
    end

    return cls
end

math.randomseed(os.time())
math.random()
math.random()
math.random()
math.random()

return util