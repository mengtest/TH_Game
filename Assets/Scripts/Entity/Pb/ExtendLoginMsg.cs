
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static LoginMsg GenLoginMsg(byte[] bytes)
                {
                    var r = LoginMsg.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        