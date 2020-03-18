---技能拦截器

---@class SkillFilter
local SkillFilter = {
    ---对象列表
    _list = {
        caller = {
            ---拦截的tag
            tag = func
        },
        caller2 = {

        }
    },
    _global = {
        tag = func,
    }
}

---@param skill Skill
function SkillFilter.filter(skill)
    
end

---注册一个拦截器
---@param tag string
---@param func function
function SkillFilter.reg(caller, tag, func)
    if SkillFilter._list[caller] == nil then
        SkillFilter._list[caller] = {}
    end

    if SkillFilter._list[caller][tag] == nil then
        SkillFilter._list[caller][tag] = func
    end
end 

return SkillFilter