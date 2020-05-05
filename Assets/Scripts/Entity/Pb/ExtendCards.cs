
        using XLua;
    
        // ReSharper disable once CheckNamespace
        namespace Pb
        {
            partial class Gen
            {
                public static Cards GenCards(byte[] bytes)
                {
                    var r = Cards.Parser.ParseFrom(bytes);
                    return r;
                }
            }
        }
        