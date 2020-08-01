using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;
using Object = UnityEngine.Object;
using UnityEngine.Windows;

namespace Util
{
    using Pair = Global.Pair<Object, int>;
    
    [CSharpCallLua]
    [LuaCallCSharp]
    public interface ILoader
    {
        //加载资源
        Object Load(string path);

        Object Load(string path, Type type);

        //释放资源
        void Unload(Object obj);

        void Unload(string name);

        void Unload();

        //写文件
        void Write(string path, string text);

        // void AddSearchPath(string path);
    }

    class WinLoader : ILoader
    {
        private Dictionary<string, Pair> _resources;
        // private List<string> _searchPath;

        public WinLoader()
        {
            _resources = new Dictionary<string, Pair>();
            // _searchPath = new List<string>();
        }

        // public void AddSearchPath(string path)
        // {
        //     if (!_searchPath.Contains(path))
        //     {
        //         _searchPath.Add(path);
        //     }
        // }

        public Object Load(string path)
        {
            //先调用其他的加载方式去加载资源，例如ab
            
            //资源加载的优先级为 searchPath -> ab -> res
            // for (int i = 0; i < _searchPath.Count; i++)
            // {
            //     var p = _searchPath[i];
            //     var str = $"{p}/{path}";

            // }

            // var ab = AssetBundle.LoadFromFile(path);
            // ab.Contains(path);

            

            //如果ab中没有这个资源，再从Resource中去加载这个资源
            return Resources.Load(path);
        }

        public string LoadScript(string path)
        {

            return "";
        }

        public Object Load(string path, Type type)
        {
            
            return Resources.Load(path, type);
        }

        public void Unload(Object obj)
        {

            Resources.UnloadAsset(obj);
        }

        public void Unload(string name)
        {
            
        }

        public void Unload()
        {
            Resources.UnloadUnusedAssets();
        }

        public void Write(string path, string text)
        {
            var dir = new DirectoryInfo(Application.dataPath + path);
            var fs = new FileStream(dir.FullName, FileMode.Open, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(text);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }
    }
    
    [LuaCallCSharp]
    //资源的读取与释放相关api的封装
    //为了应对可能出现的安卓版本的存取问题
    public static class Loader
    {
        private static ILoader _loader;

        public static void Init()
        {
            _loader = new WinLoader();
            
            if (Application.platform == RuntimePlatform.WindowsPlayer
                || Application.platform == RuntimePlatform.WindowsEditor)
            {
                _loader = new WinLoader();
            }
            else
            {
                //去加载一个lua脚本
                throw new Exception("暂时没有定义该平台的资源加载方式");
            }
        }
        
        public static void Unload(string name)
        {
            _loader.Unload(name);
        }

        public static void Unload()
        {
            _loader.Unload();
        }

        /// <summary>
        /// 加载一个资源为指定类型
        /// </summary>
        /// <param name="path"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Load<T>(string path) where T : Object
        {
            return _loader.Load(path, typeof(T)) as T; 
        }

        /// <summary>
        /// 加载一个资源为Object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Object Load(string path)
        {
            return _loader.Load(path);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="obj"></param>
        public static void Unload(Object obj)
        {
            _loader.Unload(obj);
        }
        

        /// <summary>
        /// 向一个文本写入
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void Write(string path, string text)
        {
            _loader.Write(path, text);
        }

        /// <summary>
        /// 读取一段文本的内容
        /// </summary>
        /// <param name="path">要读取的文本的路径</param>
        /// <returns></returns>
        public static string Read(string path)
        {
            return Load<TextAsset>(path).text;
        }
    }
}