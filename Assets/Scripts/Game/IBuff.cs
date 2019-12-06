using XLua;

namespace Game
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface IBuff
    {
        string GetName();

        int GetId();
        
        
    }
}