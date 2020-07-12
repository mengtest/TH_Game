using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace LuaFramework
{
    public class LuaEngine :IDisposable
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
        }

        /// <summary>
        /// 游戏开始时，加载全局的lua模块
        /// </summary>
        public static void LoadLuaModule()
        {
            var file = Util.Loader.Load<TextAsset>("LuaScript/modules/init.lua");
            Instance._env.DoString(file.text);
        }
        
        /// <summary>
        /// 以后增加一个功能，
        /// 根据给定的配置文件，去读取lua文件，并加载
        /// 相当于做一个全局的lua库的初始化
        /// </summary>
        private static void LoadLuaLib()
        {
            _engine._env.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
            _engine._env.AddBuildin("gameplay", XLua.LuaDLL.Lua.LoadGamePlay);
            _engine._env.AddBuildin("core", XLua.LuaDLL.Lua.LoadCore);
            
            _engine._env.DoString(Util.Loader.Load<TextAsset>("LuaScript/global/global.lua").text, 
                "global",
                _engine._env.Global);
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
            // _env.L
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
        
        public LuaTable LoadString(string str, string name, Global.Injection[] injections)
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
            foreach (var injection in injections)
            {
                table.Set(injection.name, injection.value);
            }
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

        /// <summary>
        /// 释放一个lua表
        /// </summary>
        /// <param name="tableName"></param>
        public void Release(string tableName)
        {
            if (_luaTables[tableName] != null)
            {
                _luaTables[tableName].Dispose();
                _luaTables.Remove(tableName);
            }
        }

        public void Dispose()
        {
            _env.Dispose();
        }
    }
}