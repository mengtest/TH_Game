using System;
using System.Collections.Generic;
using Lib;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;
using KeyCode = Lib.KeyCode;

namespace Util
{
    [LuaCallCSharp]
    public class Listener
    {
        public enum EventType
        {
            CLICK,
            KEYBOARD,
            CONTROLLER,
            CUSTOM,
        }

        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate bool Predicate();
        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate void Callback();
        
        //所有回调函数均为三参数
        [CSharpCallLua]
        public delegate void AsyncCall(object o1, object o2, object o3);
        
        private static Listener _instance = null;
        public static Listener Instance => _instance;
        private Dictionary<int, Queue<AsyncCall>> _actions;
        private GameObject _eventListener;

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

        //注册消息，就是单一回调，触发之后就会删除
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

        //触发一个单一回调的事件，触发完后直接删除
        public void Call(int code, object o1, object o2, object o3)
        {
            if (_actions.ContainsKey(code))
            {
                var l = _actions[code];
                if (l.Count > 0)
                {
                    var act = l.Dequeue();
                    act.Invoke(o1, o2, o3);
                }
            }
        }

        private void ListenerInit()
        {
            if (_eventListener == null)
            {
                _eventListener = new GameObject("EventListener");
                _eventListener.AddComponent<EventListener>();
                SceneManager.MoveGameObjectToScene(_eventListener, SceneManager.GetActiveScene());
            }
        }

        //将一个函数注入到事件监听器中
        public void Inject(string signal, Callback callback)
        {
            _eventListener.GetComponent<EventListener>().Reg(signal, callback, false);
        }
        
        //按键，鼠标等相关的事件监听器,signal为其唯一标识符
//        public void On(string signal, int click, Callback callback, bool once = true)
//        {
//            Debug.Log("123123");
//        }

        public void On(string signal, KeyCode code, Callback callback, bool once = true)
        {
            ListenerInit();
            var keycode = (UnityEngine.KeyCode) code;
            _eventListener.GetComponent<EventListener>().Reg(signal, () =>
            {
                if (Input.GetKey(keycode) || Input.GetKeyDown(keycode))
                {
                    callback.Invoke();
                }
            }, false);
        }

        //signal标识这个事件是否有唯一标识符，0表示没有
        public void On(string type, AsyncCall call, int signal = 0, bool once = true)
        {
            
        }

        //谓词监听器，满足自定义条件则自动触发
        public void On(Predicate predicate, Callback callback, string signal, bool once = true)
        {
            if (predicate == null || callback == null)
            {
                return;
            }
            ListenerInit();
            _eventListener.GetComponent<EventListener>().Reg(signal, predicate, callback, once);
        }

        //调用事件
        public void Event(string type, int signal = 0 ,object o1 = null, object o2 = null, object o3 = null)
        {
            
        }

        //
        public void Off(string type, int signal = 0)
        {
            
        }
    }
}