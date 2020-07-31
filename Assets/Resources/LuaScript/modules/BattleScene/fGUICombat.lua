local M = {}

---这里用到fgui的只有战斗系统中左侧显示当前卡池中所有卡牌的界面
---这个界面中会增加一个新的功能
---比如说当前战斗中棋子造成的伤害统计
---		玩家执行了什么操作的列表
function M.init()
    ---@type FairyGUI.GComponent
    local com = CS.Global.GetRootObject("UIPanel"):GetComponent(typeof(CS.FairyGUI.UIPanel)).ui.asCom
	
	
    local rBtn = com:GetChild("rightBtn").asLoader
    local lBtn = com:GetChild("leftBtn").asLoader
	
    local arrow = com:GetChild("arrow").asLoader
    rBtn.onClick:Add(function ()
        log"切换到右边的视图"
    end)

    lBtn.onClick:Add(function ()
        log"切换到左边的视图"
    end)

    local body = com:GetChild("body").asCom
    local displayList = body:GetChild("displayItemList").asList
    ---无法调用xlua提供的方法来增加回调
    displayList.itemRenderer = function (index, obj)
        ---@type FairyGUI.GComponent
        local item = obj
        item:GetChild("num").asTextField.text = "x" .. math.random(1, 5)
    end
    displayList:SetVirtual()
    displayList.numItems = 100

    local show = true
    arrow.onClick:Add(function ()
        if show then
            com:TweenMoveX(-250, 0.5)
        else
            com:TweenMoveX(-4, 0.5)
        end
        show = not show
    end)
end

return M