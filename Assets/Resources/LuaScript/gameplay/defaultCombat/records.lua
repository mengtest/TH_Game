---记录战斗中的信息，后期可能会做出伤害统计、战斗回放、战斗结算等相关的功能
---@class Records: Clazz
local Records = class("Records")

function Records:ctor(data)
    self._curRoundAttackPawn = {}
end

---暂时只做棋子发动攻击的记录
function Records:pawnAttack(pawnUid)
    if self._curRoundAttackPawn[pawnUid] then
        self._curRoundAttackPawn[pawnUid] = self._curRoundAttackPawn[pawnUid] + 1
    else
        self._curRoundAttackPawn[pawnUid] = 1
    end
end

function Records:pawnAttackCount(pawnUid)
    return self._curRoundAttackPawn[pawnUid]
end

function Records:clearPawnAttack()
    self._curRoundAttackPawn = {}
end

function Records:pawnHit()
    
end

return Records