using System;
using Lib;
using LuaFramework;
using Util;

namespace Net
{
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
            
        }
        
        //登入
        //在登入模块中，可以在用户输入完用户名之后就发送消息，获取到对应的密码，然后再用户点击确认之后再去验证是否登入成功
        public void Login(string username, string userpwd, string callName)
        {
            var act = LuaEngine.Instance.GetTable("LoginDialog").Get<Listener.AsyncCall>(callName);
            Listener.Instance.Register(1, act);
            // 发送消息
            // 这里采用异步的方式来模拟发送消息的过程
            // 实际情况上是服务端发过来消息之后对消息做解析，然后触发回调
            if (username == "yuki1432" && userpwd == "abcd1234123")
            {
                //模拟异步的情景
                Timer.Register(1, () =>
                {
                    Listener.Instance.Call(1, true, 400, "");
                });
            }
            else
            {
                Timer.Register(1, () =>
                {
                    Listener.Instance.Call(1, false, 401, "用户名或者密码错误");
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

        //抽抽抽
        public void Draw()
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