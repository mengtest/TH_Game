---@class MatchScene.Deck
local M = {}

---@param this UnityEngine.Transform
function M.init(this)
    ---@type UnityEngine.Transform
    local startBtn = this:GetChildByName("Start")
    ---@type UnityEngine.UI.Button
    local btn = startBtn:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        CS.Global.NavigateTo("BattleScene", true)
    end)
end

return  M