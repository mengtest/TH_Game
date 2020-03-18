---@class Skill
local skill = {
    ---@type string
    _name = nil,
    ---@type number
    _id = nil,
    ---@type string[]
    _tags = nil,
    ---@type string
    _type = nil
}

---构建一个Skill对象
---@param data any | nil
---@return Skill
function skill:new(data)
    ---@type Skill
    data = data or {}
    setmetatable(data, self)
    self.__index = self
    return data
end

---取得技能的名称
function skill:name()
    return self._name
end

---取得技能的id
function skill:id()
    return self._id
end

---这个技能需要被重写
function skill:execute()
    if self.main ~= nil then
        self:main()
    end
end

---@return string
function skill:type()
    return self._type
end

---@return string[]
function skill:getTag()
    return self._tags
end

---@param tag string 
function skill:hasTag(tag)
    return self._tags[tag] ~= nil
end

function skill:main()
    log("没有实现的函数", LOG_DEBUG)
    --会导出函数，例如选择目标
    --但是技能的使用条件在main中执行的时候检测
end

---@param data table 用于初始化的数据
function skill:load(data)
    log("没有实现的函数", LOG_DEBUG)
end

return skill