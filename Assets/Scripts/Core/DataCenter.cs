using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Google.Protobuf;

namespace Core
{
    /// <summary>
    /// 数据中心，与Net模块直接相连，
    /// 接收net模块传递过来的数据，并处理成protobuf，做出对应的处理
    /// 将对象处理成包并发送给服务器
    /// 会加入多线程的处理
    /// </summary>
    public class DataCenter
    {
        public delegate void MessageCall(int type, string msg);
        
        private static DataCenter _instance;

        public static DataCenter Instance => _instance;

        private Mutex _mtx;
        private Dictionary<int, MessageCall> _msgs;
//        private List<Action<int, IMessage>> _regedMsg;
            
        /// <summary>
        /// 接收net模块传递过来的bytes，并解析这个bytes
        /// </summary>
        /// <param name="msg">接收到的byte数组</param>
        public void Receive(byte[] msg)
        {
            //读取出这个消息的类型
            var data = Entity.Net.Msg.FromJson(Encoding.UTF8.GetString(msg));
            //根据消息的值，映射出实际的对象，再去做处理
            var type = (int)data.Type;
            var message = data.MsgMsg;
            //根据type将message转换成目标protobuf
            if (_msgs.ContainsKey(type))
            {
                _msgs[type].Invoke(type, message);
            }
            else
            {
                Global.Log($"未知的数据包类型{type}");
            }
        }

        public void Reg(int type,MessageCall call)
        {
            _msgs.Add(type, call);
        }
        
        private DataCenter()
        {
            
        }

        public static void Init()
        {
            _instance = new DataCenter();
            _instance._mtx = new Mutex();
            _instance._msgs = new Dictionary<int, MessageCall>();
        }
    }
}