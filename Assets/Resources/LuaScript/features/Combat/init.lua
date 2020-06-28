---默认的玩法类，在战斗结束时销毁这个对象
---这里实际上就是一个数据类，存储一些当前战斗场景中，当前玩家可见的信息
---当玩家操作场上的对象时，所有的数据变化全部会走这一层，在这一层对场地上所有的信息变化做出更新
---这里使用cocos的class函数来声明一个基类
---可以直接使用DefaultGamePlay.new来构建一个新的对象
---@class DefaultGamePlay
local DefaultGamePlay = class("DefaultGamePlay")

---DefaultGamePlay类的构造函数
---@param data any 构建玩法对象时所需要的一些必要信息，例如双方玩家的卡牌信息
function DefaultGamePlay:ctor(data)
    
end

function DefaultGamePlay:getMyPanelInfo()
    
end

function DefaultGamePlay:getEnemyPanelInfo()

end

---@param msg any
function DefaultGamePlay:onUpdate(msg)
    
end

return DefaultGamePlay