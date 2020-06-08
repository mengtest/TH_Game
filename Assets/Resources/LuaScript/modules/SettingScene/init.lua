local M = {}

---@param this UnityEngine.Transform
function M.Apply(this)
	this:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(function()
		log("保存设置")	
	end)
end

---@param this UnityEngine.Transform
function M.Reset(this)    
	this:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(function()
		log("恢复默认设置")
	end)
end

---@param this UnityEngine.Transform
function M.Confirm(this)
	this:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(function()
		CS.Global.NavigateTo("StartScene", false)
	end)
end

---@param this UnityEngine.Transform
function M.TabView(this)
	require("modules.SettingScene.settingTab").init(this)
end

-----设置场景中可能用到的按钮，其绑定事件的集合
--local list = {
--    Apply = ApplyBtn,
--    Reset = ResetBtn,
--    Confirm = ConfirmBtn
--}

function M.init()
	util.loadChild(CS.Global.GetCurCanvas(), M)
end

return M
