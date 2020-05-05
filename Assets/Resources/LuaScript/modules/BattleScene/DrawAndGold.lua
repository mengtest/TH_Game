local M = {}

---@param this UnityEngine.Transform
function M.NormalDraw(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---验证当前玩家的金币是否足够
        CS.Global.MakeToast("您需要2金币才能抽卡", CS.Global.TOAST_SHORT)
    end)
end

---@param this UnityEngine.Transform
function M.HighDraw(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---验证当前玩家的金币是否足够
        --CS.Global.MakeToast("您需要5金币才能抽卡", CS.Global.TOAST_SHORT)
        ---首先本地验证当前的金币是否足够，如果足够的话，则发送消息到服务端(core)
    end)
end

---@param this UnityEngine.Transform
function M.init(this)
    util.loadChild(this, M)
end

return M