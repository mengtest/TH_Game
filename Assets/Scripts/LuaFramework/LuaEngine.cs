using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

namespace LuaFramework
{
    public class LuaEngine : /*MonoBehaviour,*/ IDisposable
    {
        private static LuaEngine _engine;
        private LuaEnv _env;
        private Dictionary<string, LuaTable> _luaTables;

        public static LuaEngine Instance => _engine;

        public static void Init()
        {
            if (_engine == null)
            {
                _engine = new LuaEngine();
                _engine._luaTables = new Dictionary<string, LuaTable>();
            }
            
            LoadLuaLib();
            
            //一些准备工作

            
            if (!_engine._luaTables.ContainsKey("functions"))
            {
                _engine.LoadFile("LuaScript/Functions.lua", "functions");
            }
        }
        
        //以后增加一个功能，
        //根据给定的配置文件，去读取lua文件，并加载
        //相当于做一个全局的lua库的初始化
        private static void LoadLuaLib()
        {
            // TODO
            _engine._env.DoString(Util.Loader.Load<TextAsset>("LuaScript/global/global.lua").text, 
                "global",
                _engine._env.Global);
            
//            _engine._env.DoString(Util.Loader.Load<TextAsset>("LuaScript/lib/socket.lua").text, 
//                "socket",
//                _engine._env.Global);
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
            _env.AddLoader(CustomLoaderMethod);
        } 
        
        private byte[] CustomLoaderMethod(ref string fileName)
        {
            //找到指定文件  
            fileName = Application.dataPath + "/Resources/LuaScript/" + fileName.Replace('.', '/') + ".lua";
            if (File.Exists(fileName))
            {
                return File.ReadAllBytes(fileName);
            }
            else
            {
//                return File.ReadAllBytes(@"F:/Code/THGame/output/THGame_Data/Resources/LuaScript/" + fileName);
                return null;
            }
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
                Util.Loader.Load<TextAsset>(path).text,
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

        public LuaTable LoadString(string str, string name)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            _env.DoString(
                str,
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
        
        public LuaTable LoadFile(string path, string name ,object self)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            table.Set("self", self);
            _env.DoString(
                Util.Loader.Load<TextAsset>(path).text,
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
        
        public LuaTable LoadFile(string path, string name, object self, Global.Injection[] values)
        {
            var table = _env.NewTable();
            var meta = _env.NewTable();
            meta.Set("__index", _env.Global);
            table.SetMetaTable(meta);
            meta.Dispose();
            table.Set("self", self);

            foreach (var injection in values)
            {
                table.Set(injection.name, injection.value);
            }
            
            _env.DoString(
                Util.Loader.Load<TextAsset>(path).text,
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