--[[
    luaide  模板位置位于 Template/FunTemplate/NewFileTemplate.lua 其中 Template 为配置路径 与luaide.luaTemplatesDir
    luaide.luaTemplatesDir 配置 https://www.showdoc.cc/web/#/luaide?page_id=713062580213505
    author:{author}
    time:2019-12-08 22:28:23
]]

Pool = {
    _list = {

    }
}

function Pool.GetItem(signal)
    
end

function Pool.GetItemByFunc(signal, func)
    if Pool._list[signal] ~= nil and #(Pool._list[signal]) > 0 then
        return Pool._list[signal][0]
    else
        Pool._list[signal] = {}
        return func()
    end
end

function Pool.SetItem(signal, value)
    
end

function Pool.Clear(signal)
    
end


function Pool.ClearAll(signal)
    
end

return Pool