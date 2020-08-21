local Node = require"ai.tree.node"

--https://www.cnblogs.com/moonmagician/p/8029978.html

---@class Select : Node
local Select = class("Select", Node)

function Select:ctor(data)
    Select.super.ctor(self, data)
    ---@type Node
    self._activeChild = nil
    self._activeIndex = -1
end

function Select:tick()
    if #self._childs == 0 then
        return TreeState.failure
    end
    --如果没有激活的子节点的话，则需要初始化
    if self._activeChild == nil then
        self._activeIndex = 1
        self._activeChild = self._childs[index]
    end
    ---如果是running、或者success的话，会直接返回
    ---只有遇到了失败才会继续执行下一个节点
    local res = self._activeChild:tick()
    --如果有任何一个子节点返回了true，则不再继续运行
    while res == TreeState.failure do
        self._activeIndex = self._activeIndex + 1
        self._activeChild = self._childs[self._activeIndex]
        if self._activeChild then
            res = self._activeChild:tick()
        else
            --这个表示当前所有子节点都执行完毕了
            res = TreeState.failure
        end
    end
    return res
end

function Select:clear()
    self._activeChild = nil
    self._activeIndex = -1
    Select.super.clear(self)
end

tree.builder:reg("Select", Select)

return Select