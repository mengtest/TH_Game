---默认游戏玩法(战斗系统)的入口
---@class DefaultGamePlay
local M = {}

local uids = {
    1,1,1,1,1,2,2,3,3,3,4,4,4,5,6,7,8,9,10,12,14,15,16,16,16,18,20,20
}

M.uids = uids

---@type number[]
M.myPanel = {1,14,0,9,16,0,0,23}

---@type number[]
M.enemyPanel = {0,0,0,0,0,0,0,0}

---@type number[]
M.handPawn = {1,1,1,2,3,3,3}

M.enemyPawnNum = 1

---当前玩家所有的卡牌，由卡牌的id到卡牌的数量键值对集合
---@type table<number, number>
M.deck = {}

M.gold = 10
M.energy = 10
M.maxEnergy = 10
M.hp = 10

return M