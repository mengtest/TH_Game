using System;
using XLua;

namespace Util.temp
{
    public class Listener
    {
        public enum KeyCode
        {
            
        }
        
        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate void Function(object[] objs); 
        
        public void On(string eventName, Object caller,Function func, object[] param)
        {
            
        }

        public void On(KeyCode code, Object caller, Function func)
        {
            
        }

        public void Off(string eventName, Object caller, Function func)
        {
            
        }

        public void OffAll(string eventName, Object caller)
        {
            
        }

        public void OffAll(string eventName)
        {
            
        }

        public void Event(string eventName, Object caller, object[] param)
        {
            
        }
    }
}