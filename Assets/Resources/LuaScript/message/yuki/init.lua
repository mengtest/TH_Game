local _yuki_init_list = {}

---这个是登入后触发的事件
function _yuki_init_list.regLoginEvent()
    ---处理服务器回传的登入相关的消息
    CS.Core.DataCenter.Reg(400, function(bytes)
        local res = CS.Pb.Gen.GenLoginRes(bytes)
        if res.Res then
            player.Init(res)
            CS.Global.Alert(res.Msg.."，欢迎回来<color='#fff000'><size=50>".."\n"..res.Nickname.."</size></color>")
            --player.Name = res.Nickname
            --- 触发登入成功的回调事件
            CS.Lib.Listener.Instance:Event("yuki_login_success")
            --- 停止动画的播放
            CS.Lib.Listener.Instance:Event("yuki_stop_login_animation")
        else
            CS.Global.Alert(res.Msg)
            CS.Lib.Listener.Instance:Event("yuki_stop_login_animation")
            CS.Lib.Listener.Instance:Event("yuki_login_dialog_close")
        end
    end)
end

---无法连接到服务器触发的事件
function _yuki_init_list.cantConnectServer()
    CS.Lib.Listener.Instance:On("cant_connect_server"
    , function ()
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
    end, 0, null, true)
end

---测试接收json字符串的事件
function _yuki_init_list.test()
    CS.Core.DataCenter.Reg2(20001, function (str)
        --这里是当前玩家所有的卡牌信息
        log("-----------------")
        log(str)
        log(json.encode(json.decode(str)))
        globalTb.myCards = json.decode(str)
        --log(#globalTb.myCards)
    end)

    CS.Core.DataCenter.Reg2(20002, function (str)
        --这里是当前玩家所有好友的信息
    end)
end

function _yuki_init_list.eventInit()
    CS.Lib.Listener.Instance:On("connected_with_server", function ()
        --这条消息是用于获取某些必须的数据的
        --例如所有的卡牌信息(json文件的信息)
        --CS.Net.NetHelper.GetInstance():Send(20003, "")
    end)
end

function _yuki_init_list.sceneInit()
    local f = function(param)
        --log("新的场景参数为:"..param)
        --log("当前场景的名称是："..CS.Global.Scene.name)
        
    end
    CS.Lib.Listener.Instance:On("scene_changed", f)
end

---加载yuki的消息模块
function _yuki_init_list.init()
    log("-----------开始加载yuki的消息模块-------------")
    _yuki_init_list.regLoginEvent()
    _yuki_init_list.cantConnectServer()
    _yuki_init_list.test()
    _yuki_init_list.eventInit()
    _yuki_init_list.sceneInit()
    log("-----------yuki的消息模块加载完成-------------")
end

return _yuki_init_list