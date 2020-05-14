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