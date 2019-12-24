using System.Collections.Generic;
using System.Linq;
using Lib;
using UnityEngine;
using XLua;
using KeyCode = Lib.KeyCode;

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
        //事件按照key:事件名，value:Pair <绑定的对象,回调>
        //事件名为字符串
        //每次遍历的时候回去检测这个对象是否为空，如果为空，则将这个回调删除
        private Dictionary<string, List<Global.Pair<Object, AsyncCall>>> _events;
        public GameObject _eventListener;
        //一个虚拟的对象，用于存储一些没有指定对象的事件监听器使用
        //其本质就是EventListener本身
        private MonoBehaviour _virtualGo;

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
            var listener = _instance._eventListener.AddComponent<EventListener>();
            _instance._virtualGo = listener;
            Object.DontDestroyOnLoad(_instance._eventListener);
        }

        /// <summary>
        /// 注册一个普通的回调函数，只有当手动调用event时才会触发这个函数
        /// </summary>
        /// <param name="type">事件的类型</param>
        /// <param name="caller">绑定这个事件的对象</param>
        /// <param name="call">回调函数，有三个object参数</param>
        public void On(string type, Object caller, AsyncCall call)
        {
            if (caller == null)
            {
                caller = _virtualGo;
            }
            
            if (!_events.ContainsKey(type))
            {
                _events[type] = new List<Global.Pair<Object, AsyncCall>>();
            }
            _events[type].Add(new Global.Pair<Object, AsyncCall>(caller, call));
        }
        
        /// <summary>
        /// 键盘，鼠标等相关的事件注册
        /// </summary>
        /// <param name="code">要绑定的事件的枚举值</param>
        /// <param name="caller">绑定这个事件的对象</param>
        /// <param name="callback">回调</param>
        /// <param name="once">是否只会触发一次，默认为false</param>
        public void On(KeyCode code, Object caller, Callback callback, bool once = false)
        {
            if (caller == null)
            {
                caller = _virtualGo;
            }
            
            //设定上，按下任意键继续不包含escape键
            if (code == KeyCode.AnyKey)
            {
                _eventListener.GetComponent<EventListener>().Reg(code.ToString(), caller,
                    () => Input.anyKey && !Input.GetKeyDown(UnityEngine.KeyCode.Escape), 
                    callback, 
                    once);
                return;
            }
            
            var keycode = (UnityEngine.KeyCode) code;
            _eventListener.GetComponent<EventListener>().Reg(code.ToString(), caller,
                () => Input.GetKeyDown(keycode),
                callback, 
                once);
        }
        
        /// <summary>
        /// 谓词监听器，满足自定义条件则自动触发
        /// </summary>
        /// <param name="type">注册的自定义消息</param>
        /// <param name="caller">消息所绑定的对象</param>
        /// <param name="predicate">谓词</param>
        /// <param name="callback">回调</param>
        /// <param name="once">是否只会被调用一次，默认为true</param>
        public void On(string type, Object caller, Predicate predicate, Callback callback, bool once = true)
        {
            if (caller == null)
            {
                caller = _virtualGo;
            }
            if (predicate == null || callback == null)
            {
                return;
            }
            _eventListener.GetComponent<EventListener>().Reg(type, caller, predicate, callback, once);
        }
        
        public void Event(string type, object o1, object o2, object o3)
        {
            if (_events.ContainsKey(type))
            {
                var actions = _events[type];
                foreach (Global.Pair<Object,AsyncCall> action in actions)
                {
                    if (action.First == _virtualGo)
                    {
                        action.Second.Invoke(o1, o2, o3);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 触发一个事件
        /// </summary>
        /// <param name="type">要触发的事件类型</param>
        /// <param name="caller">注册时绑定的对象，默认为null</param>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <param name="o3"></param>
        public void Event(string type, Object caller = null , object o1 = null, object o2 = null, object o3 = null)
        {
            if (_events.ContainsKey(type))
            {
                if (caller != null)
                {
                    for (int i = 0; i < _events[type].Count; i++)
                    {
                        var e = _events[type].ElementAt(i);
                        if (e.First == caller)
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
            
            if (caller == null)
            {
                caller = _virtualGo;
            }
            
            if (_events.ContainsKey(type))
            {
                var actions = _events[type];
                foreach (Global.Pair<Object,AsyncCall> action in actions)
                {
                    if (action.First == caller)
                    {
                        action.Second.Invoke(o1, o2, o3);
                        return;
                    }
                }
            }
        }
        
        /// <summary>
        /// 取消一个已经注册的事件，如果没有对应的事件，不会报错
        /// </summary>
        /// <param name="type">事件的类型</param>
        /// <param name="caller">为事件绑定的对象</param>
        public void Off(string type, Object caller = null)
        {
            if (_events.ContainsKey(type))
            {
                if (caller != null)
                {
                    for (int i = 0; i < _events[type].Count; i++)
                    {
                        var e = _events[type].ElementAt(i);
                        if (e.First == caller)
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
                _eventListener.GetComponent<EventListener>().Remove(type, caller);
            }
        }
    }
}