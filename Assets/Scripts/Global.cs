using UnityEngine;
using XLua;

[LuaCallCSharp]
public static partial class Global
{
    public enum Level
    {
        Info,
        Warning,
        Error,
        Debug,
    }
    
    public static void Log(string str, Level level = Level.Info)
    {
        switch (level)
        {
            case Level.Warning:
                Debug.LogWarning(str);
                break;
            case Level.Error:
                Debug.LogError(str);
                break;
            case Level.Debug:
                Debug.Log(str);
                break;
            case Level.Info:
                Debug.Log(str);
                break;
            default:
                Debug.Log(str);
                break;
        }
    }
}
