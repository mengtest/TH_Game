﻿using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Callbacks;
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
        //先暂时不启用网络连接相关的功能
        Net.NetHelper.Init();
        Functions.Init();

        Debug.Log(Add_int_int(100, 101));

//        LoginMsg msg = new LoginMsg();
//        msg.Code = 1000;
//        msg.Msg = "hello ni hao a";
    }

    [DllImport("UnityDll")]
    public static extern int Add_int_int(int x, int y);
}
