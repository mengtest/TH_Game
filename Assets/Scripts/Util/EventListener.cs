using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine.Events;

namespace Util
{
    public class EventListener
    {
        private static EventListener _instance = null;
        public static EventListener Instance => _instance;
        private Dictionary<int, UnityAction> _action;

        private EventListener()
        {
            
        }

        public static void Init()
        {
            _instance = new EventListener();
        }

        public void Register(int code, UnityAction action)
        {
            
        }
    }
}