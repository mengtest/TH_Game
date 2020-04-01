using System.Collections.Generic;
using XLua;
using YukiEvent = System.Action<object[]>;

namespace Lib
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public delegate void YukiEventDelegate(object[] objs);

    public class EventDispatcher
    {
        private Dictionary<string, YukiEvent> _events;

        public EventDispatcher()
        {
            _events = new Dictionary<string, YukiEvent>();
        }

        public void Event(string name, params object[] objs)
        {
            if (_events.ContainsKey(name))
            {
                _events[name].Invoke(objs);
            }
        }

        public void Register(string name, YukiEvent e)
        {
            if (_events.ContainsKey(name))
            {
                _events[name] += e;
            }
            else
            {
                _events[name] = e;
            }
        }

        public void Unregister(string name)
        {
            //如果当前的事件队列中存在
            if (_events.ContainsKey(name))
            {
                _events.Remove(name);
            }
        }
        
        public void Unregister(string name, YukiEvent e)
        {
            if (_events.ContainsKey(name))
            {
                // ReSharper disable once DelegateSubtraction
                _events[name] -= e;
            }
        }

        public void ClearAll()
        {
            
        }
    }
}