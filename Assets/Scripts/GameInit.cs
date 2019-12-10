using Game;
using LuaFramework;
using UnityEngine;
using Util;

//游戏开始的时候，各种必要的资源等的初始化
public static class GameInit
{
    //在游戏开始的时候自动加载这个方法，对一些单例类做出初始化
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplicationInit()
    {
//        Global.Resources.Init();
        Singleton.Init();
        //先暂时不启用网络连接相关的功能
        Net.NetHelper.Init();
        LuaEngine.Init();
        Listener.Init();
        Pool.Init();
        
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

//    [DllImport("UnityDll")]
//    public static extern int Add_int_int(int x, int y);
}
