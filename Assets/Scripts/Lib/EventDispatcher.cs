using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using XLua;

namespace Lib
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public delegate void YukiEventDelegate(params object[] objs);

    public delegate void BroadcastDelegate(params object[] objs);

    // public delegate void YukiEvent

    public class Broadcast
    {
        // private event BroadcastDelegate braodcast;
        private Dictionary<long, BroadcastDelegate> _delegates;
        private object obj;

        public void Invoke(params object[] param)
        {
            // braodcast(param);
            lock (obj)
            {
                foreach (var item in _delegates)
                {
                    item.Value.Invoke(param);
                }
            }
        }

        public Broadcast(BroadcastDelegate cast)
        {
            _delegates = new Dictionary<long, BroadcastDelegate>();
        }

        public static Broadcast operator+(Broadcast l, Broadcast r)
        {

            return l;
        }

        public static Broadcast operator-(Broadcast l, Broadcast r)
        {
            
            return l;
        }
    }

}