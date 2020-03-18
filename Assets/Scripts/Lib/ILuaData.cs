using UnityEngine;
using XLua;

namespace Lib
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ILuaData
    {
        // private string _mvcName;

        string GetMvcName();

        void SetMvcName(string name);

        void HandelEvent();
    }
}