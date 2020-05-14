---@class Player
local player = {}

---获取当前玩家的uid
---@return number
function player:GetUid()
    return 100
end

---获取当前玩家的name
---@return string
function player:GetName()
    return "我叫lua"
end

---获取当前玩家的阵容
---@return Card[] 当前选择的卡组阵容，是一个数组
function player:GetLineup()
    return nil
end

---获取当前玩家的等级
---@return number
function player:GetLevel()
    return 0
end

---获取当前玩家的属性,获取的属性全是数值类型
---@param attr string 属性名
---@return number 属性值
function player:GetAttr(attr)
    return 0
end

---获取当前玩家的卡组
---@return table
function player:GetDeck()
    return {}
end

return player