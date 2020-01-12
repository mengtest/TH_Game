[XLua.LuaCallCSharp]
partial class LoginRes
{
    public static LoginRes ParseFrom(byte[] bytes)
    {
        return Parser.ParseFrom(bytes);
    }
    
}

[XLua.LuaCallCSharp]
partial class LoginMsg
{
    public static LoginMsg ParseFrom(byte[] bytes)
    {
        var res = Parser.ParseFrom(bytes);
        return res;
    }
}