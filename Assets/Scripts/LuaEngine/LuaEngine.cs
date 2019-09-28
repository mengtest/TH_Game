using System;
using System.Threading;
using XLua;

namespace LuaEngine
{
    public class LuaEngine : IDisposable
    {
        private static LuaEnv _lauEngine;
        private static Mutex _mutex = new Mutex();
        
        public static LuaEnv Instance()
        {
            //双重锁定
            if (_lauEngine == null)
            {
                _mutex.WaitOne();
                if (_lauEngine == null)
                {
                    _lauEngine = new LuaEnv();
                }
                _mutex.ReleaseMutex();
            }
            return _lauEngine;
        }

        public void Dispose()
        {
            _lauEngine.Dispose();
        }
    }
}