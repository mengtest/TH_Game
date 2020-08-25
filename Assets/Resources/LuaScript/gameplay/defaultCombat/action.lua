---这个脚本单独拿出来丹服务端或者客户端都能够直接使用
---@class GamePlayEventHandle
local M = {}

M.update = nil
M.notice = nil

---@param str string
function NoticeFun(str)
    --log(str)
    if M.notice then
        M.notice(str)
    end
end

---每次有对象的属性更新时，调用此函数
---@param attr AttrStruct
function UpdateFun(attr)
    ---更新ui的逻辑放在了
    if M.update then
        ---因为cpp端传入的事件对象为栈对象，在本函数执行完成之后就没了，所以需要转存一下
        ---@type AttrStruct
        local item = {}
        item.type = attr.type
        item.objectId = attr.objectId
        item.value = attr.value
        item.playerId = attr.playerId
        item.combatId = attr.combatId
        item.targetType = attr.targetType
        M.update(item)
    end
end

---@param updateFunc fun(a:AttrStruct):void
function M.regUpdate(updateFunc)
    M.update = updateFunc
end

---@param noticeFunc fun(a:string):void
function M.regNotice(noticeFunc)
    M.notice = noticeFunc
end

return M