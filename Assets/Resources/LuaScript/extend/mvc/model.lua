---lua端对mvc Model的基本实现，相当于抽象类
---@class mvc.Model
local Model = class("Model")

---构造函数
function Model:ctor(data)
    -- body
end

---@return any
function Model:GetData()
    
end

---@param data any
function Model:SetData(data)
    
end

---@param data any
function Model:Update(data)
    
end

---@return string
function Model:GetMvcName()
    
end

---@param name string
---@param data any
function Model:SendEvent(name, data)
    
end

return Model