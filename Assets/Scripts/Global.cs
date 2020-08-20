using System;
using Lib;
using LuaFramework;
using Prefab;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using Util;
using XLua;
using Clickable = Common.Clickable;
using Object = UnityEngine.Object;

/// <summary>
/// 包含有各种全局的结构，工具函数等
/// </summary>
[LuaCallCSharp]
public static partial class Global
{
    private static ILuaMethod _methods;
    private static Canvas _curCanvas;
    
    /// <summary>
    /// 打印消息日志的等级
    /// </summary>
    public enum Level
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Debug = 3,
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="method"></param>
    /// <param name="param"></param>
    [DoNotGen]
    public static void CallLuaMethod(string method, params object[] param)
    {
        if (_methods == null)
        {
            var env = LuaEngine.Instance.LoadString(Util.Loader.Load<TextAsset>("LuaScript/extend/methods.lua").text,
                "LuaMethod");
            _methods = env.Get<ILuaMethod>("_luaExtend");
        }
        _methods.Call(method, param);
    }

    public static void GetChineseEnglishNumber(string str, out int chinese, out int english)
    {
        int c = 0;
        int e = 0;
        foreach (var ch in str)
        {
            if (ch > 127)
            {
                c++;
            }
            else
            {
                e++;
            }
        }
        chinese = c;
        english = e;
    }
    
    /// <summary>
    /// 打印消息日志，后续会添加将日志输出到任意位置的功能
    /// </summary>
    /// <param name="msg">输出的消息</param>
    /// <param name="level">日志级别</param>
    public static void Log(string msg, Level level = Level.Info)
    {
        switch (level)
        {
            case Level.Warning:
                Debug.LogWarning(msg);
                break;
            case Level.Error:
                Debug.LogError(msg);
                break;
            case Level.Debug:
                Debug.Log(msg);
                break;
            case Level.Info:
                Debug.Log(msg);
                break;
            default:
                Debug.Log(msg);
                break;
        }
    }

    public static void AsyncTest()
    {
//        var x = Application.streamingAssetsPath + "";
//        var y = Application.persistentDataPath + "";
    }

    private static async void AsyncTestImpl(YukiEventDelegate callback)
    {
        //本地的nginx资源服务器路径，
        // var request = UnityWebRequest.Get("http://localhost:9635/res/th_res/v1_0_0/AssetBundles/img.zip");
        // request.SendWebRequest();
    }

    public static void Log(object msg, Level level = Level.Info)
    {
        Log(msg.ToString(), level);
    }

    /// <summary>
    /// 获取当前正在运行的场景，主要是简化lua端代码
    /// </summary>
    public static UnityEngine.SceneManagement.Scene Scene => SceneManager.GetActiveScene();

    /// <summary>
    /// 获取到根对象
    /// </summary>
    /// <param name="name">目标对象的名称</param>
    /// <returns>目标对象，或者null</returns>
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

    private static void AddDefaultCanvas()
    {
        foreach (var go in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            var canvas = go.GetComponent<Canvas>();
            if (canvas != null)
            {
                if (canvas.name != "UILayer")
                {
                    canvas.name = "UILayer";
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // var c = new GameObject("UILayer");
        // var canvasComponent =  c.AddComponent<Canvas>();
        // canvasComponent.renderMode = RenderMode.ScreenSpaceOverlay;
        // canvasComponent.pixelPerfect = false;
        // canvasComponent.sortingOrder = 0;
        // canvasComponent.targetDisplay = 
        // SceneManager.MoveGameObjectToScene(c, Scene);
    }

    /// <summary>
    /// 获取到当前的画布，
    /// 方便操作ui
    /// </summary>
    /// <returns>当前画布或者null</returns>
    public static Canvas GetCurCanvas()
    {
        return GetRootObject("UILayer").GetComponent<Canvas>();
    }

    /// <summary>
    /// 弹出一个模态对话框
    /// </summary>
    /// <param name="text">需要显示的文本</param>
    public static void Alert(string text)
    {
        new ModelDialog(text).ShowDialog();
    }

    public const float TOAST_SHORT = 1.5f;
    public const float TOAST_LONG = 3.0f;
    
    /// <summary>
    /// 弹出一段提示信息
    /// </summary>
    /// <param name="text">需要显示的文本</param>
    /// <param name="time">持续的时间，以秒为单位</param>
    public static void MakeToast(string text, float time)
    {
        var obj = Loader.Load<GameObject>("Prefab/Toast");
        var toast = Object.Instantiate(obj, GetCurCanvas().transform, true);
        toast.transform.localPosition = new Vector3(0, 250);
        toast.GetComponent<ToastScript>().Make(text, time);
        toast.transform.localScale = new Vector3(1, 1, 1);
    }

    // public static void Test(Lib.Listener. act)
    // {
    //     act?.Invoke(1, 200.1, "asdasd");
    //     Log(act.GetHashCode().ToString());
    // }
    
    [DoNotGen]
    [Obsolete]
    public static GameObject FindChildByPath(this string path)
    {
        return null;
    }

    [DoNotGen]
    [Obsolete]
    public static GameObject FindChildByName(this string name)
    {
        return null;
    }

    /**
     * <summary>
     * 严格的判定子关系
     * </summary>
     */
    public static bool IsChildOf(this GameObject self, GameObject parent)
    {
        if (self == parent)
        {
            return false;
        }
        
        var cursor = self.transform;
        while (cursor != parent.transform)
        {
            if (cursor.transform.parent == null || cursor.transform == self.transform.root)
            {
                return parent.transform == cursor.transform;
            }
            
            cursor = cursor.parent;
        }
        return true;
    }

    /**
     * <summary>
     * 严格的判定子关系
     * </summary>
     */
    public static bool IsChildOf(this Transform self, Transform parent)
    {
        if (self == parent)
        {
            return false;
        }

        var cursor = self;
        while (cursor != parent)
        {
            if (cursor.parent == null || cursor == self.root)
            {
                return parent == cursor;
            }
            
            cursor = cursor.parent;
        }
        return true;
    }

    /**
     * <summary>
     * 查找名称为name的第一个子节点，如果没有查找到，则返回空
     * </summary>
     */
    public static Transform GetChildByName(this Transform self, string name)
    {
        foreach (Transform child in self)
        {
            if (child.name == name)
            {
                return child;
            }
        }
        return null;
    }

    public static void AttachClickble(this Transform self, Clickable.Func func)
    {
        AttachClickble(self.gameObject, func);
    }
    
    public static void AttachClickble(this GameObject self, Clickable.Func func)
    {
        var component = self.GetComponent<Clickable>();
        if (component == null)
        {
            component = self.AddComponent<Clickable>();
            component.clickEvent += func;
        }
        else
        {
            Object.DestroyImmediate(component);
            component = null;
            var obj = self.AddComponent<Clickable>();
            obj.clickEvent += func;
        }
    }

    public static void RemoveClickble(this Transform self)
    {
        RemoveClickble(self.gameObject);
    }
    
    public static void RemoveClickble(this GameObject self)
    {
        var component = self.GetComponent<Clickable>();
        if (component != null)
        {
            Object.DestroyImmediate(component);
        }
    }
}
