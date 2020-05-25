---在这里添加所有的插件名称
local plugin = {}
---所有的lua插件会加载对应的init文件
---如果导出模块本身是table，则会加载table中的init方法
---如果导出模块是一个函数，则直接调用这个函数
---否则的话不会执行任何操作
plugin.list = {
    "userInterface",                    ---面向玩家的自定义插件模块
    
}

function plugin:main()
    if plugin.list ~= nil then
        for _, v in ipairs(plugin.list) do
            local f = require(string.format("plugins.%s.init", v))
            local t = type(f)
            if t == "table" then
                f.init()
            elseif t == "function" then
                f()
            end
        end
    end
end

return plugin