
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static LoginRes GenLoginRes(byte[] bytes)
                {
                    var r = LoginRes.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        