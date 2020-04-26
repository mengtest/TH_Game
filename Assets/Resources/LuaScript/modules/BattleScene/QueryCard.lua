---@class QueryCard
local M = {}

---当前是否正在展示玩家的所有卡牌信息
M.queryCardState = false

---@param this UnityEngine.Transform
function M.init(this)
    ---@type Common.Clickable
    local click = this.gameObject:AddComponent(typeof(CS.Common.Clickable))
    click:clickEvent("+", function ()
        ---@type DG.Tweening.Sequence
        local seq = CS.DG.Tweening.DOTween.Sequence()
        local rotate
        if not M.queryCardState then
            rotate = this:DORotate(CS.UnityEngine.Vector3(0, 0, 0), 0.5)
            --display = this
        else
            rotate = this:DORotate(CS.UnityEngine.Vector3(0, 0, -90), 0.5)
        end
        seq:Append(rotate)
        ---这个是自己导出的扩展方法
        seq:Complete(function ()
            if M.queryCardState then    ---隐藏当前玩家的卡牌信息

            else    ---展示当前玩家的卡牌信息
                
            end
            M.queryCardState = not M.queryCardState
        end)
        seq:Play()
    end)
end

return M