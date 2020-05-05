---@class CardDisplay
local display = {}

---数据区

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
    if this then
        return
    end
    local scroll = this:GetComponent(typeof(CS.EX.ScrollListEx))
    CS.Lib.Listener.Instance:On("scroll_add_gameobject", function (parent, obj, index)
        --log(json.encode(globalTb.myCards[index + 1]))
        ---@type Prefab.CardDisplayScript
        local script = obj:GetComponent(typeof(CS.Prefab.CardDisplayScript))
        script.level.text = globalTb.myCards[index + 1].level
        script.data = globalTb.myCards[index + 1]
    end)
    CS.Lib.Listener.Instance:On("user_click_display_card", function (t)
        log("23333"..t.data.level)
    end)
    scroll:BindDataLength(#(globalTb.myCards))
end


local list = {
    SortPanel = SortPanel,
    Content = Content
}

---@param this UnityEngine.Transform
function display.init(this)
    util.loadChild(this, list)
end

return display