using UnityEngine;
using XLua;

namespace Lib
{
    /// <summary>
    /// 相当于mvc中的m
    /// </summary>
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ILuaData
    {
        // private string _mvcName;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetMvcName();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        void SetMvcName(string name);

        /// <summary>
        /// 
        /// </summary>
        void HandelEvent();
    }
}