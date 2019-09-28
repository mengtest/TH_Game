using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Util
{
    public class EventListenerManager
    {
        public bool AddEvent([NotNull] object instance, Action callback)
        {
            return false;
        }
        
        private static EventListenerManager _instance;

        public static EventListenerManager Instance => _instance;

        public static bool Init()
        {
            _instance = new EventListenerManager();
            return true;
        }
        
        private EventListenerManager()
        {
            _actions = new Dictionary<KeyValuePair<int, string>, Action>();
        }

        //键的第一个值是对象的哈希值
        private Dictionary<KeyValuePair<int, string>, Action> _actions;
    }
}