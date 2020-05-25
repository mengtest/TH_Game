local M = {}

local function loginCallback()
    -- 这两个是通过injection设置过来的
    local name = nameInput.text
    local pwd = pwdInput.text

    if #name == 0 then
        CS.Global.Alert("没有账号我怎么知道您是哪位？")
        return
    end

    if #pwd == 0 then
        CS.Global.Alert("您是否忘记输入密码？")
        return
    end

    ---@type UnityEngine.GameObject
    local ani, animaId = CS.Manager.Animation.Play("Effect/loading/", 0.1, 13, 24, -1, 0, nil)
    ani.transform:SetParent(CS.Global.GetRootObject("UILayer").transform)
    ani.transform.localPosition = CS.UnityEngine.Vector3(0, -180, 0)

    CS.Lib.Listener.Instance:On("yuki_stop_login_animation", function ()
        CS.Manager.Animation.Stop(animaId)
    end, ani, 0, true)

    CS.Net.NetHelper.GetInstance():Login(name, pwd)
end

function init()
    CS.UnityEngine.EventSystems.EventSystem.current:SetSelectedGameObject(nameInput.gameObject)
end

function ConfirmBtn(this)
    this:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(loginCallback)
end

function CancelBtn(this)
    this:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(function()
        CS.Lib.Listener.Instance:Event("yuki_login_dialog_close")
    end)
end

function update()
    if CS.UnityEngine.Input.GetKeyDown("return")
            --or CS.UnityEngine.Input.GetKeyDown("keypadEnter") 
    then
        loginCallback()
    end
end

return M