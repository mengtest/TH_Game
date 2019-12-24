using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Prefab;
using UnityEngine;
using UnityEngine.SceneManagement;
using Util;
using XLua;
using Object = UnityEngine.Object;

/// <summary>
/// 包含有各种全局的结构，工具函数等
/// </summary>
[LuaCallCSharp]
public static partial class Global
{
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
    /// 打印消息日志,同时输出到
    /// </summary>
    /// <param name="msg">输出的消息</param>
    /// <param name="level">日志级别</param>
    public static void Log(string msg, Level level = Level.Info)
    {
        var info = $"[DATE: {DateTime.Now.ToString(CultureInfo.CurrentCulture)}] [{level}] {msg}";
        DirectoryInfo dirinfo = new DirectoryInfo(Application.dataPath);
        string fileName = dirinfo.FullName + $"../Logs/log_{DateTime.Now.Date.ToString(CultureInfo.CurrentCulture)}.dat";
        if (!File.Exists(fileName))
        {
            File.Create(fileName);
        }
        var f = File.Open(fileName, FileMode.Append, FileAccess.Write);
        var bytes = Encoding.UTF8.GetBytes(info);
        f.Write(bytes, 0, bytes.Length);
        f.Close();
        switch (level)
        {
            case Level.Warning:
                Debug.LogWarning(info);
                break;
            case Level.Error:
                Debug.LogError(info);
                break;
            case Level.Debug:
                Debug.Log(info);
                break;
            case Level.Info:
                Debug.Log(info);
                break;
            default:
                Debug.Log(info);
                break;
        }
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

    /// <summary>
    /// 获取到当前的画布，
    /// 方便操作ui
    /// </summary>
    /// <returns>当前画布或者null</returns>
    public static Canvas GetCurCanvas()
    {
        return GetRootObject("UICanvas").GetComponent<Canvas>();
    }

    /// <summary>
    /// 弹出一个模态对话框
    /// </summary>
    /// <param name="text">需要显示的文本</param>
    public static void Alert(string text)
    {
        new ModelDialog(text).ShowDialog();
    }

    public const float ToastShort = 1.5f;
    public const float ToastLong = 3.0f;
    
    /// <summary>
    /// 弹出一段提示信息，类似于安卓的toast
    /// </summary>
    /// <param name="text">需要显示的文本</param>
    /// <param name="time">持续的时间，以秒为单位</param>
    public static void MakeToast(string text, float time)
    {
        var obj = Loader.Load<GameObject>("Prefab/Toast");
        var toast = Object.Instantiate(obj, GetCurCanvas().transform, true);
        toast.transform.localPosition = new Vector3(0, -400);
        toast.GetComponent<ToastScript>().Make(text, time);
    }
}
