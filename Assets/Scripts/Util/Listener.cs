using System;
using System.Collections.Generic;
using XLua;

namespace Util
{
    [LuaCallCSharp]
    public class Listener
    {
        [LuaCallCSharp]
        public delegate void AsyncCall(bool b, int c);

//        public Action<bool, int>;
        
        private static Listener _instance = null;
        public static Listener Instance => _instance;
        private Dictionary<int, Queue<AsyncCall>> _actions;

        private Listener()
        {
            _actions = new Dictionary<int, Queue<AsyncCall>>();
        }

        public static void Init()
        {
            if (_instance == null)
            {
                _instance = new Listener();
            }
        }

        //消息编号，
        public void Register(int code, AsyncCall action)
        {
            if (_actions.ContainsKey(code))
            {
                _actions[code].Enqueue(action);
            }
            else
            {
                var l = new Queue<AsyncCall>();
                l.Enqueue(action);
                _actions.Add(code, l);
            }
        }

        public void Call(int code, bool b, int c)
        {
            if (_actions.ContainsKey(code))
            {
                var l = _actions[code];
                if (l.Count > 0)
                {
                    var act = l.Dequeue();
                    act.Invoke(b, c);
                }
            }
        }
    }
}