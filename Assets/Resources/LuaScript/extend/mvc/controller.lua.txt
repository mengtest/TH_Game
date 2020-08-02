---lua端对mvc controller的基本实现，相当于抽象类
---@class mvc.Controller
local Controller = class("Controller")

---构造函数
function Controller:ctor(data)
    -- body
end

---@param data any
function Controller:Execute(data)

end

---@return mvc.View
function Controller:GetView()
    
end

---@return mvc.Model
function Controller:GetModel()

end

---@param model mvc.Model
function Controller:RegisterModel(model)

end

---@param view mvc.View
function Controller:RegisterView(view)

end

---@param name string
---@param controller mvc.Controller
function Controller:RegisterController(name, controller)

end


return Controller



---注意 个人感觉有了new input system之后，可以在一个地方注册所有的事件并相应
---根据不同的事件相应，统一触发Listener中的事件，再根据实际情况传入不同的参数
---例如 ：注册键盘的a、b、c三个按键的事件，当触发这些事件的时候会调用不同的函数
---      比如，AEvent， BEvent，CEvent，在这些event里面会触发Listener里面的Event函数，同时传入keyA,keyB,keyC等之类的参数