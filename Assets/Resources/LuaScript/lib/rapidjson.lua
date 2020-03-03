local rapidjson = require"rapidjson"

---@class RapidJson
local json = {}

---将对象转换成json字符串
---@param obj table
---@return string
function json.encode(obj)
    return rapidjson.encode(obj)
end

---将json字符串转换成表
---@param str string json字符串
---@return table json字符串生成的对象
function json.decode(str)
    return rapidjson.decode(str)
end

return json