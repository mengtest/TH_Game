using System;
using System.Collections.Generic;
using System.Threading;
using Google.Protobuf;
using Tutorial;
using Util;
using XLua;

namespace Core
{
    public class DataCenter
    {
        private static DataCenter _instance;

        public static DataCenter Instance => _instance;

        public delegate void Delegate(string str);
        private Dictionary<int, Action<byte[]>> _msgs;
        
        [CSharpCallLua]
        [LuaCallCSharp]
        private Dictionary<int, Delegate> _luaMsgs;

        //处理的是msg，也就是原始数据
        public void Receive(int code, byte[] msg)
        {
            if (code == 400)
            {
                var res = LoginRes.Parser.ParseFrom(msg);
                if (res.Res)
                {
                    Listener.Instance.Event(1, res.ToString(), null, null);
                }
            }

            if (_instance._msgs.ContainsKey(code))
            {
                _instance._msgs[code].Invoke(msg);
            }
            else if(_instance._luaMsgs.ContainsKey(code))
            {
//                _instance._luaMsgs[code].Invoke();
            }
        }
        
        [DoNotGen]
        public static void Reg(int code, Action<byte[]> callback)
        {
            if (!_instance._msgs.ContainsKey(code))
            {
                _instance._msgs.Add(code, callback);
            }
        }

//        public static void RegLua(int code, Delegate callback)
//        {
//            if (!_instance._luaMsgs.ContainsKey(code))
//            {
//                _instance._luaMsgs.Add(code, callback);
//            }
//        }
        
        private DataCenter()
        {
            
        }

        public static void Init()
        {
            _instance = new DataCenter();
            _instance._msgs = new Dictionary<int, Action<byte[]>>();
            _instance._luaMsgs = new Dictionary<int, Delegate>();
        }
    }
}