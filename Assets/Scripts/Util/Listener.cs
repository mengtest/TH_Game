using System;
using System.Collections.Generic;
using Lib;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Util
{
    [LuaCallCSharp]
    public class Listener
    {
        public const string CLICK = "click";
        public const string KEYBOARD = "keyboard";

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

        //注册事件
        public void On(string type, AsyncCall call, int signal = 0)
        {
            
        }

        [LuaCallCSharp]
        public delegate bool Predicate();
        [LuaCallCSharp]
        public delegate void Callback();
        
        public void On(LuaFunction predicate, Callback callback, string signal)
        {
            Debug.Log("222222222222222222");
            if (predicate == null || callback == null)
            {
                return;
            }
            if (_eventListener == null)
            {
                _eventListener = new GameObject("EventListener");
                _eventListener.AddComponent<EventListener>();
                SceneManager.MoveGameObjectToScene(_eventListener, SceneManager.GetActiveScene());
            }
            _eventListener.GetComponent<EventListener>().Reg(signal, predicate, callback);
        }
        
        //调用事件
        public void Event(string type, int signal = 0 ,object o1 = null, object o2 = null, object o3 = null)
        {
            
        }

        public void Off(string type, int signal = 0)
        {
            
        }
    }
}