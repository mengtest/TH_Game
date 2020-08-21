local Node = require"ai.tree.node"

--只有动作节点会出现running状态？
--目前修改为行为树从BlackBoard接收所有的输入数据，会有对应的输出值
--应该是以字符串你的形式返回，然后不断地解析这个字符串
--现在修改为所有的动作节点都是输出一段信息，由其他部件来接收这个输出
---@class Action: Node
local Action = class("Action", Node)

---动作节点修改为根据实际情框不断增加新的动作节点库
function Action:ctor(data)
    Action.super.ctor(self, data)
    if not (data or data.action) then
        assert("无法创建动作节点" .. self.id)
    end
    ---@type table 这个实际上就是从ai的配置文件中直接获取的，在执行这个节点的时候这个输出会输出到output中
    self._data = data.action
end

function Action:tick()
    print("执行动作节点" .. self.name)
    ---需要将所有data输出
    
    ---比如说可能会有一个派生的动作节点 random_pawn_attack(随机选择一个棋子发动攻击)
    ---也可能会有一个动作节点          pawn_use_skill(棋子使用一个技能) 如果有这样的动作的话，那么同时还需要
    ---                              拥有get_pawn_can_use_skill get_XXXX_target这类api辅助选择棋子
    
    
end

function Action:addChild()
    error"动作节点不能拥有子节点"
end

function Action:removeChild()
    error"动作节点没有子节点"
end

tree.builder:reg("Action", Action)

return Action