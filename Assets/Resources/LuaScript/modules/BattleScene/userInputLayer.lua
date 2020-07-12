---@class UserInputLayer
local M = {}
---@type UnityEngine.GameObject
M.inputLayer = nil

---在这一层里面处理所有的用户输入与输出

---@param script Scene.CombatScene.CombatPanelSlotScript 这个是
function M.slotReleaseEvent(script)
    local input = CS.Scene.CombatScene.UserInputScript.GetCurUserInput()
    local panel = input:GetPanel(input:GetCurSlotPlayerId())
    if (panel ~= nil) then
        ---这个是鼠标当前所在的slot
        local slot = panel:GetSlot(input:GetCurSlotIndex())
        if (slot ~= nil) then
            if (slot:HasCard()) then
                --- CS.Global.MakeToast("当前卡槽已被占用!", CS.Global.TOAST_LONG);
                ---要求当前槽位上有卡牌存在
            elseif(script:HasCard()) then
                ---玩家只能卡牌放置到自己的槽位上
                ---感觉需要从战斗场景的数据中取得玩家的id
                if slot:GetPlayer() == input.myPanel.PlayerId and script:GetPlayer() == input.myPanel.PlayerId then
                    slot:AddCard(script:Remove())
                else
                end
            else
            end
        end
    end
end

function M.init()
    ---@type CCard[]
    global.cardInfos = global.cardInfos or json.decode(CS.Util.Loader.Read("LuaScript/json/cards"))
    
    local go = CS.UnityEngine.GameObject.FindGameObjectWithTag("UserInput")
    if go then
        M.inputLayer = go
        CS.Lib.Listener.Instance:On("Release_Slot", M.slotReleaseEvent, go, 0, false)
    end

    ---@type Scene.CombatScene.UserInputScript
    local script = go:GetComponent(typeof(CS.Scene.CombatScene.UserInputScript))
    for i = 0, #(yGlobal.myPanel) - 1 do
        if yGlobal.myPanel[i + 1] ~= 0 then
            local origin = CS.Util.Loader.Load("Prefab/CombatPawn")
            ---@type UnityEngine.GameObject
            local card = CS.UnityEngine.GameObject.Instantiate(origin)
            --card.transform.localPosition = CS.UnityEngine.Vector3.zero
            ---@type UnityEngine.RectTransform
            local tr = card:GetComponent(typeof(CS.UnityEngine.RectTransform))
            tr.localPosition = CS.UnityEngine.Vector3.zero
            ---@type Prefab.CombatSceneCombatCardScript
            local s = card:GetComponent(typeof(CS.Prefab.CombatSceneCombatCardScript))
            s.content.sprite = util.loadSprite("Image/Card/"..global.cardInfos[yGlobal.uids[yGlobal.myPanel[i + 1]]].img)
            script.myPanel:GetSlot(i):AddCard(s)
            tr.localScale = CS.UnityEngine.Vector3(0.5, 0.5, 1)
        else
            script.myPanel:GetSlot(i):Remove()
        end
    end
end

return M