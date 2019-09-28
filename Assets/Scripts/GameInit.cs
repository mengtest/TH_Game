using System;
using Global;
using Google.Protobuf;
using UnityEngine;

//游戏开始的时候，各种必要的资源等的初始化
public static class GameInit
{
    //在游戏开始的时候自动加载这个方法，对一些单例类做出初始化
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplicationInit()
    {
        ResourceManager.Init();
        Singleton.Singleton.Init();
        Net.NetHelper.Init();

//        LoginMsg msg = new LoginMsg();
//        msg.Code = 1000;
//        msg.Msg = "hello";
//        var str = msg.ToString();
//        var bytes = System.Text.Encoding.Default.GetBytes(str);
        
        
        
//        LoginMsg.Parser.
    }
}
