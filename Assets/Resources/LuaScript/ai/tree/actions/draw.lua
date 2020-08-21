local Action = require("ai.tree.action")

---@class Draw : Action
local Draw = class("Draw", Action)

function Draw:ctor(data)
    self.super.ctor(self, data)
end

function Draw:tick()
    --根据实际传入的参数决定是普通抽卡还是高级抽卡
end

tree.builder:reg("Draw", Draw)