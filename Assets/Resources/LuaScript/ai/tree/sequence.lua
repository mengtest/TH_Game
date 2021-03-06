local Node = require"ai.tree.node"

---次序、并行、选择等就是组合节点
---顺序执行所有的子节点，有任意一个返回失败则停止执行并返回失败
---@class Sequence : Node
local Sequence = class("Sequence", Node)

function Sequence:ctor(data)
    ---不会自动构造父类对象
    Sequence.super.ctor(self, data)
    ---当前正在运行的节点
    ---@type Node
    self._activeChild = nil
    ---未初始状态为-1
    self._activeIndex = -1
end

---我这边要做成每帧调用的形式吗？
---如果做成每帧调用的话，则不用循环
---@return TreeState
function Sequence:tick()
    ---没有子节点则返回失败1
    if #self._childs == 0 then
        return TreeState.failure
    end
    if self._activeChild == nil then
        self._activeChild = self._childs[1]
        self._activeIndex = 1
    end
    
    --region
    --local res = self._activeChild:tick()
    ----顺序节点会顺序执行所有子节点
    ----遇到失败时返回失败，否则一直执行到全部结束
    ----只有返回成功才会继续
    ----假如说修改为每帧执行的话，那么某次tick会一直执行到遇到running状态停止，等待下一帧的时候继续tick
    --if res == TreeState.success then
    --    while self._activeChild and res == TreeState.success do
    --        self._activeIndex = self._activeIndex + 1
    --        self._activeChild = self._childs[self._activeChild]
    --        res = self._activeChild:tick()
    --    end
    --end
    --endregion
    
    while self._activeChild do
        local res = self._activeChild:tick()
        ---无论是失败还是运行中状态都直接返回
        if res ~= TreeState.success then
            return res
        end
        self._activeIndex = self._activeIndex + 1 
        self._activeChild = self._childs[self._activeIndex]
    end
    
    return TreeState.success
end

function Sequence:clear()
    self._activeChild = nil
    self._activeIndex = -1
    Sequence.super.clear(self)
end

tree.builder:reg("Sequence", Sequence)

return Sequence