
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static Friend GenFriend(byte[] bytes)
                {
                    var r = Friend.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        