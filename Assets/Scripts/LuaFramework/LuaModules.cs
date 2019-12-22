using UnityEngine;
using Util;

namespace LuaFramework
{
    //自动加载目标模块
    public class LuaModules
    {
        public void LoadModule(string name)
        {
            var str = Loader.Load<TextAsset>(name);
            //使用LuaEngine去加载这个模块中的init文件
        }
    }
}