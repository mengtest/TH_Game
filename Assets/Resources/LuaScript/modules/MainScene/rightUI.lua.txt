---@param this UnityEngine.Transform
local function MainQuest(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        log("你点击了主线按钮")
    end)
end

---@param this UnityEngine.Transform
local function Match(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---只有点击了这个按钮之后才会向服务器请求数据，获取当前玩家的所有的卡牌信息
        CS.Global.NavigateTo("MatchScene")
    end)
end

---@param this UnityEngine.Transform
local function Team(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        --CS.Global.NavigateTo("MatchScene")
    end)
end

---@param this UnityEngine.Transform
local function Feed(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        --CS.Global.NavigateTo("MatchScene")
    end)
end

---@param this UnityEngine.Transform
local function Card(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
        ---只有点击了这个按钮之后才会向服务器请求数据，获取当前玩家的所有的卡牌信息
        CS.Global.NavigateTo("CardScene")
    end)
end

local list = {
    MainQuest = MainQuest,
    Match = Match,
    Card = Card,
    Team = Team,
    Feed = Feed
}

local rightUI = function (this)
    util.loadChild(this, list)
end

return rightUI