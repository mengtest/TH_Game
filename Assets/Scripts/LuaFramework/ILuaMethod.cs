using XLua;

namespace LuaFramework
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ILuaMethod
    {
        void Call(string name, params object[] param);
    }
}