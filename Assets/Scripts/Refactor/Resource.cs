using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    //所有与本地资源打交道的全部存放在这个类里头完成
    public class Resource
    {
        public static Object LoadRes(string name)
        {
//            Object res = null;
//            FileInfo info = null;
//            //优先读取这个路径下的文件，如果存在同名文件，则直接加载，否则读取其他路径的文件
//            info = new FileInfo(Application.persistentDataPath + "/" + name);
//            if (info.Exists)
//            {
////                File.ReadAllBytes(info.FullName);
////                var fs = info.Open(FileMode.Open, FileAccess.Read);
////                AssetBundle.LoadFromFile(info.FullName).LoadAsset("");
//            }
//            return res;

            return Resources.Load(name);
        }

        //加载指定路径下面所有文件，不会递归加载子目录里面的文件
        public static Dictionary<string, Object> LoadDir(string path)
        {
            Dictionary<string, Object> res = new Dictionary<string, Object>();
//            DirectoryInfo dir = null;
//            dir = new DirectoryInfo(Application.persistentDataPath + "/" + path);
//            //优先读取这个路径下的文件，如果存在同名文件，则直接加载，否则读取其他路径的文件
//            if (dir.Exists)
//            {
//                Resources.lo
//            }

            return res;
        }
    }
}