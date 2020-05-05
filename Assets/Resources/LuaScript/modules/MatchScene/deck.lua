---@class MatchScene.Deck
local M = {}

-----数据区
--M.

M.counts = {
    ---这里的信息全部都是数组
    ssr = {},
    sr = {},
    r = {},
    n = {}
}

---当前允许选择的卡牌规则
M.regular = {
    ssr = 5,
    sr = 8,
    n = 12,
    r = 15
}

---@param this UnityEngine.Transform
local function Clear(this)
    ---清空当前选择的卡牌
    util.bindButtonCallback(this, function ()
        
    end)
end

---@param this UnityEngine.Transform
local function Ok(this)
    ---保存当前选择的卡牌信息
    util.bindButtonCallback(this, function ()

    end)
end

---@param this UnityEngine.Transform
local function Cancel(this)
    ---取得上次保存的卡牌信息
    util.bindButtonCallback(this, function ()
        
    end)
end

function M.checkCards()
    return true
    --return #(M.counts.ssr) == M.regular.ssr and
    --        #(M.counts.sr) == M.regular.sr and
    --        #(M.counts.r) == M.regular.r and
    --        #(M.counts.n) == M.regular.n
end

local function ConfirmBtnCallback()
    ---先保存当前的牌组，然后向服务端发送一条消息，开始对战
    CS.Global.NavigateTo("BattleScene", true)
end

---@param this UnityEngine.Transform
local function Start(this)
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

local list = {
    Clear = Clear,
    Ok = Ok,
    Cancel = Cancel,
    Start = Start
}

---@param this UnityEngine.Transform
function M.init(this)
    util.loadChild(this, list)
end

return  M