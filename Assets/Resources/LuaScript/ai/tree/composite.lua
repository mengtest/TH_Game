local Node = require"ai.tree.node"

---复合节点
---复合节点的子节点可以是动作节点也可以是其他的复合节点或者条件节点
---@class Composite
local Composite = class("Composite", Node)

-- 
-- ---@return Composite
-- function Composite.Sequence()
--     -- body
-- end

-- ---一直执行直到有任意一个子节点返回成功，或者全部执行失败时返回失败
-- ---@return Composite
-- function Composite.Select()
--     -- body
-- end

-- ---根据指定的优先级来依次执行子节点
-- ---@return Composite
-- function Composite.PrioritySelect()
--     -- body
-- end

-- ---暂时不管这个
-- ---@return Composite
-- function Composite.Parallel()
--     -- body
-- end

return Composite