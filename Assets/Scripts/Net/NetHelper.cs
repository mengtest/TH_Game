using System;
using LuaFramework;
using Util;
using XLua;

namespace Net
{
    public struct ErrorCode
    {
        public long CodeId;
        public string CodeMsg;
    }

    //处理发送给服务器的数据，与解析服务器回传的数据的类
    public partial class NetHelper
    {
        private partial class Client : IDisposable
        {
            public void Dispose()
            {
                Destroy();
            }
        }

        private static Client _connection;
        
        private static NetHelper _instance = null;
        
        

        public static NetHelper GetInstance()
        {
            return _instance;
        }

        public static bool Init()
        {
            _instance = new NetHelper();
            return true;
        }
        
        private NetHelper()
        {
            //初始化的时候会去读取配置文件，从配置文件中读取到ip、端口等信息
            //_connection = new Client("127.0.0.1", 9998);
        }

        //接收服务器回传的消息并解析
        public void ReceiveMsg(Msg msg)
        {
//            var res = LoginMsg.Parser.ParseJson(msg.Msg_);
//            Debug.Log(res.Code);
//            Debug.Log(res.Msg);
//            LoginMsg.Parser.ParseFrom()
//            Debug.Log(data.Code);
//            Debug.Log(data.Msg);
        }

//        public delegate void Callback(params object[] para);
        
        //登入
        public void Login(string username, string userpwd, string callName)
        {
            // 发送消息
            // SendMsg(username, userpwd)
            if (username == "yuki1432" && userpwd == "abcd1234123")
            {
                var act = LuaEngine.Instance.GetTable("LoginDialog").Get<LuaFunction>(callName);
//                act.Call(true, 1000);
                Listener.Instance.Register(1, act);
                //模拟异步的情景
                Timer.Register(5, () =>
                {
                    Listener.Instance.Call(1, true, 400, "你好啊");
                });
            }
        }

        //登出
        public void Logout()
        {
            
        }

        //抽卡
        public void DrawCard()
        {
            
        }

        //连接到服务器
        public void Connect()
        {
            
        }

        //断开连接
        public void Disconnect()
        {
            
        }

        //更新资源
        public void Update()
        {
            
        }

        //检查版本号,返回版本号是否一致
        public bool CheckVersion(string version)
        {
            return false;
        }
    }
}