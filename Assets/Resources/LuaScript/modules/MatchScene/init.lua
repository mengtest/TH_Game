---@class MatchScene
local M = {}

---@param this UnityEngine.Transform
local function Return(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        --log("返回到游戏主场景中")
        ---如果玩家当前还有没有保存的操作，则需要提示是否放弃保存直接退出
        CS.Global.NavigateTo("MainScene", true)
    end)
end

local l = {
    Return = Return,
    Deck = require"modules.MatchScene.deck",                    ---左侧展示所有卡牌信息的组件
    CardDisplay = require"modules.MatchScene.cardDisplay"       ---右侧的展示当前卡牌列表相关的组件
}

function init()
    ---如果cardInfos为空，则创建
    ---@type CCard[]
    global.cardInfos = global.cardInfos or json.decode(CS.Util.Loader.Read("LuaScript/json/cards"))
    ---为什么这个数据采用数组的形式，而非使用id作为下标，或者维护两份数据？
    ---第一个就是采用数组的形式，会便于显示；二是将来会由排序等功能，如果使用id作为下标的话，那么数据的位置是固定的，无法排序
    ---现在我同样维护两份数据、这里的表示的是玩家持有的卡牌的原始信息，另一份就是当前可选择的卡牌信息
    global.myCards = global.myCards or json.decode(CS.Util.Loader.Read("LuaScript/json/myCards"))
    
    ---这里暂时命名为MatchScene，主要是给玩家自定义卡组的
    util.loadChild(CS.Global.GetCurCanvas().transform, l)
end


---目前设想的方式是，每个场景都不再添加额外的luaManager了，而是在场景跳转的时候加载目标场景同名的lua文件
---同时，从global空间下面获取目标场景同名的对象，并调用其init函数，这样就可以将数据存放到各个lua模块下面
---同时，会独立出消息区，以及数据区，方便后面直接查找对应的模块
M.init = init

return M