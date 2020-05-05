
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static Card GenCard(byte[] bytes)
                {
                    var r = Card.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        