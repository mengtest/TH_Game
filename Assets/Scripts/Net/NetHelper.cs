using UnityEngine;
using Util;

namespace Net
{
    public struct ErrorCode
    {
//        public enum ErrorType 
           //        {
           //            Timeout,                    //连接超时
           //            IncorrectUsername,            //错误的用户名
           //            IncorrectUserpwd,            //错误的密码
           //            NamePwdNotPair,                //账号密码
           //        }
        
        public long CodeId;
        public string CodeMsg;
    }

    //处理发送给服务器的数据，与解析服务器回传的数据的类
    public partial class NetHelper
    {
        private partial class Client
        {
        }

        private Client _connection;
        
        private static NetHelper _instance = null;

        public static NetHelper Instance => _instance;

        public static bool Init()
        {
            _instance = new NetHelper();
            return true;
        }
        
        private NetHelper()
        {
            //初始化的时候会去读取配置文件，从配置文件中读取到ip、端口等信息
            _connection = new Client("127.0.0.1", 9998);
        }

        //接收服务器回传的消息并解析
        public void ReceiveMsg(Msg msg)
        {
            var res = LoginMsg.Parser.ParseJson(msg.Msg_);
            Debug.Log(res.Code);
            Debug.Log(res.Msg);
//            LoginMsg.Parser.ParseFrom()
//            Debug.Log(data.Code);
//            Debug.Log(data.Msg);
        }

        //登入
        public void Login(string username,string userpwd)
        {
            LoginData data = new LoginData {Username = username, Userpwd = userpwd};
            var msg = new Util.Msg(101, data);
            _connection.Send(msg);
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