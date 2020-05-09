---@class CardDisplay
local display = {}

---这里是对所有卡牌进行排序相关的操作，这里可能会出现不显示某些卡牌的事件，所以还是需要完善rect的绑定数据方法
---@param this UnityEngine.Transform
local SortPanel = function(this)
    ---@type UnityEngine.UI.Dropdown
    local sort = this:GetChildByName("Sort"):GetComponent(typeof(CS.UnityEngine.UI.Dropdown))
    sort.onValueChanged:AddListener(function (value)
        log(sort.options[value].text)
    end)
end

---@param this UnityEngine.Transform
local Content = function(this)
    ---@type EX.ScrollListEx
    local scroll = this:GetComponent(typeof(CS.EX.ScrollListEx))
    
    ---监听列表中每个卡牌的点击事件
    ---@type Prefab.CardDisplayScript2
    CS.Lib.Listener.Instance:On("user_click_display_card2", function (t)
        ---第一个参数是这个卡牌的id
        ---这里的想法是，再次触发一个事件、由右侧的ui去响应这个事件
        ---传递的参数是这个对象所有的数据
        ---虽然，这个物体里面存储了这张卡牌的id以及数量，但是只是用于展示的，
        local card = display.getCard(t.data[1])
        if card and card[2] > 0 then
            card[2] = card[2] - 1
            ---点击后触发这个事件，传入的参数是卡牌的id
            CS.Lib.Listener.Instance:Event("user_select_deck_changed", card[1])
        else
            ---如果数量为0的话，则将对应的图片修改为灰色的
        end
        --scroll:BindDataLength(#global.myCards)
    end, scroll.gameObject)
    
    ---为每个新增的对象设置属性
    scroll:scrollListAddObjectCallback("+", function(obj, index)
        ---@type Prefab.CardDisplayScript2
        local script = obj:GetComponent(typeof(CS.Prefab.CardDisplayScript2))
        script.data = global.myCards[index + 1]
        ---第一个字段是卡牌的id
        ---第二个字段是卡牌的数量
        local data = global.cardInfos[script.data[1]]
        script.content.sprite = util.loadSprite("Image/Card/"..data.img)
        script.count.text = string.format("X%d", script.data[2])
    end)
    
    scroll:BindDataLength(#global.myCards)
end

---对当前的数组做排序
function display.sort()
    
end

---@param id number
function display.getCard(id)
    for i, v in ipairs(display.myCards) do
        if v[1] == id then
            return v
        end
    end
    return nil
end

local list = {
    SortPanel = SortPanel,
    Content = Content
}

---@param this UnityEngine.Transform
function display.init(this)
    ---复制完整的数据
    display.myCards = util.copy(global.myCards)
    util.loadChild(this, list)
end

return display