using System;
using System.Collections.Generic;
using UnityEngine;
using Util;
using XLua;

namespace Lib
{
    public class EventListener : MonoBehaviour
    {
        private Dictionary<string, Global.Pair<LuaFunction, Listener.Callback>> _events = 
            new Dictionary<string, Global.Pair<LuaFunction, Listener.Callback>>(); 
        
        public void Reg(string type, LuaFunction predicate, Listener.Callback callback)
        {
            if (_events.ContainsKey(type))
            {
                _events[type] = new Global.Pair<LuaFunction, Listener.Callback>(predicate, callback);
            }
            else
            {
                _events.Add(type, new Global.Pair<LuaFunction, Listener.Callback>(predicate, callback));
            }
        }

        public void Remove(string type)
        {
            if (_events.ContainsKey(type))
            {
                _events.Remove(type);
            }
        }
        
        
        private void Update()
        {
            foreach (KeyValuePair<string, Global.Pair<LuaFunction, Listener.Callback>> e in _events)
            {
                if ((bool)e.Value.First.Call()[0])
                {
                    e.Value.Second();
                }
            }
        }
    }
}