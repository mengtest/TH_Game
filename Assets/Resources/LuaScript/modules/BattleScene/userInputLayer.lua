---@class UserInputLayer
local M = {}
---@type UnityEngine.GameObject
M.inputLayer = nil

---在这一层里面处理所有的用户输入与输出

---@param script Scene.CombatScene.CombatPanelSlotScript
function M.slotReleaseEvent(script)
    local input = CS.Scene.CombatScene.UserInputScript.GetCurUserInput();
    local panel = input:GetPanel(input:GetCurSlotPlayerId());
    if (panel ~= nil) then
        local slot = panel:GetSlot(input:GetCurSlotIndex());
        if (slot ~= null) then
            if (slot:HasCard()) then
                --- CS.Global.MakeToast("当前卡槽已被占用!", CS.Global.TOAST_LONG);
                ---要求当前槽位上有卡牌存在
            elseif(script:HasCard()) then
                slot:AddCard(script:Remove());
            else
                
            end
        end
    end
end

function M.init()
    local go = CS.UnityEngine.GameObject.FindGameObjectWithTag("UserInput")
    if go then
        M.inputLayer = go
        CS.Lib.Listener.Instance:On("Release_Slot", M.slotReleaseEvent, go, 0, false)
    end
    
end

return M