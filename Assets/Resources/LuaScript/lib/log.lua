---@class Log
---@field public LEVEL Log 
local _log = {}

LOG_INFO = 1
LOG_ERROR = 2
LOG_DEBUG = 3

_log.LEVEL = LOG_INFO

---@param msg string 要输出的内容
---@param level string|number 日志等级
function _log.log(msg, level)
    local color = nil
    local l = nil
    local lv = level or _log.LEVEL
    if _log.LEVEL == LOG_INFO then
        l = " [INFO] "
        color = 'yellow'
    elseif _log.LEVEL == LOG_ERROR then
        l = " [ERROR] "
        color = 'red'
    elseif _log.LEVEL == LOG_DEBUG then
        l = " [DEBUG] "
        color = 'blue'
    else
        l = " ["..tostring(lv).."] "
        color = "gold"
    end
    CS.Global.Log(string.format("LUA: %s <color=%s>%s</color>", l, color, tostring(msg)))
end

---@param level string|number 设置日志的等级
function _log.setLevel(level)
    _log.LEVEL = " ["..tostring(level).."] "
end

return _log