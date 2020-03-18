---技能分配器

---
---@class SkillAllocator
local SkillAllocator = {
    skills = {
        
    }
}

---@param data Skill 从服务器，或者本地获得技能相关的数据，然后解析
function SkillAllocator:Create(type, data)
    ---@type Skill
    local skill = self.skills[type]
    if skill then
        skill.load(json.decode(data))
        return skill
    end
    return nil
end

return SkillAllocator