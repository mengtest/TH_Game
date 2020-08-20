---只有这个类以及Input类才回与外部发生耦合
---@class Output
local Output = class("Output")

function Output:ctor()
    ---@type table<string, fun(param1: any) : void>[]
    self._list = {}
    self._running = false
end

---@param name string
---@param data any
function Output:act(name, data)
    ---调用输出函数
    if self._list[name] and not self._running then
        --self._running = true
        --这个函数需要有一个返回值，如果返回true，则表示当前正处于运行状态，否则话表示动作已经执行完成
        local res = self._list[name](data)
        if res then
            self._res = true
        end
        return res
    end
end

---当前的动作完成时调用
function Output:complete()
    --调用这个后直接修改行为树的整体运行状态
    if self._running then
        self._running = false
        ---这里还需要将对应的动作节点设置为完成的状态
    end
end

function Output:print()
    
end

---@param name string
---@param func fun(a: any) : void
function Output:reg(name, func)
    self._list[name] = func
end

return Output