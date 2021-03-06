local Node = require"ai.tree.node"

---@class Condition : Node
local Condition = class("Condition", Node)


--需要完成的api应该有
--  获取当前玩家可以发动攻击的棋子
--  获取当前玩家可以使用技能的棋子
--  获取还可以放置卡牌的位置
--  选择技能的最优目标           这个就直接给出最高级的api
--  结束回合                    啊

---条件节点也是叶子节点
function Condition:ctor(data)
    Condition.super.ctor(self, data)
    self._name = "condition"
    ---这里的data是从行为树的配置文件中读取的
    ---cond为条件名
    ---op为比较符号有>、<、=、!、t、f几种情况
    ---func为想要调用的函数
    ---param为函数参数，这个应该是一个列表，运行时会整个全部传入行为树中
    ---value为目标值，可以为布尔值
    if data.cond and data.op and data.value then
        ---这个就是用于直接从黑板中取对应的数值，例如 blackboard[self._cond] > self._value
        self._cond = data.cond
        self._op = data.op
        self._value = data.value
        --self._data = data
        self._method = 1
    elseif data.func and data.param then
        ---这里假定t表中存放一些可以供行为树做条件判断的函数，在实际情况下的应用就应该是, t[self._func](self._param)
        ---然后再判断这个所返回的结果
        ---这种情况下就可以方便去做成，例如 has_pawn_can_attack(有棋子没有攻击)，这种也可以做成一个庞大的条件节点库
        self._func = data.func
        self._param = data.param
        --self._data = data
        self._method = 2
    else
        assert("无法创建条件节点" .. data.id or data.name or "")
    end
end

function Condition:addChild(node)
    assert("条件节点不能拥有子节点")
end

function Condition:tick()
    ---这里假定有一个blackBoard表
    local blackBoard = {}
    ---直接从黑板中取出对应的属性，并判断是否满足条件
    if self._method == 1 then
        if self.op == ">" then
            if blackBoard[self._cond] and blackBoard[self._cond] > self._value then
                return TreeState.success
            end
            return TreeState.none
        elseif self.op == "<" then
            if blackBoard[self._cond] and blackBoard[self._cond] < self._value then
                return TreeState.success
            end
            return TreeState.none
        elseif self.op == "=" then
            if blackBoard[self._cond] and blackBoard[self._cond] == self._value then
                return TreeState.success
            end
            return TreeState.none
        elseif self._data.op == "!" then
            if blackBoard[self._cond] and blackBoard[self._cond] ~= self._value then
                return TreeState.success
            end
            return TreeState.none
            --region
        --elseif self._data.op == "t" then
        --    if blackBoard[self._cond] and blackBoard[self._cond] > self._value then
        --        return TreeState.success
        --    end
        --    return TreeState.none
        --elseif self._data.op == "f" then
        --    if blackBoard[self._cond] and blackBoard[self._cond] > self._value then
        --        return TreeState.success
        --    end
        --    return TreeState.none
            --endregion
        end
    elseif self._method == 2 then
        if blackBoard[self._func] then
            if blackBoard[self._func](self._param) then
                return TreeState.success
            end
            return TreeState.none 
        end
    end
    return TreeState.none
end

tree.builder:reg("Condition", Condition)

return Condition