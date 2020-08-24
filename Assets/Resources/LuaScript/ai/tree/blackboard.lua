---这个就是行为数执行的时候所依赖的数据表
---行为树执行的时候通过对这个表里面的值做出判定来决定自身的行为
---@class BlackBoard
local BlackBoard = class("BlackBoard")

--要如何为黑板绑定数据？
function BlackBoard:ctor(data)
    ---@type table<string, any>
    self._data = {}
end

---@return any
function BlackBoard:get(name)
    return self._data[name]
end

return BlackBoard