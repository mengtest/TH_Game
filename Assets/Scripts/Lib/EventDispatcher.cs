using System.Collections.Generic;
using System.Threading;
using XLua;

namespace Lib
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public delegate void YukiEventDelegate(params object[] objs);

    // public delegate void YukiEvent
    
    /// <summary>
    /// 
    /// </summary>
    public class EventDispatcher
    {

    }
}