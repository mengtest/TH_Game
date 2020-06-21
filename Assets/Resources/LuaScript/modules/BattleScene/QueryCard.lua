---@class QueryCard
local M = {}

---当前是否正在展示玩家的所有卡牌信息
M.queryCardState = false
M.originQueryX = 0

---@param this UnityEngine.Transform
function M.Head(this)
    M.originQueryX = M.body.transform.localPosition.x
    ---@type Common.Clickable
    local click = this.gameObject:AddComponent(typeof(CS.Common.Clickable))
    click:clickEvent("+", function ()
        ---@type DG.Tweening.Sequence
        local seq = CS.DG.Tweening.DOTween.Sequence()
        if not M.queryCardState then
            M.body:SetActive(true)
            seq:Append(this:DORotate(CS.UnityEngine.Vector3(0, 0, 0), 0.3))
            seq:Append(M.body.transform:DOLocalMoveX(M.originQueryX + 275, 0.3))
        else
            seq:Append(M.body.transform:DOLocalMoveX(M.originQueryX, 0.3))
            seq:Append(this:DORotate(CS.UnityEngine.Vector3(0, 0, -90), 0.3))
        end
        ---这个是自己导出的扩展方法
        seq:Complete(function ()
            if M.queryCardState then    ---隐藏当前玩家的卡牌信息
                M.body:SetActive(false)
            else                        ---展示当前玩家的卡牌信息
                
            end
            M.queryCardState = not M.queryCardState
        end)
        seq:Play()
    end)
end

---@param this UnityEngine.Transform
function M.BodyList(this)
    M.body = this.gameObject
    M.body:SetActive(false)
end

---@param this UnityEngine.Transform
function M.init(this)
    util.loadChild(this, M)
end

return M