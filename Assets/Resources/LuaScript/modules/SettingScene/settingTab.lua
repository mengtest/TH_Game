---@param this UnityEngine.Transform
local function SettingPage1(this)
    ---@type Scene.SettingScene.VoicePanel[]
    local components = this:GetComponentsInChildren(typeof(CS.Scene.SettingScene.VoicePanel))
    for i = 0, components.Length - 1 do
        local component = components[i];
        if component.name == "BGMPanel" then
            BGMPanel(component)
        elseif component.name == "EffectPanel" then
            EffectPanel(component)
        end
    end
end

---@param this UnityEngine.Transform
local function SettingPage2(this)

end

---@param this UnityEngine.Transform
local function SettingPage3(this)

end

local list = {
    VoiceView = SettingPage1,
    QualityView = SettingPage2,
    OtherView = SettingPage3
}

---@param luaManager LuaFramework.LuaManager
function init(luaManager)
    local transform = luaManager.transform
    for i = 0, transform.childCount - 1 do
        local child = transform:GetChild(i)
        if list[child.name] ~= nil then
            list[child.name](child)
        end
    end
end

---@param this Scene.SettingScene.VoicePanel
function BGMPanel(this)
    this:AddCheckerChangeEvent(function(e)
        log(e)
    end)
end

---@param this Scene.SettingScene.VoicePanel
function EffectPanel(this)
    
end