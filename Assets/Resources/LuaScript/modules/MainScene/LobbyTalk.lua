﻿-----@type UnityEngine.Rect
--local rect 
--local lobby 

-----@param this LuaFramework.LuaManager
--function init(this)
--    --rect = this:GetComponent(typeof(CS.UnityEngine.RectTransform))
--    --lobby = this:GetComponent(typeof(CS.Scene.MainScene.LobbyTalkScript))
--    
--    local child = this.transform:GetChild(0)
--    child:SetParent(nil);
--    child:SetParent(this.transform);
--end

--function update()
--    ---点击聊天框后显示完整得聊天框，否则显示部分聊天框
--    if CS.UnityEngine.Input.GetMouseButtonDown(0) then
--        local width = rect.rect.width
--        local height = rect.rect.height
--        local r = CS.UnityEngine.Rect(rect.transform.position.x - width / 2
--                    , rect.transform.position.y - height / 2 
--                    , width, height)
--        if r:Contains(CS.UnityEngine.Input.mousePosition) then
--            lobby:Show()
--        else
--            lobby:Hide()
--        end
--    end
--end

---个人感觉实现点击到指定目标与没有点击指定的目标的方法通过几个不同的事件接口协同来完成最好
---比如 可以实现鼠标移入移出的事件，当鼠标移出时设置为false，鼠标移入时设置为true这个方式会比较好