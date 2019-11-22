using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;


//包含有各种全局的结构，工具函数等
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

    public static UnityEngine.SceneManagement.Scene Scene => SceneManager.GetActiveScene();

    public static GameObject GetRootObject(string name)
    {
        foreach (var go in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            if (go.name == name)
            {
                return go;
            }
        }
        return null;
    }

    public static Canvas GetCurCanvas(GameObject go)
    {
        return go.transform.root.GetComponent<Canvas>();
    }

    public static Canvas GetCurCanvas(Component comp)
    {
        return GetCurCanvas(comp.gameObject);
    }
    
    
}
