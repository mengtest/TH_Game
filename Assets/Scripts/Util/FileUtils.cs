using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Util
{
    //这个类在后面肯定会利用起来的
    public static class FileUtils
    {
        private static List<string> _searchPaths = new List<string>();
        private static string _defaultPath;
        
        public static void Init()
        {
#if UNITY_STANDALONE_WIN || PLATFORM_STANDALONE_WIN
            InitByWin32();
#elif UNITY_ANDROID
            InitByAndroid();
#endif
        }

        public static void AddSearchPath(string path)
        {
            _searchPaths.Add(path);
        }

        public static string[] GetFiles(string path)
        {
            var dir = _defaultPath + "/" + path;
            if (Directory.Exists(dir))
            {
                return Directory.GetFiles(dir);
            }

            foreach (var str in _searchPaths)
            {
                dir = str + "/" + path;
                if (Directory.Exists(dir))
                {
                    return Directory.GetFiles(dir);
                }
            }

            return null;
        }

        public static void SetDeaultPath(string path)
        {
            _defaultPath = path;
        }
        
        private static void InitByAndroid()
        {
            
        }

        private static void InitByWin32()
        {
            
        }

        public static string ScriptRoot
        {
            get
            {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_64
                return Directory.GetCurrentDirectory() + "/common/lua/";
#elif UNITY_ANDROID
                return Application.persistentDataPath + "/common/lua/";
#endif
            }
        }
    }
}