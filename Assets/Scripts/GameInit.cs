using LuaFramework;
using UnityEngine;
using Util;
using Net;

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
        NetHelper.Init();
        LuaEngine.Init();
        Pool.Init();
    }
}
