---@class MatchScene.Deck
local M = {}

--- 数据区
--- 这里的信息全部都是数组
--- 保存的是玩家当前所选择的所有的卡牌
M.counts = {
    SSR = 0,
    SR = 0,
    R = 0,
    N = 0
}

--- 当前允许选择的卡牌规则
--- 这个应该是服务端传入的数据
--- 或者是由客户端传入卡牌数据给服务端，服务端做验证
--- 后续可能会对这个规则作出一些修改，譬如sr可以超过指定的张数，但是超过的部分会由更高级的ssr来弥补
M.regular = {
    SSR = 8,
    SR = 10,
    R = 12,
    N = 20
}

--- 当前玩家所选择的卡牌列表
--- 与玩家持有的卡牌列表是相同的结构
M.selectedCardList = {
    
}

---这里存放当前各个类型的卡牌数量的控件的
M.controls = {
}

---遍历当前选择的卡牌数组，查找目标id的卡牌，并返回其信息
---@param id number
function M.getSelectCard(id)
    for i, v in ipairs(M.selectedCardList) do
        if v[1] == id then
            return v
        end
    end
    return nil
end

---@param this UnityEngine.Transform
function M.Display(this)
    --- 上方展示当前所有选择的卡牌的数量的组件
    for i = 0, this.childCount - 1 do
        local child = this:GetChild(i)
        local name = string.upper(child.name)
        ---@type UnityEngine.UI.Text
        local numLabel = child:GetChildByName("Num"):GetComponent(typeof(CS.UnityEngine.UI.Text))
        M.controls[name] = numLabel
        local str = string.format("%d/%d", M.counts[name], M.regular[name])
        numLabel.text = str
    end
end

---@param this UnityEngine.Transform
function M.Clear(this)
    ---清空当前选择的卡牌
    util.bindButtonCallback(this, function ()
        --- 询问是否需要清除当前所有的选择
        --- 玩家确定之后清空当前选择的卡组
    end)
end

---@param this UnityEngine.Transform
function M.Ok(this)
    ---保存当前选择的卡牌信息
    util.bindButtonCallback(this, function ()
        --- 询问玩家是否保存当前卡组
        --- 玩家点击确定之后保存当前选择的卡组
    end)
end

---@param this UnityEngine.Transform
function M.Cancel(this)
    --- 取得上次保存的卡牌信息
    util.bindButtonCallback(this, function ()
        --- 询问玩家是否取消当前的卡组，
        --- 玩家点击确定之后，还原到上次保存的卡组
    end)
end

function M.checkCards()
    return M.counts.SSR == M.regular.SSR
        and  M.counts.SR == M.regular.SR
        and  M.counts.R == M.regular.R
        and  M.counts.N == M.regular.N
end

local function ConfirmBtnCallback()
    ---先保存当前的牌组，然后向服务端发送一条消息，开始对战
    CS.Global.NavigateTo("BattleScene", true)
end

---@param this UnityEngine.Transform
function M.Start(this)
    ---先要弹出对话框，检测当前的卡牌是否符合要求，询问是否以当前选择的卡组开始匹配
    ---玩家点击确认之保存当前的卡牌信息，然后开始匹配
    util.bindButtonCallback(this, function ()
        ---如果当前卡牌的数量满足给定的要求的话，则弹出对话框，询问是否以当前卡组开始游戏
        if M.checkCards() then
            local dialog = CS.Util.ModelDialog("是否以当前所选择的牌组开始对战？", "是", "否", ConfirmBtnCallback)
            dialog:ShowDialog()
        else
            CS.Global.MakeToast("<color=red>当前卡组不满足要求</color>", CS.Global.TOAST_SHORT)
        end
    end)
end

---@param this UnityEngine.Transform
function M.CardList(this)
    ---每次初始化的时候，都会重置这个数组
    M.selectedCardList = {}
    
    ---@type EX.ScrollListEx
    local scroll = this:GetComponent(typeof(CS.EX.ScrollListEx))
    ---在右侧的组件中反映出当前玩家选择的卡组信息
    scroll:scrollListAddObjectCallback("+", function (object, index)
        ---@type Prefab.CardLabelScript
        local node = object:GetComponent(typeof(CS.Prefab.CardLabelScript))
        ---记得CS中的下标转化为Lua中的下标，需要+1！
        local card = M.selectedCardList[index + 1]
        local data = global.cardInfos[card[1]]
        node.RareType = util.idToType(data.type)
        --log(node["RareType"])
        node.CardName = data.name
        node.Number = card[2]
    end)

    ---玩家当前选择的卡牌被修改的事件
    ---传入参数为玩家点击的卡牌的id
    CS.Lib.Listener.Instance:On("user_select_deck_changed", function (value)
        local card = M.getSelectCard(value)
        local data = global.cardInfos[value]
        local type = util.idToType(data.type)
        M.counts[type] = M.counts[type] + 1
        M.controls[type].text = string.format("%d/%d", M.counts[type], M.regular[type])
        if card == nil then
            table.insert(M.selectedCardList, {value, 1})
        else
            ---如果存在这个卡牌，那么其数量 + 1
            card[2] = card[2] + 1
        end
        scroll:BindDataLength(#M.selectedCardList)
    end, scroll.gameObject, CS.Lib.KeyCode.None, false)
    
    ---传入参数为点击的对象本身
    CS.Lib.Listener.Instance:On("user_click_card_list_item", function (t)
        ---每次点击右侧的对象之后，都会减少该卡牌一次，如果卡牌的数量减少为0，则不再显示
        
    end)
    
    scroll:BindDataLength(#M.selectedCardList)
end

--local list = {
--    Clear = Clear,
--    Ok = Ok,
--    Cancel = Cancel,
--    Start = Start,
--    Display = Display,
--    CardList = CardList
--}

---@param this UnityEngine.Transform
function M.init(this)
    M.counts = {
        SSR = 0,
        SR = 0,
        R = 0,
        N = 0
    }
    M.selectedCardList = {

    }
    util.loadChild(this, M)
end

return  M