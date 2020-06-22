---------------------------------------------------------------------
-- Project: THGame
-- Created by: yuki@代壮
-- Date: 2020-06-22 11:11:46
---------------------------------------------------------------------

---这个就是通过xlua动态生成的ai实现类
---@class AI
local M = {}
M.id = -1			---ai的id为负值
M.name = "Robot"	---ai的名称，这里会从ai的名称库中随机出一个名称

function M.new(o)
	o = o or {}
	setmetatable(o, self)
	self.__index = self
	return o
end

---ai开始执行动作
function M:Run()
	
end

---ai的声明周期结束
function M:Dispose()
	
end

---AI执行一次操作
function M:Tick()
	---由cpp端导出一个函数，按照ai的行为执行整个操作
	---包含 抽取所有的卡牌
	---		召唤所有能召唤的卡牌
	---		所有的卡牌使用技能(主要是技能的目标要怎么去选择)
	---		所有卡牌发动攻击
	
	---这样做的目的是，以后可以通过导出其他api的方式，在lua端做出更好的ai控制
	---但是目前就只实现一个简单的方式来完成ai的行为控制
end

---ai初始化
function M:Create()
	
end

return M