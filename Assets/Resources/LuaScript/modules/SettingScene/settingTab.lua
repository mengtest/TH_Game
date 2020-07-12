local M = {}

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

---@param this UnityEngine.Transform
function M.init(this)
	util.loadChild(this, list)
end

---@param this Scene.SettingScene.VoicePanel
function BGMPanel(this)
	---是否打开这个音效
    this:AddCheckerChangeEvent(function(e)
        log(e)
    end)
	---音效音量改变时的调用
	--this:AddSliderChangeEvent(function(value)
		--CS.Local.Settings.Instance.DefaultConfig.Configs.BgmVol = value
	--end)
end

---@param this Scene.SettingScene.VoicePanel
function EffectPanel(this)
	--this:AddCheckerChangeEvent(function(e)
	--	log(e)
	--end)
	--this:AddSliderChangeEvent(function(value)
	--	log(value)
	--end)
end

return M