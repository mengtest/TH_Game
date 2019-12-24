using UnityEngine;
using Util;

namespace LuaFramework
{
    //自动加载目标模块
    public class LuaModules
    {

        /// <summary>
        /// 加载一个模块
        /// </summary>
        /// <param name="name">模块名称</param>
        /// <param name="path">模块的路径</param>
        /// <param name="local">是否是非全局模块</param>
        /// <returns></returns>
        public void LoadModule(string name, string path, bool local)
        {
            var str = Loader.Load<TextAsset>(name);
            //使用LuaEngine去加载这个模块中的init文件
        }
    }
}