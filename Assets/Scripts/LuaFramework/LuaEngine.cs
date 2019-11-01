using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using XLua;

namespace LuaFramework
{
    public class LuaEngine : IDisposable
    {
        private static LuaEngine _engine;
        private static Mutex _instanceMtx = new Mutex();
        private LuaEnv _env;

        public static LuaEngine Instance
        {
            get
            {
                if (_engine == null)
                {
                    _instanceMtx.WaitOne();
                    if (_engine == null)
                    {
                        _engine = new LuaEngine();
                    }
                    _instanceMtx.ReleaseMutex();
                }
                return _engine;
            }
        }
        
        private LuaEngine()
        {
            _env = new LuaEnv();
        }

        public LuaEnv Get()
        {
            return _env;
        }

        //加载整个文件，后面会根据id将lua函数映射到C#函数
        //path为lua文件路径,id为文件名
        public void LoadFile(string path)
        {
            _env.DoString(Resources.Load<TextAsset>(path).text);
        }
        
        //加载整个文件，后面会根据id将lua函数映射到C#函数
        //path为lua文件路径,id为文件名
        public void LoadFile(string path,string name)
        {
            
        }

        public void Dispose()
        {
            _env.Dispose();
        }
    }
}