using System.Collections.Generic;
using System.Linq;
using Prefab;
using UnityEngine;
using UnityEngine.SceneManagement;
using Util;
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

    public static void Alert(string text)
    {
        new ModelDialog(text).ShowDialog();
    }

    public static Canvas[] GetCanvas()
    {
        List<Canvas> list = new List<Canvas>();
        foreach (var go in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            list.AddRange(go.GetComponentsInChildren<Canvas>());
        }
        return list.ToArray();
    }

    public const float ToastShort = 1.5f;
    public const float ToastLong = 3.0f;
    
    public static void MakeToast(string text, float time)
    {
        var obj = Util.Loader.Load<GameObject>("Prefab/Toast");
        var toast = Object.Instantiate(obj, GetCurCanvas(GetRootObject("UICanvas")).transform, true);
        toast.transform.localPosition = new Vector3(0, -350);
        toast.GetComponent<ToastScript>().Make(text, time);
    }
}
