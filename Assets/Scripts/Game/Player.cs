namespace Game
{
    [XLua.LuaCallCSharp]
    [XLua.CSharpCallLua]
    public interface IPlayer
    {
        string GetName();

        int GetId();

        string GetUserName();
    }
}