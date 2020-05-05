
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static Friends GenFriends(byte[] bytes)
                {
                    var r = Friends.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        