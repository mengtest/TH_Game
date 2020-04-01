using System.Collections.Generic;
using System.Text;
using XLua;

namespace Core
{
    [LuaCallCSharp]
    public class DataCenter
    {
        private static DataCenter _instance;

        public static DataCenter Instance => _instance;

        [CSharpCallLua]
        [LuaCallCSharp]
        public delegate void Delegate(byte[] bytes);
        
        [CSharpCallLua]
        [LuaCallCSharp]
        public delegate void Delegate2(string str);
        
        private Dictionary<int, Delegate> _msgs;
        private Dictionary<int, Delegate2> _msgs2;
        

        // private Dictionary<int, Delegate> _luaMsgs;

        //处理的是msg，也就是原始数据
        public void Receive(int code, byte[] msg)
        {
//            if (code == 400)
//            {
//                var res = LoginRes.Parser.ParseFrom(msg);
//                if (res.Res)
//                {
//                    Listener.Instance.Event(1, res.ToString(), null, null);
//                }
//            }

            //大于20000的消息号被认定为传输的是json字符串

            if (_instance._msgs2.ContainsKey(code))
            {
                if (code > 20000)
                {
                    _instance._msgs2[code].Invoke(Encoding.UTF8.GetString(msg));
                }
                return;
            }
            

            if (_instance._msgs.ContainsKey(code))
            {
                _instance._msgs[code].Invoke(msg);
            }
        }
        
        // [DoNotGen]
        public static void Reg(int code, Delegate callback)
        {
            if (!_instance._msgs.ContainsKey(code))
            {
                _instance._msgs.Add(code, callback);
            }
        }
        
        public static void Reg2(int code, Delegate2 callback)
        {
            if (!_instance._msgs2.ContainsKey(code))
            {
                _instance._msgs2.Add(code, callback);
            }
        }
        
        private DataCenter()
        {
            
        }

        public static void Init()
        {
            _instance = new DataCenter();
            _instance._msgs = new Dictionary<int, Delegate>();
            _instance._msgs2 = new Dictionary<int, Delegate2>();
            // _instance._luaMsgs = new Dictionary<int, Delegate>();
        }
    }
}