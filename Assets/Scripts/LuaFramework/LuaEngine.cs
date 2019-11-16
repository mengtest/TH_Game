using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using XLua;
using XLua.LuaDLL;
using XLuaTest;

namespace LuaFramework
{
    public class LuaEngine : IDisposable
    {
        private static LuaEngine _engine;
        private LuaEnv _env;
        private Dictionary<string, LuaTable> _luaTables;

        public static LuaEngine MainInstance => _engine;

        public static void Init()
        {
            if (_engine == null)
            {
                _engine = new LuaEngine();
                _engine._luaTables = new Dictionary<string, LuaTable>();
            }
            
            //一些准备工作
            if (!_engine._luaTables.ContainsKey("functions"))
            {
                _engine.LoadFile("LuaScript/Functions.lua", "functions");
            }
        }

        public LuaTable GetTable(string key)
        {
            return _luaTables.ContainsKey(key) ? _luaTables[key] : null;
        }
        

        public void AddTable(string key, LuaTable table)
        {
            if (_luaTables.ContainsKey(key))
            {
                _luaTables[key].Dispose();
                _luaTables[key] = table;
            }
            else
            {
                _luaTables.Add(key, table);
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
        public LuaTable LoadFile(string path, string name)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            _env.DoString(
                Resources.Load<TextAsset>(path).text,
                name,
                table);
            if (_luaTables.ContainsKey(name))
            {
                _luaTables[name].Dispose();
                _luaTables[name] = table;
            }
            else
            {
                _luaTables.Add(name, table);
            }
            return table;
        }
        
        public LuaTable LoadFile(string path, string name ,MonoBehaviour self)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            table.Set("self", self);
            _env.DoString(
                Resources.Load<TextAsset>(path).text,
                name,
                table);
            if (_luaTables.ContainsKey(name))
            {
                _luaTables[name].Dispose();
                _luaTables[name] = table;
            }
            else
            {
                _luaTables.Add(name, table);
            }
            return table;
        }
        
        public LuaTable LoadFile(string path, string name, MonoBehaviour self, Injection[] injections)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            table.Set("self", self);

            foreach (var injection in injections)
            {
                table.Set(injection.name, injection.value);
            }
            
            _env.DoString(
                Resources.Load<TextAsset>(path).text,
                name,
                table);
            if (_luaTables.ContainsKey(name))
            {
                _luaTables[name].Dispose();
                _luaTables[name] = table;
            }
            else
            {
                _luaTables.Add(name, table);
            }
            return table;
        }

        public void Dispose()
        {
            _env.Dispose();
        }
    }
}