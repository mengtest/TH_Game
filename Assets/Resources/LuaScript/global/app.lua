---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by yuki.
--- DateTime: 2020/5/11 16:14
---

---这里存放一些lua端的初始化操作
local m = {}

local function init()
    CS.Lib.Listener.Instance:On("scene_changed", function (name)
        log(name)
    end)
end

m.init = init

return m