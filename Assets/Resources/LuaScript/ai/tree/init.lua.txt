local Node = require"ai.tree.node"

---@class BehaviourTree
local BehaviourTree = util.class("BehaviourTree")


---棋子的行为需要
function BehaviourTree:ctor()
	self.root = Node.new()
end

---根据配置文件来初始化整个行为树
function BehaviourTree:parse(str)

end

return BehaviourTree