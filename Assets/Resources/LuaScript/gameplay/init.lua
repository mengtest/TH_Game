local M = {
    
}

---@type IGamePlay
M.default = nil
M._cur = nil
M._list = {}

---@param clazz IGamePlay
function M.reg(name, clazz)
    if not M._list[name] then
		M._list[name] = clazz
    end
end

---@return IGamePlay
function M.cur()
	return M._cur
end

---@return IGamePlay
function M.create(name)
	if M._list[name] then
		M._cur = M._list[name].new()
	end
	return M._cur
end

return M