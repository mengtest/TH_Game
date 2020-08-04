using System.Runtime.InteropServices;
using Core;
using LuaFramework;
using UnityEngine;
using Util;
using Net;
using UnityEngine.InputSystem;
using DataCenter = Core.DataCenter;

/// <summary>
/// 游戏开始的时候，各种必要的资源等的初始化
/// </summary>
public static class GameInit
{
    public static string imeString = "";
    
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
        // Pool.Init();
        FileUtils.Init();
    }

    // [DllImport(@"E:\Game\Test\cmake-build-debug\Test.dll", CallingConvention = CallingConvention.Cdecl)]
    // public static extern int test_fun(int a);
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void Init()
    {
        // var xlua = new XLua.LuaEnv(true);
        // LuaApi.init("./");
        // xlua.DoString("local t = Damage.new() " +
        //               "nn.log('11111')");

        // var ptr = LuaApi.get_lua_state();
        // var lua = new XLua.LuaEnv(ptr);
        // Debug.Log(ptr.ToString());
        // Debug.Log(test_fun(10));
        
        Lib.Listener.Instance.Event("after_app_init", Global.Scene.name);
    }
}
