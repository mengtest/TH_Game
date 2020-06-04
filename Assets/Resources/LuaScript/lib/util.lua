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
---其实还是有一定的问题存在
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

util.load = CS.Util.Loader.load
util.read = CS.Util.Loader.Read
util.write = CS.Util.Loader.Write

local f1 = xlua.get_generic_method(CS.Util.Loader, 'Load')
local l = f1(CS.UnityEngine.Sprite)

---@type function
util.loadSprite = l

---@param component UnityEngine.Transform
---@param func function
function util.bindButtonCallback(component, func)
    component:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(func)
end

local types = json.decode(util.read("LuaScript/json/types"))
---@return string
---@param index number
function util.idToType(index)
    return types[index]
end

---不要想了，做不到js中的异步的那个效果
--function util.messageBox()
	--local res = nil
	--local co = coroutine.create(function()
		--local dialog = CS.Util.ModelDialog("hello","是", "否", function()
			--coroutine.resume(co)
			--res = true
		--end, function()
			--coroutine.resume(co)
			--res = false
		--end)
		--dialog:ShowDialog()
		--coroutine.yield()
	--end)
--end

return util