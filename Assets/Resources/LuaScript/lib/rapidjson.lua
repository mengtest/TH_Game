--[[
    luaide  模板位置位于 Template/FunTemplate/NewFileTemplate.lua 其中 Template 为配置路径 与luaide.luaTemplatesDir
    luaide.luaTemplatesDir 配置 https://www.showdoc.cc/web/#/luaide?page_id=713062580213505
    author:{author}
    time:2020-02-15 11:27:09
]]

local rapidjson = require"rapidjson"

--[[
------@class RapidJson
]]
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


--json.dump = rapidjson.dump
--json.load = rapidjson.load

return json