local M = {}

--tcp与udp
--https://zhuanlan.zhihu.com/p/24860273

---这里的行为节点库，本身就针对于这个游戏项目的，正常情况下代码本身就应该放在一起，无所谓耦合不耦合了

--查找hp高于或者低于value的棋子
---@param combatId number
---@param playerId number
---@param greater boolean
---@param value number
function M.getPawnByHpThan(combatId, playerId, value, greater)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    for i = 0, player:getMaxCombatPawnNumber() do
        local pawn = player:getCombatPawnByIndex(i)
        if pawn then
            if greater then
                if pawn:hp() > value then
                    return pawn:unique_id()
                end
            else
                if pawn:hp() < value then
                    return pawn:unique_id()
                end
            end
        end
    end
end

---@param combatId number
---@param playerId number
---@param greater boolean
---@param value number
function M.getPawnByHpThanAndEqual(combatId, playerId, value, greater)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    for i = 0, player:getMaxCombatPawnNumber() do
        local pawn = player:getCombatPawnByIndex(i)
        if pawn then
            if greater then
                if pawn:hp() >= value then
                    return pawn:unique_id()
                end
            else
                if pawn:hp() <= value then
                    return pawn:unique_id()
                end
            end
        end
    end
end

---@param combatId number
---@param playerId number
---@param value number
function M.getPawnByHpEqual(combatId, playerId, value)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    for i = 0, player:getMaxCombatPawnNumber() do
        local pawn = player:getCombatPawnByIndex(i)
        if pawn then
            if pawn:hp() == value then
                return pawn:unique_id()
            end
        end
    end
end

---@param combatId number
---@param playerId number
---@param max boolean
---@return number 返回对应的棋子的id
function M.getPawnByHpMaxOrMin(combatId, playerId, max)
    ---这里不需要判空，如果连这个战斗系统都无法取到的话，可以直接退出游戏，这里的做法无非就是对用户不太友好，
    local player = nn.get_combat(combatId):getPlayer(playerId)
    ---@type Pawn
    local target
    for i = 0, player:getMaxCombatPawnNumber() do
        local pawn = player:getCombatPawnByIndex(i)
        if pawn then
            if not target then
                target = pawn
            end
            if max then
                if target:hp() < pawn:hp() then
                    target = pawn
                end
            else
                if target:hp() > pawn:hp() then
                    target = pawn
                end
            end
        end
    end
    return target:unique_id()
end

---获取到一个本回合还没有发动攻击的棋子
---@deprecated 这个函数不在这里做，由玩法类来实现
---@param combatId number
---@param playerId number
---@return number[]
function M.getPawnCanAttack(combatId, playerId)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    --棋子有可能处于被缴械的状态
    for i = 0, player:getMaxCombatPawnNumber() - 1 do
        local pawn = player:getCombatPawnByIndex(i)
        if pawn then
            
        end
    end
end

--当前玩家所有能够发动攻击的棋子，均发动一次攻击
function M.allPawnAttack(combatId, playId)
    --如果实现这个的话，则不需要再额外实现没有攻击的棋子发动攻击
    
end

---@param combatId number
---@param playerId number
---@return number, number 这里是多返回值，返回的是棋子id、技能id
function M.getPawnCanUseSkill(combatId, playerId)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    for i = 0, player:getMaxCombatPawnNumber() do
        local pawn = player:getCombatPawnByIndex(i)
        ---先判断棋子是否能够使用技能(棋子可能会处于沉默，或者其他导致该棋子无法使用技能的状态),目前还不涉及到buff，这里暂时先不做
        if true then
            ---遍历判断棋子是否满足使用技能的条件(mp要求等)
            local list = pawn:getSkillVec()
            for _, v in ipairs(list) do
                local skill = client.conf.getSkill(v)
                if pawn:check(skill.costType, skill.cost)
                  then
                    return pawn:unique_id(), skill
                end
            end
        end
    end
end

--所有目标选择时，可以不用选择目标的都直接传递-1即可，例如 所有人 所有友军 等等
--简单一点的做法就是根据技能的目标类型来选择不同的棋子作为目标
---@param combat Combat
---@param pawn Pawn
---@param skill SkillS
---@return number 选中的目标
local function getSuitablePawnImpl1(combat, pawn, skill)
    local target = skill.targetType
    --详细参考buff_type文档中的target表格

    --实际上只有这三种情况需要选择目标，其他都不需要
    if target == 1 then
        --1	单个队友
        --这里需要一个算法，可以获取到目标玩家当前最强的棋子
        
    elseif target == 2 then
        --2	单个队友不包含自己
        --这里需要一个算法，可以获取到目标玩家当前最强的棋子

    elseif target == 3 then
        --3	单个敌人
        
    else
        --其他情况中都不需要玩家(AI)去选择目标，直接返回-1，由cpp端去判定最终目标即可
        return -1       
    end
    
    --region
    --if target == 0 then
    --    --0 自己
    --    return -1
    --elseif target == 4 then
    --    --4	所有人
    --    return -1
    --elseif target == 5 then
    --    --5	所有人不包含自己
    --    return -1
    --elseif target == 6 then
    --    --6	自己玩家
    --    return -1
    --elseif target == 7 then
    --    --7	敌方玩家
    --    return -1
    --elseif target == 8 then
    --    --8	随机的单个敌方棋子
    --    return -1
    --elseif target == 9 then
    --    --9	随机的单个友方棋子
    --    return -1
    --elseif target == 10 then
    --    --10 随机的玩家
    --    --要如何才能保证客户端与服务端产出的随机数一致？
    --    return -1
    --elseif target == 11 then
    --    --11 所有友军
    --    return -1
    --elseif target == 12 then
    --    --12 所有敌军
    --    return -1
    --end
    --endregion

end

--复杂一点的，可以为每个技能投增加一个选择目标的算法
local function getSuitablePawnImpl2()
    
end

---取得最优的目标
function M.getMostSuitableTarget(combatId, pawnUid, skillId)
    local combat = nn.get_combat(combatId)
    local pawn = combat:getPawnByUid(pawnUid)
    local skill = client.conf.getSkill(skillId)
    return getSuitablePawnImpl1(combat, pawn, skill)
end

---@param max boolean
function M.getMaxOrMinCostSkill(combatId, pawnUid, max)
    --local player = nn.get_combat(combatId):getPlayer(playerId)
    local pawn = nn.get_combat(combatId):getPawnByUid(pawnUid)
    if pawn then
        local skills = pawn:getSkillVec()
        local id
        local cost = 0
        if max then
            for i, v in ipairs(skills) do
                local skill = client.conf.getSkill(v)
                if skill and skill.cost > cost then
                    cost = skill.cost
                    id = v
                end
            end
        else
            for i, v in ipairs(skills) do
                local skill = client.conf.getSkill(v)
                if skill and skill.cost < cost then
                    cost = skill.cost
                    id = v
                end
            end
        end
        --这里只返回id，如果需要再次读取这个技能的详细信息，需要再次去获取
        return id
    end
    return -1
end

return M