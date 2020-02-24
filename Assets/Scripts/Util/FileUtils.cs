using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Util
{
    public class FileUtils
    {
        private static List<string> _searchPaths = new List<string>();
        
        public static void Init()
        {
#if UNITY_STANDALONE_WIN
            InitByWin32();
#elif UNITY_ANDROID
            InitByAndroid();
#endif
        }

        public void AddSearchPath(string path)
        {
            _searchPaths.Add(path);
        }

        public string[] GetFiles(string path)
        {
            var dir = Application.dataPath + "/" + path;
            if (Directory.Exists(dir))
            {
                return Directory.GetFiles(dir);
            }
            return null;
        }
        
        private static void InitByAndroid()
        {
            
        }

        private static void InitByWin32()
        {
            
        }
    }
}