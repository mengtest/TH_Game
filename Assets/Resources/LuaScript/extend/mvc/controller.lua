---lua�˶�mvc controller�Ļ���ʵ�֣��൱�ڳ�����
---@class mvc.Controller
local Controller = class("Controller")

---���캯��
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



---ע�� ���˸о�����new input system֮�󣬿�����һ���ط�ע�����е��¼�����Ӧ
---���ݲ�ͬ���¼���Ӧ��ͳһ����Listener�е��¼����ٸ���ʵ��������벻ͬ�Ĳ���
---���� ��ע����̵�a��b��c�����������¼�����������Щ�¼���ʱ�����ò�ͬ�ĺ���
---      ���磬AEvent�� BEvent��CEvent������Щevent����ᴥ��Listener�����Event������ͬʱ����keyA,keyB,keyC��֮��Ĳ���