using System.Runtime.InteropServices;
using LuaFramework;
using UnityEngine;
using Util;
using Net;
using DataCenter = Core.DataCenter;

/// <summary>
/// 游戏开始的时候，各种必要的资源等的初始化
/// </summary>
public static class GameInit
{
    // [StructLayout(LayoutKind.Sequential)]
    // class Core
    // {
    //     public int id;
    //     [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    //     public int[] buffs;
    //     //注意字符串，最好是英文，到时候会测试一下utf8字符串是否能够显示正文
    //     [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    //     public string name;
    //     public int end;
    //     [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
    //     public string name2;
    // };
    
    // [DllImport("CoreDll.dll", CallingConvention = CallingConvention.Cdecl)]
    // static extern Core getData();
    //
    // [DllImport("CoreDll.dll", CallingConvention = CallingConvention.Cdecl)]
    // static extern void releaseData(ref Core core);
    
    /// <summary>
    /// 在游戏开始的时候自动加载这个方法，对一些单例类做出初始化，会在游戏开始的时候自动调用
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplicationInit()
    {
        // Listener.Init();
        Loader.Init();
        Singleton.Init();
        DataCenter.Init();
        //先暂时不启用网络连接相关的功能
        NetHelper.Init();
        
        //加载全局的lua模块
        LuaEngine.Init();
        
        //加载lua脚本的入口文件
        LuaEngine.LoadLuaModule();
        Pool.Init();
        FileUtils.Init();
        
        // Physics.ray

        // Core c = getData();
        // Debug.Log(c.name);
        // Debug.Log(c.buffs);
        // Debug.Log(c.buffs[19]);
        // Debug.Log(c.id);
        // releaseData(ref c);
    }
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void Init()
    {
        // var go = new GameObject("EventListener");
        // var listener = go.AddComponent<EventListener>();
    }
}
