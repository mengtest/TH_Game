local Node = require"ai.tree.node"

---@class Decorator : Node
local Decorator = class("Decorator", Node)

---实际上装饰器只能有一个子节点
function Decorator:ctor(data)
    Decorator.super.ctor(self, data)
end

---重载添加子节点的函数，限制装饰器只能有一个子节点
function Decorator:addChild(node)
    if #(self._childs) >= 1 then
        assert("装饰节点不能拥有多个子对象")
    else
        Decorator.super.addChild(self, node)
    end
end

---@class Loop: Decorator
local Loop = class("Loop", Decorator)

---这个本质上就是一个静态函数，可以直接调用然后创建一个对象出来
---@return Decorator
---循环指定的次数
function Loop:ctor(data)
    Loop.super.ctor(self, data)
    if data and data.loop then
        --self._data = data
        ---约定无限循环是-1
        ---0表示一次都不执行，其他值表示确定的次数
        self._loop = data.loop
        self._count = 0
    else
        assert("loop节点必须设置loop属性")
    end
end

function Loop:tick()
    while true do
        --TODO 如果没有子节点的话，返回值应该是什么?
        if #self._childs == 0 then
            return TreeState.success
        end
        ---指定的循环次数执行完成，返回成功
        if self._count == self._loop then
            return TreeState.success
        end
        local res = self._childs[1]:tick()
        ---只要不是正在运行的状态，都会继续下一次运行
        if res ~= TreeState.running then
            self._count = self._count + 1
        else
            return TreeState.running
        end
    end
end

function Loop:clear()
    self.super.clear(self)
    self._count = 0
end

---一直循环，知道满足条件后结束
---@class LoopUntil : Decorator
local LoopUntil = class("LoopUntil", Decorator)

function LoopUntil:ctor(data)
    assert("暂未实现该节点")
end

---对返回的结果取反，如果返回成功，则最后返回失败
---@class Inverter : Decorator
local Inverter = class("Inverter", Decorator)

function Inverter:ctor(data)
    assert("暂未实现该节点")
end

tree.builder:reg("Loop", Loop)
tree.builder:reg("LoopUntil", LoopUntil)
tree.builder:reg("Inverter", Inverter)

return Decorator