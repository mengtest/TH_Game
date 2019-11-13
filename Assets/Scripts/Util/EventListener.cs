using System;
using System.Collections.Generic;

namespace Util
{
    public class EventListener
    {
        private static EventListener _instance = null;
        public static EventListener Instance => _instance;
        private Dictionary<int, Action> _action;
//        private Dictionary<int, Action<>>
        
        private EventListener()
        {
            
        }

        public static void Init()
        {
            _instance = new EventListener();
        }
        
//        public 
    }
}