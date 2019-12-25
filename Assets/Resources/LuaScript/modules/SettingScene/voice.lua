--[[
    luaide  模板位置位于 Template/FunTemplate/NewFileTemplate.lua 其中 Template 为配置路径 与luaide.luaTemplatesDir
    luaide.luaTemplatesDir 配置 https://www.showdoc.cc/web/#/luaide?page_id=713062580213505
    author:{author}
    time:2019-12-25 10:42:40
]]

local Voice = {

}



function Voice:New(super)
    
    local o = {}
    setmetatable(o, self)


    setmetatable(self, super)
    self.__index = super
    return self
end

return Voice