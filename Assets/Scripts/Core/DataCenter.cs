using System.Collections.Generic;
using System.Text;
using System.Threading;
using Google.Protobuf;

namespace Core
{
    public class DataCenter
    {
        private static DataCenter _instance;

        public static DataCenter Instance => _instance;

        private Mutex _mtx;

        private Dictionary<int, IMessage> _msgs;

        //处理的是msg，也就是原始数据
        public void Receive(Msg msg)
        {
            //读取出这个消息的类型
            var type = msg.Type;
            //根据消息的值，映射出实际的对象，再去做处理
            var data = Data.Parser.ParseJson(msg.Msg_);
        }

        private void Reg()
        {
            
        }
        
        private DataCenter()
        {
            
        }

        public static void Init()
        {
            _instance = new DataCenter();
            _instance._mtx = new Mutex();
            _instance._msgs = new Dictionary<int, IMessage>();
            _instance.Reg();
        }
    }
}