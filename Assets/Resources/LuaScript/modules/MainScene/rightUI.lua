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
        CS.Global.NavigateTo("MatchScene")
    end)
end

---@param this UnityEngine.Transform
local function Team(this)

end

---@param this UnityEngine.Transform
local function Feed(this)
    
end

---@param this UnityEngine.Transform
local function Card(this)
    ---@type UnityEngine.UI.Button
    local btn = this:GetComponent(typeof(CS.UnityEngine.UI.Button))
    btn.onClick:AddListener(function ()
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