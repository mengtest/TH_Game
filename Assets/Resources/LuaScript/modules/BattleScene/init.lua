local M = {}

local queryCard = require"modules.BattleScene.QueryCard"
local drawAndGold = require"modules.BattleScene.DrawAndGold"

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
    util.loadChild(CS.Global.GetCurCanvas().transform, list)
    
    ---所有的卡牌的点击事件
    CS.Lib.Listener.Instance:On(CS.Lib.Listener.MOUSE_EVENT, function (a, b, c)
        ---@type UnityEngine.RaycastHit
        local isHit, hit = a:ExplicitRayHit()
        if isHit then
            ---判断当前点击的卡牌是否是自己的卡牌，如果是自己的卡牌，则会触发攻击相关的操作
            ---如果不是自己的卡牌，则没有任何提示
            ---如果持续点击对应的卡牌，则会显示当前卡牌的详细信息
            if hit then
                log(hit.transform.name)
            end
        end
    end, nil, CS.Lib.KeyCode.Mouse0, false)
end

return M