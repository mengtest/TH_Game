using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Util;

namespace LuaFramework
{
    //自动加载目标模块
    public class LuaModules
    {
        private List<string> _banList = new List<string>();
        private string _root = "";
        private static LuaModules _modules;
        
        public static LuaModules GetInstance()
        {
            return _modules;
        }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            if (_modules == null)
            {
                _modules = new LuaModules();
            }
            var str = Loader.Read("LuaScript/config/module");
            var strs = str.Split('\r', '\n');
            foreach (string s in strs)
            {
                if (s.Length != 0 && s[0] != ';')
                {
                    if (string.IsNullOrEmpty(_modules._root))
                    {
                        _modules._root = s;
                        continue;
                    }
                    _modules._banList.Add(s);
                }
            }
        }

        /// <summary>
        /// 加载module.txt配置文件中根目录下面所有的模块(只会加载一层)
        /// </summary>
        public void LoadAll()
        {
            DirectoryInfo dir = new DirectoryInfo(Application.dataPath + "/" + _root);
            var dirs = dir.GetDirectories();
            foreach (var info in dirs)
            {
                var name = info.Name;
                if (!_banList.Contains(name))
                {
                    var path = _root + "/" + info.Name;
                    LoadModule(name, path);
                }
            }
        }
        
        /// <summary>
        /// 加载一个模块
        /// </summary>
        /// <param name="name">模块名称</param>
        /// <param name="path">模块的路径</param>
        public void LoadModule(string name, string path)
        {
            //加载对应模块中的init.lua.txt文件，然后获取init函数并调用
            var str = Loader.Read(Application.dataPath + "/" + path + "/init.lua");
            //使用LuaEngine去加载这个模块中的init文件
            var table = LuaEngine.Instance.LoadString(str, name);
            table.Get<Action>("init")?.Invoke();
        }
    }
}