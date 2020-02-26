local util = {}

---@param str string 要切割的字符串
---@param reps string 分隔符
---@return table 返回字符串数组
function util.splice(str, reps)
    local res = {}
    string.gsub(
        str,
        "[^" .. reps .. "]+",
        function(w)
            table.insert(res, w)
        end
    )
    return res
end

---@param content string 文本内容
---@return table 返回由配置文件构成的表,为映射(C++中的map)
function util.readCfgFile(content)
    local t = {}
    local lines = util.splice(content, "\n")
    local comment = string.byte("#")
    for _, line in pairs(lines) do
        --忽略掉第一个字符为#的行
        if comment ~= string.byte(line, 1, 1) then
            local key, value = string.match( line, "%s*(%S*)%s*=%s*%s*(%S*)")
            if key and value then
                t[key] = value 
            end
        end
    end
    return t
end

return util