--region
--BTNode：所有节点的base class。定义了一些节点的基本功能，并提供一些可继承的函数。
--BTAction：行为节点，继承于BTNode。具体的游戏逻辑应该放在这个节点里面。
--BTPrecondition：节点的准入条件，每一个BTNode都会有一个。具体的游戏逻辑判断可以继承于它。
--BTPrioritySelector：Priority Selector逻辑节点，继承于BTNode。每次执行，先有序地遍历子节点，然后执行符合准入条件的第一个子结点。可以看作是根据条件来选择一个子结点的选择器。
--BTSequence：Sequence逻辑节点，继承于BTNode。每次执行，有序地执行各个子结点，当一个子结点结束后才执行下一个。严格按照节点A、B、C的顺序执行，当最后的行为C结束后，BTSequence结束。
--BTParallel：Parallel逻辑节点，继承于BTNode。同时执行各个子结点。每当任一子结点的准入条件失败，它就不会执行。
--BTParallelFlexible：Parallel的一个变异，继承于BTNode。同时执行各个子节点。当所有子结点的准入条件都失败，它就不会执行。
--endregion

---@field super Node
---@field new fun(data: any):Node
---@class Node
local Node = class("Node")

---这里的行为树所需要的变量有 
--- 1、血量的判断、能量的判断、金币的判断
--- 2、从手牌中召唤一个卡牌到指定的位置          卡牌uid 位置
--- 3、抽取一张卡牌                            高级还是低级的
--- 4、攻击                                   棋子参数
--- 5、使用技能                               目标棋子uid 技能id

---@class TreeState
TreeState = {
    ---成功
    success = 1,
    ---失败
    failure = 2,
    ---运行中
    running = 3,
    ---无效的节点,也可以用于判断是否满足条件，这里的意思是不满足条件
    none = 4
}

function Node:ctor(data)
    if data and data.name then
        self.name = data.name
    else
        self.name = "node"
    end
    if not data.id then
        assert("节点必须具有id")
    end
    ---@type number
    self.id = data.id
    ---@type Node[]
    self._childs = {}
    ---@type Node
    self._parent = nil
    ---@type Condition
    self._precondition = nil
    ---@type BehaviourTree
    self._tree = tree
end

---@param node Node
function Node:addChild(node)
    table.insert(self._childs, node)
    node:setParent(self)
end

---这个应该是被动调用函数，调用addChild的时候调用这个
---@param node Node
function Node:setParent(node)
    if self._parent ~= nil then
        assert("该节点已经存在父节点了")
    end
    self._parent = node
end

---@return Node
function Node:getParent()
    return self._parent
end

function Node:clear()
    for index, value in ipairs(self._childs) do
        value:clear()
    end
end

---@param name string
function Node:removeChildByName(name)
    for index, value in ipairs(self._childs) do
        if value.name == name then
            table.remove(self._childs, index)
            value._parent = nil
        end
    end
end

function Node:setTree(tree)
    if self._tree then
        return
    end
    self._tree = tree
end

function Node:getRoot()
    return self._tree
end

function Node:removeSelf()
    self._parent:removeChildByName(self.name)
end

---@param index number
function Node:removeChild(index)
    local item = table.remove(self._childs, index)
    item._parent = nil
end

---@return TreeState
---准入条件要如何判断?
function Node:tick()
    return TreeState.success
end

function Node:check()
    if not self._precondition then
        return true
    else
        return self._precondition()
    end
end

---这里的obj应该包含了当前战斗系统中所有ai可以利用的资源，或者说可见的资源
---@return number 各个值的意义：这里本质上就是返回的TreeState
function Node:exec(obj)
    if self:check() then
        
    end
    return TreeState.success
end

---注册节点对象
tree.builder:reg("Node", Node)

return Node