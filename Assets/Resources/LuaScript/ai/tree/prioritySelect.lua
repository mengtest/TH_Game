--local Node = require"ai.tree.node"
local Select = require"ai.tree.select"

---@class PrioritySelect : Node
local PrioritySelect = class("PrioritySelect", Select)

function PrioritySelect:ctor(data)
    PrioritySelect.super.ctor(self, data)
    ---从最高优先级到最低优先级顺序执行节点
    ---@type Node
    self._activeChild = nil
    ---@type number[] 当前的子节点数组中子对象的优先级序列，与子对象的顺序一一对应，创建这个数组的主要目的是为了不破坏原本的结构
    self._priorityAry = {}
end

---在添加子节点的时候就设置了优先级
function PrioritySelect:addChild(node, priority)
    --默认的优先级为1
    priority = priority or 1
    for i, v in ipairs(self._priorityAry) do
        if v >= priority then
            table.insert(self._priorityAry, i, priority)
            table.insert(self._childs, i, node)
            node:setParent(self)
            return
        end
    end
    table.insert(self._priorityAry, priority)
    table.insert(self._childs, node)
    node:setParent(self)
end

function PrioritySelect:removeChild(index)
    PrioritySelect.super.removeChild(self, index)
    table.remove(self._priorityAry, index)
end

--function PrioritySelect:clear()
--    PrioritySelect.super.clear(self)
--    self._activeChild = nil
--    self._activeIndex = -1
--end

function PrioritySelect:removeChildByName(name)
    for index, value in ipairs(self._childs) do
        if value.name == name then
            table.remove(self._childs, index)
            table.remove(self._priorityAry, index)
            value._parent = nil
        end
    end
end

tree.builder:reg("PrioritySelect", PrioritySelect)

return PrioritySelect