local util = {}

---@param str string 要切割的字符串
---@param reps string 分隔符
---@return table 返回字符串数组
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

---@param content string 文本内容
---@return table 返回由配置文件构成的表,为映射(C++中的map)
function util.readCfgFile(content)
    local t = {}
    local lines = util.splice(content, "\n")
    local comment = string.byte("#")
    for _, line in pairs(lines) do
        --忽略掉第一个字符为#的行，相当于注释
        if comment ~= string.byte(line, 1, 1) then
            local key, value = string.match( line, "%s*(%S*)%s*=%s*%s*(%S*)")
            if key and value then
                t[key] = value 
            end
        end
    end
    return t
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
---@param o table
function util.copy(o)
    return copy(o)
end

---执行funcs中与parent的子物体名称相同的方法
---@param parent UnityEngine.Transform
---@param fun function[]
function util.loadChild(parent, fun)
    for i = 0, parent.transform.childCount - 1 do
        local child = parent.transform:GetChild(i)
        local f = fun[child.name]
        --if f == nil then
        if type(f) == "function" then
            f(child)
        elseif type(f) == "table" then
            f.init(child)
        end
    end
end

---@param component UnityEngine.Transform
---@param func function
function util.bindButtonCallback(component, func)
    component:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(func)
end

return util