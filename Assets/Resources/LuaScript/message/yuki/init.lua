--[[
    luaide  模板位置位于 Template/FunTemplate/NewFileTemplate.lua 其中 Template 为配置路径 与luaide.luaTemplatesDir
    luaide.luaTemplatesDir 配置 https://www.showdoc.cc/web/#/luaide?page_id=713062580213505
    author:{author}
    time:2020-02-09 22:57:09
]]

--local tb = GlobalTb
local _yuki_init_list = {}

---这个是登入后触发的事件
function _yuki_init_list.regLoginEvent()
    ---处理服务器回传的登入相关的消息
    CS.Core.DataCenter.Reg(400, function(bytes)
        local res = CS.Pb.Gen.GenLoginResult(bytes)
        if res.Res then
            CS.Global.Alert(res.Msg..",欢迎回来,<color='#fff000'><size=50>"..res.Nickname.."</size></color>")
            --coroutine.resume(tb.closeDialogThread)
            --CS.Manager.Animation.Stop(tb.animaId)
            
            --- 触发登入成功的回调事件
            CS.Lib.Listener.Instance:Event("yuki_login_success")
            --- 停止动画的播放
            CS.Lib.Listener.Instance:Event("yuki_stop_login_animation")
        else
            CS.Global.Alert(res.Msg)
            --CS.Manager.Animation.Stop(tb.animaId)
            --coroutine.resume(tb.closeDialogThread2)
            CS.Lib.Listener.Instance:Event("yuki_stop_login_animation")
            CS.Lib.Listener.Instance:Event("yuki_login_dialog_close")
        end
    end)
end

---无法连接到服务器触发的事件
function _yuki_init_list.cantConnectServer()
    CS.Lib.Listener.Instance:On("cant_connect_server", nil, nil, function ()
        log("无法连接到服务器", LOG_ERROR)
        local dialog = CS.Util.ModelDialog("无法连接到服务器，是否以离线模式启动？", "是", "退出游戏"
        , function ()
                    log("以离线模式启动游戏")
                end
        , function ()
                    log("退出游戏")
                    CS.UnityEngine.Application.Quit(0)
                end)
        dialog:ShowDialog()
    end, true)
end

---加载yuki的消息模块
function _yuki_init_list.init()
    log("-----------开始加载yuki的消息模块-------------")
    _yuki_init_list.regLoginEvent()
    _yuki_init_list.cantConnectServer()
    log("-----------yuki的消息模块加载完成-------------")
end

return _yuki_init_list