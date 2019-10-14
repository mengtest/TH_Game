using System;
using System.Collections.Generic;
using System.Threading;
using XLua;

namespace LuaEngine
{
    public class LuaEngine
    {
        private static LuaEngine _engine;
        private static Mutex _mutex = new Mutex();
        private IDictionary<string, LuaEnv> _envs;
        private LuaEnv _mainEnv;

        //获取lua环境的实例对象
        public static LuaEngine Instance()
        {
            //双重锁定
            if (_engine == null)
            {
                _mutex.WaitOne();
                if (_engine == null)
                {
                    _engine = new LuaEngine();
                }
                _mutex.ReleaseMutex();
            }
            return _engine;
        }

        private LuaEngine()
        {
            _envs = new Dictionary<string, LuaEnv>();
            MainInstance();
        }

        public void Destroy()
        {
            try
            {
                _mainEnv.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("还有没有释放的Action");
            }
        }
        
        public void Destroy(string name)
        {
            LuaEnv env = null;
            if (_envs.ContainsKey(name))
            {
                env = _envs[name];
                _envs.Remove(name);

                try
                {
                    env.Dispose();
                }
                catch (Exception e)
                {
                    throw new Exception($"{name}还有没有释放的Action");
                }
                finally
                {
                    _envs.Add(name, env);
                }
            }
        }

        public void DestroySub()
        {
            foreach (var env in _envs)
            {
                //这样会导致迭代器失效吗？
                Destroy(env.Key);
            }
        }
        
        public void DestroyAll()
        {
            Destroy();
            DestroySub();
        }

        public LuaEnv MainInstance()
        {
            return _mainEnv ?? (_mainEnv = new LuaEnv());
        }
        
        public LuaEnv SubInstance(string name)
        {
            if (_mainEnv == null)
            {
                throw new Exception("没有主实例，无法创建子实例");
            }

            if (!_envs.ContainsKey(name))
            {
                var env = new LuaEnv();
                _envs.Add(name, env);
            }

            return _envs[name];
        }
    }
}