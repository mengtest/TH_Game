---这个是独立于客户端以及服务端的玩法类
---换句话说就是，这个脚本单独拿出来给服务端都是能够直接运行的
---@class GamePlaySingle
local M = {}

--要如何才能实现ai相关的功能？
--感觉ai不能直接复用这边的逻辑

-- ---全局的当前玩家的id
-- ---在玩家登入游戏时这个就应该已经存在了
-- playerId = playerId or 1
-- ---全局的房间id
-- combatId = combatId or -1

--region
--战斗相关的设定
--     1、攻击
--         每回合，每个棋子最多只能攻击一次，如果有特殊机制，需要做特殊处理
--         攻击目标棋子后，目标棋子也会对当前棋子发动一次攻击
--         玩家点击棋子之后，向上滑动一段距离后触发攻击的事件
--     2、使用技能
--         点击棋子身上的技能图标后先判定当前棋子是否能够使用技能，如果能使用技能的话，则要求选择技能的对象，选择技能的对象也满足要求的话，则释放技能      
--             在此期间，都会显示一个取消的按钮，如果玩家点击取消按钮的话，则结束当前使用技能的流程
--     3、结束当前回合
--         只有当前正在行动的玩家可以点击这个按钮，点击后结束当前回合，进入下个回合。 非当前玩家回合的情况下隐藏这个按钮?
--     4、点击抽卡
--         玩家点击两种不同的抽卡按钮，先判定是否有足够的金币，如果没有则提示金币不足，如果足够的话则调用抽奖
--     5、召唤棋子
--         玩家拖动手中的棋子到棋盘中将其召唤到对应的位置上，如果目标位置上已经存在棋子了，则失败，另外，玩家召唤棋子是需要一定的能量的
--endregion



---玩家选择棋子攻击
---如何判定玩家想要触发攻击事件？
---玩家点击自己棋盘上本回合没有攻击过的棋子，向上滑动指定个像素后，向目标位置上发动攻击，如果目标位置上没有棋子，则直接对目标玩家发动攻击
---@param attacker number 要发动攻击的棋子的uid
function M.attack(combatId, playerId, attacker)
    -- if M._list[attacker] then
    --     ---该棋子已经发动过攻击了，无法攻击
    --     ---这里应该提示无法再次攻击
    --     -- CS.Global.MakeToast("该回合此棋子不能再次攻击", CS.Global.TOAST_SHORT)
    --     return false
    -- end
    ---@type Combat
    local combat = nn.get_combat(combatId)
    local worker = combat:getWorkPlayer() 
    ---非当前工作玩家的回合，无法发动攻击Damage
    if worker:uid() ~= playerId then
        return false
    end
    
    ---这个是发动攻击的棋子对象
    local attackPawn = combat:getPawnByUid(attacker)
    local enemy = combat:getEnemy(worker)
    ---这个是被攻击的棋子对象
    local enemyPawn = enemy:getCombatPawnByIndex(attackPawn:pos())
    ---如果发动攻击的棋子对位的位置上有敌方的棋子存在的话，则对这个棋子发动攻击，否则的话对敌方玩家发动攻击
    if enemyPawn then
        ---如果发动攻击的返回值为true的话、则发动攻击的棋子也会受到伤害
        if attackPawn:attack(enemyPawn) then
            --- M._list[attackPawn:unique_id()] = true
            --- attackPawn:opHp()
            --- 当前发动攻击的棋子也受到目标棋子的攻击力的伤害
            --- 这里模拟的反击的动作，此时可能两枚棋子中有一个已经死亡，回到卡池中了，但是本游戏中棋子即使回到卡池中也不会
            local damage = Damage.new(false, enemyPawn:atk(), 1, enemyPawn, attackPawn)
            --- opHp与hit相比较区别在于hit会走受伤的逻辑，而ophp是单纯的增减血量
            attackPawn:hit(damage)
            GamePlay.cur().records:pawnAttack(attacker)
            return true
        end
    else
        ---直接攻击玩家是不会有反击的动作的
        attackPawn:attack(enemy)
        GamePlay.cur().records:pawnAttack(attacker)
        return true
    end
    return false
end

---玩家点击结束当前回合
function M.turnEnd(combatId, playerId)
    local combat = nn.get_combat(combatId)
    local curPlayer = combat:getWorkPlayer()
    ---如果当前玩家获取出错的话，程序可以退出
    -- nn.get_combat(combatId):turnEnd(playerId)
    if curPlayer:uid() == playerId then
        combat:turnEnd(playerId)
        return true
    else
        -- CS.Global.MakeToast("不是你的回合", CS.Global.TOAST_SHORT);
        return false
    end
end

---玩家选择棋子对目标使用技能
function M.useSkill(combatId, playerId, pawnId, targetId, skillId)
    local combat = nn.get_combat(combatId)
    local worker = combat:getWorkPlayer()
    ---非当前工作玩家的回合无法使用技能
    if worker:uid() ~= playerId then
        return false
    end
    local pawn = combat:getPawnByUid(pawnId)
    local target = combat:getPawnByUid(targetId)
    if not pawn:useSkillWithCost(target, skillId) then
        ---条件不足，无法使用该技能
        -- CS.Global.MakeToast("条件不足，无法使用该技能", CS.Global.TOAST_SHORT);
        return false
    end
end

---玩家点击抽取卡牌按钮
---玩家的抽卡其实只会抽一张卡，所以这里的数量其实默认为1
function M.draw(combatId, playerId, number, high)
    local gold
    if high then
        -- gold = config.highPrice * number
        --这个应该从配置表中来，如果不想再读表的话，应该直接导出配置
        gold = nn.getConfig().highDrawPrice
    else
        -- gold = config.normalPrice * number
        gold = nn.getConfig().normalDrawPrice
    end
    local combat = nn.get_combat(combatId)
    local worker = combat:getWorkPlayer()
    ---非当前工作玩家的回合无法抽卡、这里只是在玩家点击抽取卡牌按钮时阻止抽卡，但是不排除以后会出现有特殊效果的卡牌，可以让地方抽卡
    if worker:uid() ~= playerId then
        return false
    end
    local player = combat:getPlayer(playerId)
    if player:gold() >= gold then
        player:opGold(-gold)
        player:draw(number, high)
        return true
    else
        ---金币不足，无法抽取新的棋子
        -- CS.Global.MakeToast("金币不足", CS.Global.TOAST_SHORT);
        -- 这个应该是有一个返回值，表示当前操作是否成功
        return false
    end
end

---玩家召唤棋子
function M.summon(combatId, playerId, pawnId, pos)
    local combat = nn.get_combat(combatId)
    local worker = combat:getWorkPlayer()
    ---非当前工作玩家的回合无法召唤棋子
    if worker:uid() ~= playerId then
        return false
    end
    local player = combat:getPlayer(playerId)
    ---召唤棋子需要能量，
    local energy = player:energy()
    if player:getCombatPawnByIndex(pos) then
        ---目标位置上已经存在棋子了
        ---方便测试的一段提示信息
        --CS.Global.MakeToast("不能放置多枚棋子", CS.Global.TOAST_SHORT);
        return false
    end
    ---这里的这个2应该是从配置文件中来
    if energy >= 2 then
        ---方便测试的一段提示信息
        --CS.Global.MakeToast("11111111111111111111", CS.Global.TOAST_SHORT);
        player:opEnergy(-2)
        player:summon(pawnId, pos)
        return true
    else
        ---能量不足，无法召唤棋子
        -- CS.Global.MakeToast("能量不足，无法召唤", CS.Global.TOAST_SHORT);
        return false
    end 
end

---@param myCards number[]
---@return number , number, number  当前战斗系统的id、当前玩家id、敌方玩家id
function M.init(playerId, enemyId, myCards, enemyCards)
    -- print(json.encode(myCards))
    -- local playerId = player.Uid or 1
    ---离线模式下敌人为ai，id为-1
    -- local enemyId = -1
    -- local combatId = nil
    -- M._player = playerId
    enemyCards = enemyCards or {
        14,14,4,8,7,2,1,1,22,22,23,23,23,23,24,20,19,18,55,56,56,57,57,58,58,54,
        54,54,53,52,86,85,84,84,84,84,84,84,84,83,83,83,83,83,83,82,82,82,82,82
    }
    local cid = nn.create_combat()
    if cid == -1 then
        --- 创建失败
        nn.log("创建战斗系统失败")
    else
        --- combatId直接存放到全局的表中
        --- M._combatId = cid
        nn.log(string.format("新建一个战斗系统，战斗系统的id是%d", cid))
    end
    --- 只要id不为0，基本一定能够取出combat对象
    local combat = nn.get_combat(cid)
    -- log(tostring(combat:id()))
    if combat then
        -- print(combat.addPlayer)
        --- 添加当前玩家的数据
        if combat:addPlayer(playerId, myCards)
            --- 添加机器人的数据
            --- 这里的卡牌数据应该从配置文件中来
            and combat:addPlayer(enemyId, enemyCards) then
            
        end
    end
    return cid
end

return M