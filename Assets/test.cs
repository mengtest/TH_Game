using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.unity.cloudbase;
using com.unity.mgobe;
// using com.unity.cloudbase.Runtime;
using Scene.SettingScene;
using ScriptObject;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public VoicePanel panel1;
    public VoicePanel panel2;
    public Config config;
    public Config memoryConfig;
    public UserAsset users;
    
    // Start is called before the first frame update
    void Start()
    {
        config = Resources.Load<Config>("Config/config");
        var list = GetComponentsInChildren<VoicePanel>();
        if (list.Length == 2)
        {
            panel1 = list[0];
            panel1.AddSliderChangeEvent((v) => { config.bgmVol = v; });
            panel2 = list[1];
            panel2.AddSliderChangeEvent((v) => { config.effVol = v; });
        }

        // Addressables.LoadAssetAsync<UserAsset>("UserAsset").Completed += LoadComplete;

        // Login();

        // var gameInfo = new GameInfoPara {
        //     GameId = "obg-ll00u54g",
        //     OpenId = "obg-ll00u54g", // 替换为控制台上的“游戏ID”
        //     SecretKey = "171dc8896b6dbad024344c3d912e4854e148f66d" // 替换为控制台上的“游戏key”
        // };
        // var gameConfig = new ConfigPara {
        //     Url = "ll00u54g.wxlagame.com", // 替换为控制台上的“域名”
        //     ReconnectMaxTimes = 5,
        //     ReconnectInterval = 1000,
        //     ResendInterval = 1000,
        //     ResendTimeout = 10000,
        // };
        // Listener.Init (gameInfo, gameConfig, (ResponseEvent eve) => {
        //     if (eve.Code == ErrCode.EcOk) {
        //         // 初始化成功
        //         // 继续在此添加代码
        //         // ...
        //         Room.GetMyRoom((c) =>
        //         {
        //             if (c.Code == 20011)
        //             {
        //                 var  info = new RoomInfo();
        //                 var room = new Room(info);
        //                 PlayerInfoPara playerInfoPara = new PlayerInfoPara
        //                 {
        //                     Name = "测试Name",
        //                     CustomProfile = "测试CustomProfile",
        //                     CustomPlayerStatus = 12345,
        //                 };
        //                 CreateRoomPara createRoomPara = new CreateRoomPara
        //                 {
        //                     RoomName = "测试RoomName",
        //                     RoomType = "测试RoomType",
        //                     MaxPlayers = 10,
        //                     IsPrivate = true,
        //                     CustomProperties = "测试CustomProperties",
        //                     PlayerInfo = playerInfoPara,
        //                 };
        //                 room.CreateRoom(createRoomPara, (e) =>
        //                 {
        //                     if (e.Code == 0)
        //                     {
        //                         // 创建成功
        //                         Debug.LogFormat ("创建成功 {0}", e.Data);
        //                         // 使⽤ room 调⽤其他API，如 room.StartFrameSync
        //                         // ...
        //                         return;
        //                     }
        //                     if (e.Code == 20010) {
        //                         Debug.Log ("玩家已在房间内");
        //                         return;
        //                     }
        //                     Debug.Log ("调⽤失败");
        //                 });
        //             }
        //         });
        //     }
        // });
    }

    public async void Login()
    {
        CloudBaseApp app = CloudBaseApp.Init(
            "env-hfrygbiu",
            3000
        );

        // 获取登录状态
        AuthState state = await app.Auth.GetAuthStateAsync();

        // 唤起匿名登录
        if (state == null) {
            state = await app.Auth.SignInAnonymouslyAsync();
        }

        var t = await app.Storage.GetFileDownloadUrlAsync(new List<string>
            {"cloud://env-hfrygbiu.656e-env-hfrygbiu-1256957346/res/AssetBundles/ui_res"});

        
        StartCoroutine(DownLoad(t.FileList[0].DownloadUrl));
        // Down(t.FileList[0].DownloadUrl);

        // FunctionResponse res =
        //     await app.Function.CallFunctionAsync("node-app", new Dictionary<string, dynamic>() {{"a", 1}, {"b", 2}});
        // print(res.Data);

        // var db = app.Db;
        // Command cmd = db.Command;
        // var data = await db.Collection("Users").Where(new
        // {
        //     username = cmd.Eq("root"),
        //     userpwd = cmd.Eq(123456)
        // }).Field(new Dictionary<string, bool>{{"_id", false}}).GetAsync();
        // print(data.Data);
    }

    private IEnumerator DownLoad(string path)
    {
        var request = UnityWebRequest.Get(path);
        request.SendWebRequest();
        while (!request.isDone)
        {
            yield return 1;
        }

        var ab = AssetBundle.LoadFromMemory(request.downloadHandler.data);
        var sp = ab.LoadAsset<Sprite>("Ocean1");
        var go = new GameObject();
        go.AddComponent<Image>().sprite = Instantiate(sp);
        go.transform.SetParent(Global.GetCurCanvas().transform, true);
        go.transform.localPosition = Vector3.one;
        go.GetComponent<Image>().SetNativeSize();
    }

    private void LoadComplete(AsyncOperationHandle<UserAsset> op)
    {
        if (op.Status == AsyncOperationStatus.Succeeded)
        {
            users = Instantiate(op.Result);
            print(users.userNames[0]);
            // users.userNames[0] = "zzzzzzzzzzzzzzzzzzzzzz";
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
