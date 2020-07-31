---@class UserInputLayer
local M = {}

---@type UnityEngine.GameObject
M.inputLayer = nil

---在这一层里面处理所有的用户输入与输出

---@param script Scene.CombatScene.CombatPanelSlotScript 这个是存放有卡牌的slot脚本
function M.slotReleaseEvent(script)
	---玩家的鼠标在slot上面释放的时候触发这个函数
	---主要针对点击卡牌后移动鼠标，将卡牌放置到当前的位置上的事件
	
    ---@type CS.Scene.CombatScene.UserInputScript
    local input = CS.Scene.CombatScene.UserInputScript.GetCurUserInput()
    local panel = input:GetPanel(input:GetCurSlotPlayerId())
    if (panel ~= nil) then
        ---这个是鼠标当前所在的slot
        local slot = panel:GetSlot(input:GetCurSlotIndex())
        if (slot ~= nil) then
            if (slot:HasCard()) then ---目标槽位上不能有卡牌
                CS.Global.MakeToast("当前卡槽已被占用!", CS.Global.TOAST_LONG);
            elseif(script:HasCard()) then   ---要求当前槽位上有卡牌存在
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

---@param card Prefab.CombatSceneCombatCardScript
---@param data UnityEngine.EventSystems.PointerEventData
function M.mouseClickPawnUp(card, data, long)
    ---玩家触发卡牌的点击事件后的函数
    ---接下来将当前卡牌对位的卡牌设置为目标，如果没有，则将敌方玩家设置为目标对象
    ---并弹出是否确认发动攻击的按钮，如果玩家点击确认则发动攻击
    if long then
        log("长按的事件")
    else
        log("短按的事件")
    end
end

function M.init()
    ---@type DisplayPawn[]
    global.cardInfos = global.cardInfos or json.decode(CS.Util.Loader.Read("LuaScript/json/cards"))
	
    ---@type DefaultGamePlay
    M.data = DefaultGamePlay.new()
    
    local go = CS.UnityEngine.GameObject.FindGameObjectWithTag("UserInput")
    if go then
        M.inputLayer = go
        CS.Lib.Listener.Instance:On("Release_Slot", M.slotReleaseEvent, go, 0, false)
		CS.Lib.Listener.Instance:On("Mouse_Click_Pawn_Up", M.mouseClickPawnUp, go, 0, false)
    end

	
	
	
	-----这一段代码就是进入战斗场景之后，初始化场地上所有的卡牌的代码
    -----这里就是通过本地数据来初始化战场中相关信息的
    -----是一段测试代码
    -----@type Scene.CombatScene.UserInputScript
    --local script = go:GetComponent(typeof(CS.Scene.CombatScene.UserInputScript))
    --for i = 0, #(M.data.myPanel) - 1 do
    --    local index = M.data.myPanel[i + 1]
    --    if index and index ~= 0 then
    --        local origin = CS.Util.Loader.Load("Prefab/CombatPawn")
    --        ---@type UnityEngine.GameObject
    --        local card = CS.UnityEngine.GameObject.Instantiate(origin)
    --        --card.transform.localPosition = CS.UnityEngine.Vector3.zero
    --        ---@type UnityEngine.RectTransform
    --        local tr = card:GetComponent(typeof(CS.UnityEngine.RectTransform))
    --        tr.localPosition = CS.UnityEngine.Vector3.zero
    --        ---@type Prefab.CombatSceneCombatCardScript
    --        local s = card:GetComponent(typeof(CS.Prefab.CombatSceneCombatCardScript))
    --        s.content.sprite = util.loadSprite("Image/Card/"..global.cardInfos[M.data.uids[index]].img)
    --        script.myPanel:GetSlot(i):AddCard(s)
    --        ---在最后修改创建出来的卡牌的缩放
    --        tr.localScale = CS.UnityEngine.Vector3(0.5, 0.5, 1)
    --    else
    --        script.myPanel:GetSlot(i):Remove()
    --    end
    --end
end


---还需要做的预制体有：卡牌的背面
---		

return M