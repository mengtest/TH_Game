---默认游戏玩法(战斗系统)的入口
---当前战斗系统中所有的数据保存，以及数据的更新都在这里
---@class DefaultGamePlay
local DefaultGamePlay = util.class("DefaultGamePlay")

local action = require"gameplay.defaultCombat.action"

---要如何才能实现ai相关的功能？
---感觉ai不能直接复用这边的逻辑

-- ---全局的当前玩家的id
-- ---在玩家登入游戏时这个就应该已经存在了
-- playerId = playerId or 1
-- ---全局的房间id
-- combatId = combatId or -1

---在cpp端应该有各个流程的导出

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

---@field public id number
---@field public num number
---@class UIDeckCardItem
local _ = {}

---构造函数
function DefaultGamePlay:ctor()
    --self:init()
    ---当前回合中已经发动攻击了的棋子列表
    ---每个回合会重置这个
    self._list = {}
    ---当前玩家的uid
    self._player = 0
    ---当前对局中所有玩家的uid
    self._players = {}
    ---当前对局的id
    self._combatId = -1
    ---当前对局中所有卡牌的uid到其id的映射
    self._map = {}
    self._pawnSize = 0
    ---这个是卡牌的原始id到卡牌的
    ---@type UIDeckCardItem[]
    self._cardsBuildForLeftUi = {}
    ---@type Records
    self.records = require("gameplay.defaultCombat.records").new()

    ---当玩家抽卡或者其他修改了这个卡组的时候触发这个事件
    CS.Lib.Listener.Instance:On("player_deck_card_update", function (plus, uid)
        local id = self._map[uid]
        if id then
            local item = self:getLeftDeckCardItemById(uid)
            if item then
                if plus then
                    item.num = item.num + 1 
                else
                    item.num = item.num - 1
                end
            end
        end
    end, CS.Lib.Listener.Instance:SceneUniqueObject())
end

function DefaultGamePlay:getLeftDeckCardItemById(id)
    for i, v in pairs(self._cardsBuildForLeftUi) do
        if v.id == id then
            return v
        end
    end
    return nil
end

function DefaultGamePlay:getLeftUiList()
    return self._cardsBuildForLeftUi
end

function DefaultGamePlay.bindUpdate(func)
    action.regUpdate(func)
end

function DefaultGamePlay.bindNotice(func)
    action.regNotice(func)
end

---玩家选择棋子攻击
---如何判定玩家想要触发攻击事件？
---玩家点击自己棋盘上本回合没有攻击过的棋子，向上滑动指定个像素后，向目标位置上发动攻击，如果目标位置上没有棋子，则直接对目标玩家发动攻击
---@param attacker number 要发动攻击的棋子的uid
function DefaultGamePlay:attack(playerId, attacker)
    
    --region
    -- if self._list[attacker] then
    --     ---该棋子已经发动过攻击了，无法攻击
    --     ---这里应该提示无法再次攻击
    --     CS.Global.MakeToast("该回合此棋子不能再次攻击", CS.Global.TOAST_SHORT);
    --     return 
    -- end
    -- ---@type Combat
    -- local combat = nn.get_combat(self._combatId)
    -- local attackPawn = combat:getPawnByUid(attacker)
    -- if attackPawn:attack() > 0 then
    --     self._list[attackPawn:unique_id()] = true
    --     --- attackPawn:opHp()
    --     --- 当前发动攻击的棋子也受到目标棋子的攻击力的伤害
    --     local enemy = combat:getEnemy(combat:getWorkPlayer()):getCombatPawnByIndex(attackPawn:pos())
    --     local damage = Damage.new(false, atk, 1, enemy, attackPawn)
    --     --- opHp与hit相比较区别在于hit会走受伤的逻辑，而ophp是单纯的增减血量
    --     attackPawn:hit(damage);
    -- end
    --endregion

    local t = require"gameplay.defaultCombat.gameplayLogicSingle"
    if not t.attack(self._combatId, playerId, attacker) then
        log"发动攻击失败"
    end
end

---玩家点击结束当前回合
function DefaultGamePlay:turnEnd(playerId)
    
    --region
    -- local combat = nn.get_combat(self._combatId)
    -- local curPlayer = combat:getWorkPlayer()
    -- -- nn.get_combat(combatId):turnEnd(playerId)
    -- if curPlayer:uid() == playerId then
    --     combat:turnEnd(playerId)
    -- else
    --     CS.Global.MakeToast("不是你的回合", CS.Global.TOAST_SHORT);
    -- end
    --endregion

    local t = require"gameplay.defaultCombat.gameplayLogicSingle"
    if not t.turnEnd(self._combatId, playerId) then
        log"当前不是您的回合"
    end
    --table.remove()
    
end

---玩家选择棋子对目标使用技能
function DefaultGamePlay:useSkill(playerId, pawnId, targetId, skillId)
    --region
    -- local combat = nn.get_combat(self._combatId)
    -- local pawn = combat:getPawnByUid(pawnId)
    -- local target = combat:getPawnByUid(targetId)
    -- if not pawn:useSkillWithCost(target, skillId) then
    --     ---条件不足，无法使用该技能
    --     CS.Global.MakeToast("条件不足，无法使用该技能", CS.Global.TOAST_SHORT);
    -- end
    --endregion

    local t = require"gameplay.defaultCombat.gameplayLogicSingle"
    if not t.useSkill(self._combatId, playerId, pawnId, targetId, skillId) then
        log"无法使用该技能"
    end
end

---玩家点击抽取卡牌按钮
---玩家的抽卡其实只会抽一张卡，所以这里的数量其实默认为1
function DefaultGamePlay:draw(playerId, number, high)
    --region
    -- local gold
    -- if high then
    --     gold = global.config.highDrawPrice * number
    -- else
    --     gold = global.config.normalDrawPrice * number
    -- end
    -- local combat = nn.get_combat(self._combatId)
    -- local player = combat:getPlayer(playerId)
    -- if player:gold() >= gold then
    --     player:opGold(-gold)
    --     player:draw(number, high)
    -- else
    --     ---金币不足，无法抽取新的棋子
    --     CS.Global.MakeToast("金币不足", CS.Global.TOAST_SHORT);
    -- end
    --endregion
    
    local t = require"gameplay.defaultCombat.gameplayLogicSingle"
    if not t.draw(self._combatId, playerId, number, high) then
        log"抽卡失败"
    end
end

---玩家召唤棋子
function DefaultGamePlay:summon(playerId, pawnId, pos)
    --region
    -- local combat = nn.get_combat(self._combatId)
    -- local player = combat:getPlayer(playerId)
    -- ---召唤棋子需要能量，
    -- local energy = player:energy()
    -- if player:getCombatPawnByIndex(pos) then
    --     ---目标位置上已经存在棋子了
    --     CS.Global.MakeToast("不能放置多枚棋子", CS.Global.TOAST_SHORT);
    --     return
    -- end
    -- ---这里的这个2应该是从配置文件中来
    -- if energy >= 2 then
    --     player:opEnergy(-2)
    --     player:summon(pawnId, pos)
    -- else
    --     ---能量不足，无法召唤棋子
    --     CS.Global.MakeToast("能量不足，无法召唤", CS.Global.TOAST_SHORT);
    -- end 
    --endregion
    
    local t = require"gameplay.defaultCombat.gameplayLogicSingle"
    if not t.summon(self._combatId, playerId, pawnId, pos) then
        log"召唤失败"
    end 
end

---因为这里需要修改的内容比较多，所以重写逻辑
---@param myCards number[]
---@param enemyCards number[]
---@return number , number, number  当前战斗系统的id、当前玩家id、敌方玩家id
function DefaultGamePlay:init(myCards, enemyCards)
    -- require"gameplay.defaultCombat.action"
    enemyCards = enemyCards or {
        14,14,4,8,7,2,1,1,22,22,23,23,23,23,24,20,19,18,55,56,56,57,57,58,58,54,
        54,54,53,52,86,85,84,84,84,84,84,84,84,83,83,83,83,83,83,82,82,82,82,82
    }
    -- print(json.encode(myCards))
    --限制player的Id为1
    -- local playerId = player.Uid or 1
    local playerId = 1
    ---离线模式下敌人为ai，id为-1
    local enemyId = -1
    -- local combatId = nil
    self._player = playerId
    table.insert(self._players, playerId)
    table.insert(self._players, enemyId)
    local cid = nn.create_combat()
    if cid == -1 then
        --- 创建失败 
        log("创建战斗系统失败")
    else
        --- combatId直接存放到全局的表中
        self._combatId = cid
        log(string.format("新建一个战斗系统，战斗系统的id是%d", self._combatId))
    end
    --- 只要id不为0，基本一定能够取出combat对象
    local combat = nn.get_combat(self._combatId)
    -- log(tostring(combat:id()))
    if combat then
        -- print(combat.addPlayer)
        --- 添加当前玩家的数据
        if combat:addPlayer(playerId, myCards)
            --- 添加机器人的数据
            --- 这里的卡牌数据应该从配置文件中来
            and combat:addPlayer(enemyId, enemyCards) then
            ---运行到这里，说明战斗系统的初始化已经完成了
            local this = combat:getPlayer(playerId):data()
            local target = combat:getPlayer(enemyId):data()
            local tempList = {}
            for i = 1, #myCards do
                self._map[this.pawns[i]] = this.cards[i]
                if not tempList[this.cards[i]] then
                    tempList[this.cards[i]] = 1
                else
                    tempList[this.cards[i]] = tempList[this.cards[i]] + 1
                end
                self._map[target.pawns[i]] = target.cards[i]
            end
            for i, v in pairs(tempList) do
                table.insert(self._cardsBuildForLeftUi, {id = i, num = v})
            end
            self._pawnSize = #myCards + #enemyCards
        end
    end
    return self._combatId, self._player, enemyId
end

function DefaultGamePlay:combatStart()
    local combat = nn.get_combat(self._combatId)
    if combat then
        combat:start()
        nn.log(string.format("战斗正式开始，当前的战斗系统的id是%d", combat:id()))
    end
end

---当前玩家的战斗准备完成时调用这个
function DefaultGamePlay:prepareComplete()
    -- CS.Lib.Listener.Instance:On("")
end

---返回当前所有的玩家列表
function DefaultGamePlay:getPlayerList()
    return self._players
end

---是否获取敌方玩家
function DefaultGamePlay:getPlayer(this)
    if not this then
        return self._player
    end
    return self._players[2]
end

-- ---@return IUserInput
-- function DefaultGamePlay:getHandle()
--     return self.impl.handle
-- end

---进入战斗系统的逻辑应该是
---玩家选择所有的卡牌之后，点击确认按钮，如果当前的卡牌满足要求，则会进入战斗系统，

---获取当前玩家的卡组列表
function DefaultGamePlay:getCurPawnList()
    local combat = nn.get_combat(self._combatId)
    if combat then
        
    end
end

function DefaultGamePlay:getPawnList()
    local t = {}
    for i, v in pairs(self._map) do
        table.insert(t, v)
    end
    return t
end

function DefaultGamePlay:getCombatId()
    return self._combatId
end

---现在的问题是客户端要如何存储玩家相关的数据，还是说就做成帧同步，然后从dll中获取数据？
---@param myCards number[]
function DefaultGamePlay:start(myCards, enemyCards)
    ---当前的房间号，未初始化时为-1
    -- self.combatId = -1
    ---当前玩家的id
    -- self.myId = 0
    ---敌方玩家的id，0表示未初始化，-1表示机器人
    -- self.tid = 0
    
    -- self.impl = require"scripts.userInput.init"
    -- self.impl.init(myCards)
    self:init(myCards, enemyCards)
    ---调用这个之后通知服务端，当前客户端已经加载完成，等待所有客户端加载完成
    ---当所有的客户端都加载完毕之后进入战斗场景
end

function DefaultGamePlay:getIdByUid(uid)
    return self._map[uid]
end

-- ---@param this boolean 是否是当前玩家
-- ---@return CombatPlayer
-- function DefaultGamePlay:getPlayer(this)
    
-- end

return DefaultGamePlay