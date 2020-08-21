local Action = require("ai.tree.action")

---@class UseSkill : Action
local UseSkill = class("UseSkill", Action)

---棋子使用技能的话，需要区分  XXXX样的棋子对XXXX样的棋子使用XXXX样的技能 这里就需要能够获取到棋子，并且
function UseSkill:ctor(data)
    self.super.ctor(self, data)
end

function UseSkill:tick()

end

tree.builder:reg("UseSkill", UseSkill)