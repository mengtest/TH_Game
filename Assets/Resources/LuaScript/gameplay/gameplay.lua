---@class GamePlay
local gameplay = {}

---游戏玩法类
---@param player Player
---@param enemy Player
function gameplay:Start(player, enemy)
    self.player = player
    self.enemy = enemy
    ---获取当前双方玩家所选择的卡组数据
    local deck1 = self.player.GetDeck()
    local deck2 = self.enemy.GetDeck()
    ---实例化
end

function gameplay:Next()
    
end

---结束当前对局
function gameplay:End()
    
end


-----玩法类接口，这个是xlua中的玩法类，而不是cpp中的玩法类
-----@class IGamePlay
--local M = class("IGamePlay")
--
-----获取到当前的棋盘中棋子的信息(这里只有展示信息)
-----@param id number 想要获取信息的玩家的id 
--function M:getPanelList(id) end
--
-----获取当前玩家的卡池信息
--function M:getDeck() end
--
--function M:() end
