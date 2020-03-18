using XLua;

// ReSharper disable once CheckNamespace
namespace Pb
{
    [LuaCallCSharp]
    public static class Gen
    {
        public static LoginRes GenLoginResult(byte[] bytes)
        {
            var r = LoginRes.Parser.ParseFrom(bytes);
            return r;
        }

        public static LoginMsg GenLoginMsg(byte[] bytes)
        {
            return LoginMsg.Parser.ParseFrom(bytes);
        }
    }
}