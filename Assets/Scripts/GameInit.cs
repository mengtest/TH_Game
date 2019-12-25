using System.Runtime.InteropServices;
using LuaFramework;
using Net;
using UnityEngine;
using Util;

/// <summary>
/// 游戏开始的时候，各种必要的资源等的初始化
/// </summary>
public static class GameInit
{
    /// <summary>
    /// 在游戏开始的时候自动加载这个方法，对一些单例类做出初始化，会在游戏开始的时候自动调用
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplicationInit()
    {
        Listener.Init();
        Loader.Init();
        Singleton.Init();
        Core.DataCenter.Init();
        //先暂时不启用网络连接相关的功能
        Net.NetHelper.Init();
        LuaEngine.Init();
        Pool.Init();
        LuaModules.Init();
        LuaModules.GetInstance().LoadAll();
        
//        connect("127.0.0.1", 9998);
        
//        read((str, length) =>
//        {
//            Debug.Log(str);
//            Debug.Log(length);
//        });

//        write("123123123123");

//        write("123123123123123");
//        var _env = new XLua.LuaEnv();
//        var table = _env.NewTable();
//        var meta = _env.NewTable();
//        meta.Set("__index", _env.Global);
//        table.SetMetaTable(meta);
//        meta.Dispose();
//        _env.DoString(
//            Resources.Load<TextAsset>("LuaScript/player/player.lua").text,
//            "xlua",
//            table);
//
//        var player = table.Get<IPlayer>("Player");
//        Global.Log(player.GetName());
    }


//    public delegate void Callback(string str, int length);
//
//    [DllImport("Core 7")]
//    public static extern void read(Callback callback);
//    
//    [DllImport("Core 7")]
//    public static extern void close();
//    
//    [DllImport("Core 7")]
//    public static extern void connect(string str, int port);
//    
//    [DllImport("Core 7")]
//    public static extern void write(string str);
}
