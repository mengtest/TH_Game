using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.InputSystem;
using XLua;

namespace Lib
{
    
    /// <summary>
    /// 
    /// </summary>
    public class ListenerObject : MonoBehaviour
    {
        //所有的自定义事件
        private Dictionary<string, YukiEventDelegate> _events = new Dictionary<string, YukiEventDelegate>();
        //所有的按键事件
        private Dictionary<int, YukiEventDelegate> _keyEvents = new Dictionary<int, YukiEventDelegate>();
        //所有的点击事件
        private Dictionary<int, YukiEventDelegate> _mouseEvents = new Dictionary<int, YukiEventDelegate>();

        [Tooltip("鼠标输入事件")]
        public InputAction mAction;
        [Tooltip("键盘输入事件")]
        public InputAction kAction;

        private void Awake()
        {
//            mAction = new InputAction();
//            mAction.
            
//            mAction.performed += MouseEvents;
//            kAction.performed += KeyBoardEvents;
        }

        private void OnEnable()
        {
//            mAction.Enable();
//            kAction.Enable();
        }
        
        private void OnDisable()
        {
//            mAction.Disable();
//            kAction.Disable();
        }

        private void MouseEvents(InputAction.CallbackContext context)
        {
            
        }
        
        private void KeyBoardEvents(InputAction.CallbackContext context)
        {
            
        }

        /// <summary>
        /// 该组件是否包含有某个事件
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public bool Contains(string eventName)
        {
            return _events.ContainsKey(eventName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="objs"></param>
        public void Event(string eventName, params object[] objs)
        {
            if (_events.ContainsKey(eventName))
            {
                _events[eventName]?.Invoke(objs);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="e"></param>
        public void On(string eventName, YukiEventDelegate e, bool once = false)
        {
            if (_events.ContainsKey(eventName))
            {
                _events[eventName] += e;
            }
            else
            {
                _events.Add(eventName, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventName"></param>
        public void Off(string eventName)
        {
            //如果当前的事件队列中存在
            if (_events.ContainsKey(eventName))
            {
                _events.Remove(eventName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="e"></param>
        public void Off(string eventName, YukiEventDelegate e)
        {
            if (_events.ContainsKey(eventName))
            {
                _events[eventName] -= e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearAll()
        {
            _events.Clear();
        }

        public void AddKeyEvent(int keyCode, YukiEventDelegate func, bool once)
        {
            if (!_keyEvents.ContainsKey(keyCode))
            {
                _keyEvents.Add(keyCode, func);
            }
            else
            {
                _keyEvents[keyCode] += func;
            }
        }

        public void AddMouseEvent(int keyCode, YukiEventDelegate func, bool once)
        {
            if (!_mouseEvents.ContainsKey(keyCode))
            {
                _mouseEvents.Add(keyCode, func);
            }
            else
            {
                _mouseEvents[keyCode] += func;
            }
        }

        //update主要处理所有的输入事件
//        private void Update()
//        {
//            //这里处理所有的键鼠相关的事件
//            // if (Input.anyKeyDown)
//            // {
//            //     for (var index = 0; index < _keyEvents.Count;)
//            //     {
//            //         var value = _keyEvents.ElementAt(index);
//            //         if ( value.Key == KeyCode.AnyKey || Input.GetKeyDown((UnityEngine.KeyCode) value.Key) )
//            //         {
//            //             value.Value?.Invoke();
//            //         }
//            //         index++;
//            //     }
//            //     
//            //     for (var index = 0; index < _mouseEvents.Count;)
//            //     {
//            //         var value = _mouseEvents.ElementAt(index);
//            //         if ( value.Key == KeyCode.AnyKey || Input.GetKeyDown((UnityEngine.KeyCode) value.Key) )
//            //         {
//            //             value.Value?.Invoke(Input.mousePosition, Input.touchCount);
//            //         }
//            //         index++;
//            //     }
//            // }
//        }

        private void OnDestroy()
        {
            Listener.Instance.RemoveObj(this);
        }
    }
}