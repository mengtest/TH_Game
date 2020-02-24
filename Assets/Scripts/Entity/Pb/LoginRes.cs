using XLua;

// ReSharper disable once CheckNamespace
namespace Pb
{
    [LuaCallCSharp]
    public static class Gen
    {
        public static LoginRes GenLoginResult(byte[] bytes)
        {
            return LoginRes.Parser.ParseFrom(bytes);
        }

        public static LoginMsg GenLoginMsg(byte[] bytes)
        {
            return LoginMsg.Parser.ParseFrom(bytes);
        }
    }
}