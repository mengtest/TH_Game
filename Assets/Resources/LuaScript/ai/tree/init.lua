require"ai.tree.builder"

require"ai.tree.node"
require"ai.tree.select"
require"ai.tree.action"
require"ai.tree.sequence"
require"ai.tree.condition"
require"ai.tree.decorator"
require"ai.tree.blackboard"
require"ai.tree.prioritySelect"

require"ai.tree.actions.draw"
require"ai.tree.actions.attack"
require"ai.tree.actions.summon"
require"ai.tree.actions.turnEnd"
require"ai.tree.actions.useSkill"

local json = json or require"ai.tree.lib.json"
class = class or require"ai.tree.lib.util".class

---@class BehaviourTree
local BehaviourTree = class("BehaviourTree")

--棋子的行为需要
function BehaviourTree:ctor()
	--有唯一的root节点、且root节点只有一个子节点
	---@type Node
	self.root =  tree.builder:create("Node")
	---@type Node
	self._runningNode = nil
end

--每帧运行都调用这个函数
--每次tick直到运行到整个树全部执行完毕，或者返回running节点后终止本次tick
--下次tick时，直接从处于running状态下的节点开始运行
function BehaviourTree:tick()
	if not self:isRunning() then
		self.root:tick()
	else
		self._runningNode:tick()		
	end
end

--当前行为树是否处于正在运行的状态
function BehaviourTree:isRunning()
	return self._runningNode ~= nil
end

----获取到当前正在运行中的节点
--function BehaviourTree:getRunningNode()
--	
--end

--设置当前正在运行的节点、应该是只有动作节点才能处于运行中的状态
function BehaviourTree:setRunningNode(act)
	self._runningNode = act	
end

--根据配置文件来初始化整个行为树
function BehaviourTree:parse(str)
	---加载一个json文件，根据json文件构造一颗行为树
	local t = json.decode(str)
	--具体的格式约束可以等有空再来做

	---根节点的类型只能是Node，
	if t[1].type == "Node" then
		self.root.name = t[1].name
	else
		assert("无效的根节点")
	end
	
	local function createNode(items, index)
		local item = items[index + 1]
		local node = tree.builder:create(item.type, item)
		--node.name = item.name
		--node.id = item.id
		if item.children then
			for i, v in ipairs(item.children) do
				node:addChild(createNode(items, v))
			end
		end
		return node
	end
	
	self.root:addChild(createNode(t, t[1].children[1]))
end

return BehaviourTree