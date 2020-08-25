local M = {}

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
    --local player = nn.get_combat(combatId):getPlayer(playerId)
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
            
        end
    end
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

---在当前的战斗中为skillId的技能选择目标棋子，这里的棋子返回的是数组
function M.getTargetBySkillId(combatId, playerId, pawnUid, skillId)
    local player = nn.get_combat(combatId):getPlayer(playerId)
    
end

return M