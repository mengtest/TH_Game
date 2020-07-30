---默认游戏玩法(战斗系统)的入口
---@class DefaultGamePlay
local M = util.class("DefaultGamePlay")

local uids = {
    1,1,1,1,1,2,2,3,3,3,4,4,4,5,6,7,8,9,10,12,14,15,16,16,16,18,20,20
}

---构造函数
function M:ctor()
    self:init()
end

---初始化
function M:init()
    ---@type number[]
    self.myPanel = {0,0,0,0,0,0,0,0}
    ---@type number[]
    self.enemyPanel = {0,0,0,0,0,0,0,0}
    ---@type number[]
    self.handPawn = {}
    self.enemyPawnNum = 0
    ---当前玩家所有的卡牌，由卡牌的id到卡牌的数量键值对集合
    ---@type table<number, number>
    self.deck = {}
    self.gold = 0
    self.energy = 0
    self.maxEnergy = 0
    self.hp = 0
    self.uids = uids or {}
end

return M