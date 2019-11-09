using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace LuaFramework
{
    public class LuaEngine : IDisposable
    {
        private static LuaEngine _engine;
        private LuaEnv _env;
        private static Dictionary<string, LuaEngine> _subInstances;

        public static LuaEngine MainInstance
        {
            get
            {
                if (_engine == null)
                {
                    Init();    
                }
                return _engine;
            }
        }

        public static void Init()
        {
            if (_engine == null)
            {
                _engine = new LuaEngine();
                _subInstances = new Dictionary<string, LuaEngine>();
            }
            
            //一些准备工作
            if (!_subInstances.ContainsKey("functions"))
            {
                var env = new LuaEngine();
                _subInstances.Add("functions", env);
                env.LoadFile("LuaScript/Functions.lua");
            }
        }

        public LuaEngine GetSubInstance(string name)
        {
            LuaEngine eng = null;
            if (_subInstances.ContainsKey(name))
            {
                eng = _subInstances[name];
            }
            else
            {
                eng = new LuaEngine();
                _subInstances.Add(name, eng);
            }
            return eng;
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

        public void Dispose()
        {
            _env.Dispose();
        }
    }
}