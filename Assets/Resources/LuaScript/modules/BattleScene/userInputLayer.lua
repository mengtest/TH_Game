---------------------------------------------------------------------
-- THGame (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2020-06-04 11:56:31
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

---@class UserInputLayer
local M = {}
---@type UnityEngine.GameObject
M.inputLayer = nil

---@param script Scene.CombatScene.CombatPanelSlotScript
function M.slotReleaseEvent(script)
    local input = CS.Scene.CombatScene.UserInputScript.GetCurUserInput();
    local panel = input:GetPanel(input:GetCurSlotPlayerId());
    if (panel ~= nil) then
        local slot = panel:GetSlot(input:GetCurSlotIndex());
        if (slot ~= null) then
            if (slot:HasCard()) then
                CS.Global.MakeToast("当前卡槽已被占用!", CS.Global.TOAST_LONG);

                ---要求当前槽位上有卡牌存在
            elseif(script:HasCard()) then
                slot:AddCard(script:Remove());
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