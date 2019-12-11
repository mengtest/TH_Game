using System;
using System.IO;
using UnityEngine;
using XLua;
using Object = UnityEngine.Object;

namespace Util
{
    [CSharpCallLua]
    [LuaCallCSharp]
    public interface ILoader
    {
        //加载资源
        Object Load(string path);

        Object Load(string path, Type type);

        //释放资源
        void Unload(Object obj);

        //写文件
        void Write(string path, string text);
    }

    class WinLoader : ILoader
    {
        public Object Load(string path)
        {
            //先调用其他的加载方式去加载资源，例如ab
            
            //如果ab中没有这个资源，再从Resource中去加载这个资源
            return Resources.Load(path);
        }

        public Object Load(string path, Type type)
        {
            return Resources.Load(path, type);
        }

        public void Unload(Object obj)
        {
            Resources.UnloadAsset(obj);
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

        public static T Load<T>(string path) where T : Object
        {
            return _loader.Load(path, typeof(T)) as T; 
        }

        public static Object Load(string path)
        {
            return _loader.Load(path);
        }

        public static void Unload(Object obj)
        {
            _loader.Unload(obj);
        }

        public static void Write(string path, string text)
        {
            _loader.Write(path, text);
        }

        public static string Read(string path)
        {
            return Load<TextAsset>(path).text;
        }
    }
}