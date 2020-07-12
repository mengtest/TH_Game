local M = {
    
}

---@type IGamePlay
M.default = nil

local _list = {}

---@param clazz IGamePlay
function M.reg(name, clazz)
    if not _list[name] then
        _list[name] = clazz
    end
end

---@return IGamePlay
function M.get(name)
    return _list[name]
end

return M