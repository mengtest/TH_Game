using XLua;

namespace Game
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface IBuff
    {
        string GetName();

        int GetId();

        int LastTime();

        int RestTime();
        
        
    }
}