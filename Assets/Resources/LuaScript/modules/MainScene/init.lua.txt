local M = {}

---@param this UnityEngine.Transform
function LeftTopUI(this)
    ---@type UnityEngine.UI.Text
    local level = CS.Util.ExtendMethods.GetChildByName(this,"Level"):GetComponent(typeof(CS.UnityEngine.UI.Text))
    level.text = "LV." .. player.Level

    ---@type UnityEngine.UI.Text
    local name = CS.Util.ExtendMethods.GetChildByName(this, "UserName"):GetComponent(typeof(CS.UnityEngine.UI.Text))
    name.text = player.Name
end

---@param this UnityEngine.Transform
function RightTopUI(this)
    ---@type UnityEngine.UI.Text
    local power = CS.Util.ExtendMethods.GetChildByName(this, "Power"):GetComponent(typeof(CS.UnityEngine.UI.Text))
    power.text = string.format("%d/%d", player.Power, player.MaxPower)

    ---@type UnityEngine.UI.Text
    local gold = CS.Util.ExtendMethods.GetChildByName(this, "Gold"):GetComponent(typeof(CS.UnityEngine.UI.Text))
    gold.text = player.Gold

    ---@type UnityEngine.UI.Text
    local crystal = CS.Util.ExtendMethods.GetChildByName(this, "Crystal"):GetComponent(typeof(CS.UnityEngine.UI.Text))
    crystal.text = player.Crystal
end

---@param this UnityEngine.Transform
function LeftUI(this)

end

---@param this UnityEngine.Transform
function RightUI(this)
    ---@type UnityEngine.Transform
    local f = require"modules.MainScene.rightUI"
    f(this)
end

---@param this UnityEngine.Transform
function BottomUI(this)

end

uiList = {
    LeftTopUI = LeftTopUI,
    RightTopUI = RightTopUI,
    LeftUI = LeftUI,
    RightUI = RightUI,
    BottomUI = BottomUI
}

function M.init()
    util.loadChild(CS.Global.GetCurCanvas().transform, uiList)
end

return M