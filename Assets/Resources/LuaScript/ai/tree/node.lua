---@class Node
local Node = util.class("Node")

function Node:ctor()
    self.name = ""
    ---@type Node[]
    self._childs = {}
    ---@type Node
    self._parent = nil
end

---@param node Node
function Node:addChild(node)
    table.insert(self._childs, node)
    node:setParent(self)
end

---这个应该是被动调用函数，调用addChild的时候调用这个
---@param node Node
function Node:setParent(node)
    self._parent = node
end

---@param index number
function Node:removeChild(index)

end

---需要能够直接使用到这个行为数所绑定的对象，可以根据绑定的对象判定条件
function Node:exec(obj)

end

return Node