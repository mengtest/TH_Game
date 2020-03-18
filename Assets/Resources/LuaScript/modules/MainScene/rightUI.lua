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
        log("你点击了对战按钮")
    end)
end

local list = {
    MainQuest = MainQuest,
    Match = Match
}

local rightUI = function (this)
    util.loadChild(this, list)
end

return rightUI