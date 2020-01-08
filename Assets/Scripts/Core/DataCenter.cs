using System.Collections.Generic;
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
        public void Receive(int code, byte[] msg)
        {
            Global.Log(code.ToString());
            if (code == 400)
            {
                var res = LoginRes.Parser.ParseFrom(msg);
                Global.Log(res.ToString());
            }
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