Pool = {
    _list = {
        
    }
}

function Pool:GetItem(signal)
    
end

function Pool:GetItemByFunc(signal, func)
    if Pool._list[signal] ~= nil and #(Pool._list[signal]) > 0 then
        return Pool._list[signal][1]
    else
        Pool._list[signal] = {}
        return func()
    end
end

function Pool:SetItem(signal, value)
    
end

function Pool:Clear(signal)
    
end


function Pool:ClearAll(signal)
    
end

return Pool