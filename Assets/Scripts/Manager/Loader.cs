using System;
using System.Collections.Generic;

namespace Manager
{
    public static class Loader
    {
        private static Queue<Action> _funcs = new Queue<Action>();
        public static void Push(Action func)
        {
            _funcs.Enqueue(func);
        }

        public static void Pop()
        {
                
        }
    }
}