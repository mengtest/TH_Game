---这里是cs端的ILuaData接口的实现，作为lua端其他model的基类

---@class Model: Lib.ILuaData
local model = {
    _mvcName = nil
}

---获取这个模型对象的名称
---@return string
function model:GetMvcName()
    return self._mvcName
end

---设置这个模型对象的名称
---@param name string
function model:SetMvcName(name)
    self._mvcName = name
end

---触发一个事件
function model:HandelEvent()
    CS.Lib.Mvc.Notify(self._mvcName, self)
end

---这个是额外的接口，用于取得一个新的model对象实例
---@param o table|nil
function model:New(o)
    o = o or {}
    setmetatable(o, self)
    self.__index = self
    return o
end

return model