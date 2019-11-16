using System;
using System.Collections.Generic;
using XLua;

namespace Util
{
    [LuaCallCSharp]
    public class Listener
    {
        [CSharpCallLua]
        public delegate void AsyncCall(params object[] para);
        
        private static Listener _instance = null;
        public static Listener Instance => _instance;
        private Dictionary<int, Queue<LuaFunction>> _actions;

        private Listener()
        {
            _actions = new Dictionary<int, Queue<LuaFunction>>();
        }

        public static void Init()
        {
            if (_instance == null)
            {
                _instance = new Listener();
            }
        }

        //消息编号，
        public void Register(int code, LuaFunction action)
        {
            if (_actions.ContainsKey(code))
            {
                _actions[code].Enqueue(action);
            }
            else
            {
                var l = new Queue<LuaFunction>();
                l.Enqueue(action);
                _actions.Add(code, l);
            }
        }

        public void Call(int code, object o1, object o2, object o3)
        {
            if (_actions.ContainsKey(code))
            {
                var l = _actions[code];
                if (l.Count > 0)
                {
                    var act = l.Dequeue();
                    act.Call(o1, o2, o3);
                }
            }
        }
    }
}