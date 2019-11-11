using LuaFramework;
using UnityEngine;
using L;
using UnityEngine.SceneManagement;

//游戏开始的时候，各种必要的资源等的初始化
public static class GameInit
{
    //在游戏开始的时候自动加载这个方法，对一些单例类做出初始化
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplicationInit()
    {
        ResourceManager.Init();
        Singleton.Init();
        //先暂时不启用网络连接相关的功能
        Net.NetHelper.Init();
        LuaEngine.Init();

//        var t = Timer.Register(5, () =>
//        {
//            if (SceneManager.GetActiveScene() != null)
//            {
//                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
//            }
//        });
        
        
//        Debug.Log(Add_int_int(100, 101));
    }

//    [DllImport("UnityDll")]
//    public static extern int Add_int_int(int x, int y);
}
