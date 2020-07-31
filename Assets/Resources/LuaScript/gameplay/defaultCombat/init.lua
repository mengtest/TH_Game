---默认游戏玩法(战斗系统)的入口
---当前战斗系统中所有的数据保存，以及数据的更新都在这里
---@class DefaultGamePlay : IGamePlay
local DefaultGamePlay = util.class("DefaultGamePlay")

--local uids = {
    --1,1,1,1,1,2,2,3,3,3,4,4,4,5,6,7,8,9,10,12,14,15,16,16,16,18,20,20
--}

---构造函数
function DefaultGamePlay:ctor()
    self:init()
end

---初始化
function DefaultGamePlay:init()
	---这里存放当前战斗中所有的数据
	
	self.myPlayer = 
end

---进入战斗系统的逻辑应该是
---玩家选择所有的卡牌之后，点击确认按钮，如果当前的卡牌满足要求，则会进入战斗系统，

---获取当前玩家
function DefaultGamePlay:getCurPawnList()
	
end

return DefaultGamePlay