---lua端对mvc View的基本实现，相当于抽象类
---@class mvc.View
local View = class("View")
View.go = nil
View.mvcName = ""
View.list = {}

---构造函数
function View:ctor(data)
    
end

---@param go UnityEngine.GameObject
function View:BindGameObject(go)
    if self.go == nil then
        self.go = go
    end
end

---@param go UnityEngine.MonoBehaviour
function View:BindMono(mono)
    if self.go == nil then
        self.go = mono.gameobject
    end
end

---@return boolean
function View:Bind()
    return self.go == nil
end

---@return UnityEngine.GameObject
function View:GetBindGameObject()
    return self.go
end

---@return string
function View:GetMvcName()
    return self.mvcName
end

---@return mvc.Model
function View:GetModel()
    -- return CS.Lib.Mvc2.Mvc.GetModel()

end

---@param name string
---@param data any
function View:HandelEvent(name, data)
    
end

function View:RegisterAll()

end

---是否包含某个名称的事件
---@return boolean
---@param name string
function View:Contain(name)

end

return View