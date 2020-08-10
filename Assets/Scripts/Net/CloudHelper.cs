using System;
using System.Collections.Generic;
using com.unity.cloudbase;
using com.unity.mgobe;
using Lib;
using UnityEngine;
using XLua;
using Listener = com.unity.mgobe.Listener;

// using Listener = Lib.Listener;

namespace Net
{
    [LuaCallCSharp]
    public class CloudHelper
    {
        private CloudBaseApp app;
        
        public CloudHelper()
        {
            app = CloudBaseApp.Init(
                "env-hfrygbiu",
                3000
            );   
        }

        public void Connect()
        {
            ConnectImpl();
        }

        private async void ConnectImpl()
        {
            // 获取登录状态
            // 唤起匿名登录
            AuthState state = await app.Auth.GetAuthStateAsync() ?? await app.Auth.SignInAnonymouslyAsync();

            if (state == null)
            {
                //未能连接到服务器
                Global.Log("连接失败");
            }
            else
            {
                Global.Log("连接成功");
            }
        }

        //先不管吧，等有时间了再搞这个
        public void CombatInit(string userName)
        {
            var gameInfo = new GameInfoPara {
                GameId = "obg-ll00u54g",//替换为控制台上的“游戏ID”
                OpenId = "obg-ll00u54g",//这个应该是玩家的uid，可以在玩家登入游戏的时候，直接从user表中查询，然后添加到这里 
                SecretKey = "171dc8896b6dbad024344c3d912e4854e148f66d" // 替换为控制台上的“游戏key”
            };
            var gameConfig = new ConfigPara {
                Url = "ll00u54g.wxlagame.com", // 替换为控制台上的“域名”
                ReconnectMaxTimes = 5,
                ReconnectInterval = 1000,
                ResendInterval = 1000,
                ResendTimeout = 10000,
            };
            Listener.Init (gameInfo, gameConfig, (ResponseEvent eve) => {
                if (eve.Code == ErrCode.EcOk) {
                    // 初始化成功
                    // 继续在此添加代码
                    // ...
                    Room.GetMyRoom((c) =>
                    {
                        //当前玩家没有在任何房间内
                        if (c.Code == 20011)
                        {
                            var  info = new RoomInfo();
                            var room = new Room(info);
                            PlayerInfoPara playerInfoPara = new PlayerInfoPara
                            {
                                Name = "测试Name",    //这个name应该从user表中来
                                CustomProfile = "测试CustomProfile",
                                CustomPlayerStatus = 12345,
                            };
                            CreateRoomPara createRoomPara = new CreateRoomPara
                            {
                                RoomName = "测试RoomName",    //房间id可以使用cpp的dll中创建的combat的id
                                RoomType = "测试RoomType",
                                MaxPlayers = 10,
                                IsPrivate = true,
                                CustomProperties = "测试CustomProperties",
                                PlayerInfo = playerInfoPara,
                            };
                            room.CreateRoom(createRoomPara, (e) =>
                            {
                                if (e.Code == 0)
                                {
                                    // 创建成功
                                    Debug.LogFormat ("创建成功 {0}", e.Data);
                                    // 使⽤ room 调⽤其他API，如 room.StartFrameSync
                                    // ...
                                    return;
                                }
                                if (e.Code == 20010) {
                                    Debug.Log ("玩家已在房间内");
                                    return;
                                }
                                Debug.Log ("调⽤失败");
                            });
                        }
                    });
                }
            });
        }

        //检测是否需要更新资源
        public bool CheckUpdate()
        {
            return true;
        }

        //验证当前玩家是否有管理员权限
        public bool Verify(string userName, string userPwd)
        {
            return true;
        }

        //玩家登入游戏
        public void Login(string userName, string userPwd)
        {
            LoginImpl(userName, userPwd);
        }

        private async void LoginImpl(string userName, string userPwd)
        {
            AuthState state = await app.Auth.GetAuthStateAsync() ?? await app.Auth.SignInAnonymouslyAsync();
            var data = await app.Db.Collection("Users").Where(new
            {
                username = app.Db.Command.Eq(userName),
                userpwd = app.Db.Command.Eq(userPwd)
            }).Field(new Dictionary<string, bool> {{"_id", false}}).GetAsync();
            //查询到了数据，说明登入成功
            if (data.Data != null)
            {
                Lib.Listener.Instance.Event("Cloud_Base_User_Login", true, data.Data[0].Value<string>("name"));
            }
            else
            {
                Lib.Listener.Instance.Event("Cloud_Base_User_Login", false);
            }
        }
        
        public void Login2(string userName, string userPwd, YukiEventDelegate callback)
        {
            LoginImpl(userName, userPwd);
            callback(11111, "zxczxc");
        }

        // private async void LoginImpl(string userName, string userPwd)
        // {
        //     AuthState state = await app.Auth.GetAuthStateAsync() ?? await app.Auth.SignInAnonymouslyAsync();
        //     var data = await app.Db.Collection("Users").Where(new
        //     {
        //         username = app.Db.Command.Eq(userName),
        //         userpwd = app.Db.Command.Eq(userPwd)
        //     }).Field(new Dictionary<string, bool> {{"_id", false}}).GetAsync();
        //     //查询到了数据，说明登入成功
        //     if (data.Data != null)
        //     {
        //         Lib.Listener.Instance.Event("Cloud_Base_User_Login", true, data.Data[0].Value<string>("name"));
        //     }
        //     else
        //     {
        //         Lib.Listener.Instance.Event("Cloud_Base_User_Login", false);
        //     }
        // }

        public void RpcCall(string name, params object[] data)
        {
            
        }

        //版本更新
        public void Update()
        {
            
        }
    }
}