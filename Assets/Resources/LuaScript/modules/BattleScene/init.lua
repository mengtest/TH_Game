local M = {}

local queryCard = require"modules.BattleScene.QueryCard"
local drawAndGold = require"modules.BattleScene.DrawAndGold"

---战斗场景应该具有的功能
---     异步加载(当场景中所有需要的数据全部加载完成的时候，发送消息给服务端，然后等待所有的客户端都加载完成之后，服务端发送消息，所有的客户端进入战斗场景)
---     

---@param this UnityEngine.Transform
local function Setting(this)
    util.bindButtonCallback(this, function ()
        log("您点击了设置按钮")
    end)
end

local list = {
    QueryCard = queryCard,
    DrawAndGold = drawAndGold,
    Setting = Setting
}

function M.init()
    ---离开场景的时候界面中要用到的数据会保留下来，但是ui会被销毁，下次再使用的时候再创建出来
    util.loadChild(CS.Global.GetCurCanvas().transform, list)
    require"modules.BattleScene.userInputLayer".init()
    
    ---@type FairyGUI.GComponent
    local com = CS.Global.GetRootObject("UIPanel"):GetComponent(typeof(CS.FairyGUI.UIPanel)).ui.asCom
    --local ui = panel.ui
    --local com = ui.asCom
    local rBtn = com:GetChild("rightBtn").asLoader
    local lBtn = com:GetChild("leftBtn").asLoader
    --local title = com:GetChild("titleText").asTextField
    local arrow = com:GetChild("arrow").asLoader
    rBtn.onClick:Add(function ()
        log"切换到右边的视图"
    end)

    lBtn.onClick:Add(function ()
        log"切换到左边的视图"
    end)
    
    local body = com:GetChild("body").asCom
    local displayList = body:GetChild("displayItemList").asList
    --log(displayList.name)
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
    
    ----title.text = "11111111111111111111111111111111"
    ----require"core"
    --local x = T.new("11111111111")
    --print(x.id)
    --print(x.str)
    
    
    ---以前检测的到卡牌，现在检测不到，很难受
    ---所有的卡牌的点击事件
    --CS.Lib.Listener.Instance:On(CS.Lib.Listener.MOUSE_EVENT, function (a, b, c)
    --    ---@type UnityEngine.RaycastHit
    --    local isHit, hit = a:ExplicitRayHit()
    --        ---- log("123123123")
    --    if isHit then
    --        ---判断当前点击的卡牌是否是自己的卡牌，如果是自己的卡牌，则会触发攻击相关的操作
    --        ---如果不是自己的卡牌，则没有任何提示
    --        ---如果持续点击对应的卡牌，则会显示当前卡牌的详细信息
    --        if hit then
    --            log(hit.transform.name)
    --        end
    --    end
    --end, nil, CS.Lib.KeyCode.Mouse0, false)
end

return M