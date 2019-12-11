using System.Collections.Generic;
using System.Linq;
using Lib;
using UnityEngine;
using XLua;
using KeyCode = Lib.KeyCode;
using Object = UnityEngine.Object;

namespace Util
{
    [LuaCallCSharp]
    public class Listener
    {
        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate bool Predicate();
        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate void Callback();
        
        //所有回调函数均为三参数
        [CSharpCallLua]
        public delegate void AsyncCall(object o1, object o2, object o3);
        
        private static Listener _instance;
        public static Listener Instance => _instance;
        private Dictionary<string, List<Global.Pair<Object, AsyncCall>>> _events;
        private GameObject _eventListener;

        private Listener()
        {
            _events = new Dictionary<string, List<Global.Pair<Object, AsyncCall>>>();
        }

        public static void Init()
        {
            if (_instance != null) return;
            _instance = new Listener();
            if (_instance._eventListener != null) return;
            _instance._eventListener = new GameObject("EventListener");
            _instance._eventListener.AddComponent<EventListener>();    
            Object.DontDestroyOnLoad(_instance._eventListener);
        }

        //注册消息，就是单一回调，触发之后就会删除
        public void Register(int code, AsyncCall action)
        {
            if (_events.ContainsKey("async_events"))
            {
                _events["async_events"].Add(new Global.Pair<Object, AsyncCall>(code, action));
            }
            else
            {
                _events["async_events"] = new List<Global.Pair<Object, AsyncCall>>();
                _events["async_events"].Add(new Global.Pair<Object, AsyncCall>(code, action));
            }
        }

        //触发一个单一回调的事件，触发完后直接删除
        public void Call(int code, object o1, object o2, object o3)
        {
            if (_events.ContainsKey("async_events"))
            {
                var actions = _events["async_events"];
                foreach (Global.Pair<Object,AsyncCall> action in actions)
                {
                    if (action.First == code)
                    {
                        action.Second.Invoke(o1, o2, o3);
                        return;
                    }
                }
            }
        }

        //将一个函数注入到事件监听器中
        public void Inject(string signal, Callback callback)
        {
            _eventListener.GetComponent<EventListener>().Reg(signal, callback, false);
        }
        
        //键盘，鼠标等相关的事件注册
        public void On(string signal, KeyCode code, Callback callback, bool once = false)
        {
            //设定上，按下任意键继续不包含escape键
            if (code == KeyCode.AnyKey)
            {
                _eventListener.GetComponent<EventListener>().Reg(signal, 
                    () => Input.anyKey && !Input.GetKeyDown(UnityEngine.KeyCode.Escape), 
                    callback, 
                    once);
                return;
            }
            
            var keycode = (UnityEngine.KeyCode) code;
            _eventListener.GetComponent<EventListener>().Reg(signal,
                () => Input.GetKeyDown(keycode),
                callback, 
                once);
        }

        //signal标识这个事件是否有唯一标识符，0表示没有
        public void On(string type, Object signal, AsyncCall call)
        {
            if (!_events.ContainsKey(type))
            {
                _events[type] = new List<Global.Pair<Object, AsyncCall>>();
            }
            _events[type].Add(new Global.Pair<Object, AsyncCall>(signal, call));
        }

        //谓词监听器，满足自定义条件则自动触发
        public void On(Predicate predicate, Callback callback, string signal, bool once = true)
        {
            if (predicate == null || callback == null)
            {
                return;
            }
            _eventListener.GetComponent<EventListener>().Reg(signal, predicate, callback, once);
        }

        //调用事件
        public void Event(string type, Object signal = null ,object o1 = null, object o2 = null, object o3 = null)
        {
            if (_events.ContainsKey(type))
            {
                if (signal != null)
                {
                    for (int i = 0; i < _events[type].Count; i++)
                    {
                        var e = _events[type].ElementAt(i);
                        if (e.First == signal)
                        {
                            e.Second.Invoke(o1, o2, o3);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < _events[type].Count; i++)
                    {
                        var e = _events[type].ElementAt(i);
                        e.Second.Invoke(o1, o2, o3);
                    }
                }
            }
        }
        
        public void Off(string type, Object signal = null)
        {
            if (_events.ContainsKey(type))
            {
                if (signal != null)
                {
                    for (int i = 0; i < _events[type].Count; i++)
                    {
                        var e = _events[type].ElementAt(i);
                        if (e.First == signal)
                        {
                            _events[type].RemoveAt(i);
                        }
                    }
                }
                else
                {
                    _events.Remove(type);
                }
            }
            else
            {
                _eventListener.GetComponent<EventListener>().Remove(type);
            }
        }
    }
}