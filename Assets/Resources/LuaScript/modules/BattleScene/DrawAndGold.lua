local M = {}

local input = require"modules.BattleScene.userInputLayer"

---@param this UnityEngine.Transform
function M.NormalDraw(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---验证当前玩家的金币是否足够
        --CS.Global.MakeToast("您需要2金币才能抽卡", CS.Global.TOAST_SHORT)
		input.drawNormal()
    end)
end

---@param this UnityEngine.Transform
function M.HighDraw(this)
    ---@type Net.Download
    local download = this.gameObject:AddComponent(typeof(CS.Net.Download))
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---验证当前玩家的金币是否足够
        ---首先本地验证当前的金币是否足够，如果足够的话，则发送消息到服务端(core)
        --local request = CS.UnityEngine.Networking.UnityWebRequest.Get("http://127.0.0.1:7777/data/123123123.txt")
        --request:SendWebRequest()
        --print(request.downloadedBytes)
        --download:Begin("ftp://127.0.0.1:7777/data/123123123.txt")
        
		input.drawHigh()
    end)
end

---@param this UnityEngine.Transform
function M.TurnEnd(this)
    ---点击这个按钮的时候需要判断当前是否是这个玩家的回合，或者在非当前玩家的回合隐藏结束回合的按钮
    util.bindButtonCallback(this, function ()
        --CS.Global.MakeToast("您点击了结束回合按钮", CS.Global.TOAST_SHORT)
		input.turnEnd()
    end)
end

---@param this UnityEngine.Transform
function M.init(this)
    util.loadChild(this, M)
end

return M