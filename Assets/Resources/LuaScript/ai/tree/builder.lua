---@class TreeNodeBuilder
local Builder = class("Builder")

function Builder:ctor()
    ---@type table<string, Node>
    self._regList = {}
end

---注册一个节点
---@param name string
---@param clazz Node 这里注册的应该是类型而不是具体的对象
function Builder:reg(name, clazz)
    if self._regList[name] then
        assert("尝试注册重复的类" .. name)
    else
        self._regList[name] = clazz
    end
end

---使用data作为参数构造一个name的节点
---@param name string
---@param data any
function Builder:create(name, data, tree)
    if self._regList[name] then
        local node = self._regList[name].new(data)
        node:setTree(tree)
        return node
    else
        assert("没有注册类" .. name)
    end
end

tree = tree or {}
---@type TreeNodeBuilder
tree.builder = Builder.new()