local Action = require("ai.tree.action")

---@class Summon : Action
local Summon = class("Summon", Action)

function Summon:ctor(data)
    self.super.ctor(self, data)
end

function Summon:tick()
    --这个东西也可以做到很复杂
end

tree.builder:reg("Summon", Summon)