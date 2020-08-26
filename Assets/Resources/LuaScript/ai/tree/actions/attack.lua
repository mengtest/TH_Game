local Action = require("ai.tree.action")

---@class Attack : Action
local Attack = class("Attack", Action)

---棋子发动攻击的话，需要区分  XXXX样的棋子发动攻击 还需要判断棋子是否能够发动攻击
function Attack:ctor(data)
    self.super.ctor(self, data)
end

---直接硬编码了，免得又拖时间
function Attack:tick()
    --该如何使用tree来完成异步回调？
    --比如说执行到某个动作时，如果返回1表示运行成功
    --如果返回0，表示运行失败
    --如果返回-1，表示处于运行中状态
    
    
    --先能够获取到自己的一个能够发动攻击的棋子
    local combat = nn.get_combat(combatId or 1)
    local player = combat:getPlayer(-1)
    --for i = 0, player:getMaxCombatPawnNumber() do
    --    local pawn = player:getCombatPawnByIndex(i)
    --    
    --end
    --判断当前的棋子是否能够杀死敌方棋子且，自己不会死
    
    --发动攻击
end

tree.builder:reg("Attack", Attack)