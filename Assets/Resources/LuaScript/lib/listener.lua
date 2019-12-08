local _listener = {}

_listener.map = {

}

--取得对象实例
function _listener:instance()
    self.map = self.map or {}
    return self
end

--@desc 触发一个事件
function _listener:event(type)
    
end

--@desc 注册一个事件
--@singal: 事件的唯一标识符，可以为空
function _listener:on(type, callback, singal)
    
end

--@desc 移除一个事件
function _listener:off(type)

end



return _listener


