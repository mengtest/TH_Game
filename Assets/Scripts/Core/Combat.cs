using System.Collections.Generic;
using Game.Core;

namespace Core
{
    /// <summary>
    /// 这个是cs端与cpp或者服务端交互的部分
    /// 如果是离线模式，则启用cpp部分
    /// 如果是在线模式，则启用服务器部分
    /// 这里就是对这两种模式来做底层的屏蔽，
    /// 譬如说如果是调用cpp模块的话，那么就是直接获取struct，或者其他对象，但是如果是服务端的话则是接收一个消息，将这个消息转成struct
    /// 目前就使用cpp导出cs、cs导出lua代码来完成战斗系统相关的功能
    /// 这个就是客户端的战斗系统的调用
    /// </summary>
    public class Combat
    {
        private IPrimitive _impl;
        
        // public event Types.UpdatePlayerMsgEvent event1;
        // public event Types.UpdateCombatMsgEvent event3;
        // public event Types.UpdatePawnMsgEvent event2;

        public Combat()
        {
            // event1 = msg => { };
            // event2 = msg => { };
            // event3 = msg => { };
        }

        /// <summary>
        /// 与ai对战，在lua端直接调用
        /// </summary>
        /// <param name="ai">具体的ai对象</param>
        public void Start(AI ai)
        {
            if (Net.NetHelper.GetInstance().Online())
            {
                
            }
            else
            {
                _impl = new CombatImplOffline();
            }
            // ai.Init();
        }
        
        /// <summary>
        /// 与具体的玩家对战，对手玩家的参数来源会根据服务端的消息实例化
        /// 单机模式下，玩家点击匹配按钮之后，会调用这里的函数
        /// </summary>
        public void Start()
        {

        }

        /// <summary>
        /// 当前玩家准备完成，核心部分会检测
        /// </summary>
        public void PrepareComplete()
        {
            
        }

        /// <summary>
        /// 开始监听玩家的输入
        /// </summary>
        public void ListenUserInput()
        {
            //玩家点击卡牌、抽卡等操作都会转化成UserInput
        }

        /// <summary>
        /// 不监听玩家的输入
        /// </summary>
        public void OffUserInput()
        {
            //在敌方回合时调用，此时任何当前玩家的输入都会变成不合法的输入
            //会提示  不是您的回合，无法进行此操作
        }

        /// <summary>
        /// 结束战斗
        /// </summary>
        public void Over()
        {
            
        }
        
        public interface IPrimitive
        {
            /// <summary>
            /// 初始化
            /// 还需要双方玩家,如果为负数，表示是ai
            /// </summary>
            void Init(int uid, int id2);

            /// <summary>
            /// 开始战斗
            /// </summary>
            void Start();

            /// <summary>
            /// 战斗结束
            /// </summary>
            void End();
        }

        // private class CombatImplOnline : IPrimitive
        // {
        //     
        // }
        
        private class CombatImplOffline : IPrimitive
        {
            private Dictionary<int, Types.UpdatePlayerMsgEvent> _updatePlayerFuncList = new Dictionary<int, Types.UpdatePlayerMsgEvent>();
            private Dictionary<int, Types.UpdateCombatMsgEvent> _updateCombatFuncList = new Dictionary<int, Types.UpdateCombatMsgEvent>();
            private Dictionary<int, Types.UpdatePawnMsgEvent> _updatePawnFuncList = new Dictionary<int, Types.UpdatePawnMsgEvent>();
            //客户端自己会保存当前所在的房间号，同时js也会为玩家保存房间号
            private int _roomId;

            public CombatImplOffline()
            {
                // _updatePlayerFuncList.Add(1, );
            }
            
            public void Init(int uid, int id2)
            {
                // if (!CppCore.isCoreInit())
                // {
                //     //start会先控制客户端进入战斗场景
                //     CppCore.csCoreInit(UpdatePlayerMsgCallback, UpdatePawnMsgCallback, UpdateCombatMsgCallback);
                // }
            }

            public void Start()
            {
                
            }

            public void End()
            {
                
            }

            private void UpdatePlayerMsgCallback(Types.UpdatePlayerMsg msg)
            {
                // msg.
                //这里处理玩家相关的信息
                //type的含义
                //0、无效
                //1、受到伤害
                //2、受到治疗
                //3、最大能量增加
                //4、能量回复
                //5、能量回满
                //6、消耗能量
                //7、抽卡 高级、低级
                //8、召唤一个棋子
                //9、回收一个棋子
                //10、出售一个棋子
                //11、获得金币
                //12、消耗金币
                //13、退出房间
                //14、掉线
                //15、回到房间
                //16、认输

                if (msg.type == 0)
                {
                    
                }
                else if (msg.type == 1)
                {
                    
                }
            }

            private void UpdatePawnMsgCallback(Types.UpdatePawnMsg msg)
            {
                //type的含义，
                //0、无效
                //1、受到伤害
                //2、受到治疗
                //3、消耗魔法
                //4、扣除魔法
                //5、回复魔法
                //6、受到技能影响
                //7、受到buff影响
                
            }
            
            private void UpdateCombatMsgCallback(Types.UpdateCombatMsg msg)
            {
                
            }
        }
    }
}