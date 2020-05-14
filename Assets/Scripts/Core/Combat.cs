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

        /// <summary>
        /// 与ai对战
        /// </summary>
        /// <param name="ai">具体的ai对象</param>
        public void Start(AI ai)
        {
            if (Net.NetHelper.GetInstance().Online())
            {
                
            }
            else
            {
                // _impl = new CombatImplOffline();
            }
            ai.Init();
        }
        
        /// <summary>
        /// 与具体的玩家对战，对手玩家的参数来源会根据服务端的消息实例化
        /// 单机模式下，玩家点击匹配按钮之后，会调用这里的函数
        /// </summary>
        public void Start()
        {
            //start会先控制客户端进入战斗场景、
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
        
        // private class CombatImplOffline : IPrimitive
        // {
        //     
        // }
    }
}