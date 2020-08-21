local Action = require("ai.tree.action")

---@class TurnEnd : Action
local TurnEnd = class("TurnEnd", Action)

function TurnEnd:ctor(data)
    self.super.ctor(self, data)
end

function TurnEnd:tick()
    
end

tree.builder:reg("TurnEnd", TurnEnd)