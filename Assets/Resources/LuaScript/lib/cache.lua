local m = {
    
}

local _cache = {}

---@param key string
---@return any|nil
function m.get(key)
    local data = _cache[key]
    _cache[key] = nil
    return data
end

---@param key string
---@param value any
function m.store(key, value)
    _cache[key] = value
end

return m