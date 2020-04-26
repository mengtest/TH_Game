using System.Collections.Generic;
using System.Threading;
using XLua;

namespace Lib
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public delegate void YukiEventDelegate(params object[] objs);

    // public delegate void YukiEvent
    
    /// <summary>
    /// 
    /// </summary>
    public class EventDispatcher
    {
        private Dictionary<string, YukiEventDelegate> _events;
        private Mutex _mutex = new Mutex();

        /// <summary>
        /// 
        /// </summary>
        public EventDispatcher()
        {
            _events = new Dictionary<string, YukiEventDelegate>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="objs"></param>
        public void Event(string name, params object[] objs)
        {
            if (_events.ContainsKey(name))
            {
                // _mutex.WaitOne();
                _events[name]?.Invoke(objs);
                // _mutex.ReleaseMutex();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="e"></param>
        public void Register(string name, YukiEventDelegate e)
        {
            if (_events.ContainsKey(name))
            {
                // _mutex.WaitOne();
                _events[name] += e;
                // _mutex.ReleaseMutex();
            }
            else
            {
                // _mutex.WaitOne();
                _events.Add(name, e);
                // _mutex.ReleaseMutex();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Unregister(string name)
        {
            //如果当前的事件队列中存在
            if (_events.ContainsKey(name))
            {
                // _mutex.WaitOne();
                _events.Remove(name);
                // _mutex.ReleaseMutex();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="e"></param>
        public void Unregister(string name, YukiEventDelegate e)
        {
            if (_events.ContainsKey(name))
            {
                var et = _events[name];
                et = et - e;
            }
        }

        public void ClearAll()
        {
            _events.Clear();
        }
    }
}