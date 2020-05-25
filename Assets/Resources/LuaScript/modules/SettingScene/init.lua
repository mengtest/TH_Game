local M = {}

function M.ApplyBtn()
    log("保存设置")
end

function M.ResetBtn()
    log("恢复默认设置")
end

function M.ConfirmBtn()
    CS.Global.NavigateTo("StartScene", false)
end

-----设置场景中可能用到的按钮，其绑定事件的集合
--local list = {
--    Apply = ApplyBtn,
--    Reset = ResetBtn,
--    Confirm = ConfirmBtn
--}

function M.init()
    ---@type UnityEngine.GameObject[]
    local btns = CS.UnityEngine.GameObject.FindGameObjectsWithTag("btns")
    for i = 0, btns.Length - 1 do
        local btn = btns[i];
        btn:GetComponent(typeof(CS.UnityEngine.UI.Button)).onClick:AddListener(M[btn.name])
    end
end

return M
