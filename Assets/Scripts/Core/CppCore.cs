using System.Runtime.InteropServices;
using Game.Core;

namespace Core
{
    /// <summary>
    /// 这个是cpp导出cs的所有函数，
    /// 如果要这样做的话，那么最后还会有cs导出lua
    /// 感觉可以由cpp直接导出到lua
    /// 或者在战斗系统相关的功能中，直接在cs端完成大部分代码，在lua端只使用少量代码
    /// </summary>
    public class CppCore
    {
        //1表示成功，0表示失败
        /**
		 * \brief 初始化核心模块
		 * \return 是否初始化成功
		 */
        [DllImport("123.dll")]
        public static extern bool coreInit();

        /**
		 * \brief cs核心的初始化，需要注册几个事件，以便于与core交互
		 * \return 
		 */
        [DllImport("123.dll")]
        public static extern bool csCoreInit(Types.UpdatePlayerMsgEvent event1, Types.UpdatePawnMsgEvent event2,
            Types.UpdateCombatMsgEvent event3);

        /**
		 * \brief 核心模块是否已经初始化
		 * \return 
		 */
        [DllImport("123.dll")]
        public static extern bool isCoreInit();

        /**
		 * \brief 销毁核心模块，如果已被销毁，则没有任何效果
		 * \return 是否销毁成功
		 */
        [DllImport("123.dll")]
        public static extern bool coreDestroy();

        /**
		 * \brief 创建一个新的战斗系统实例对象
		 * \param originName 原始战斗系统的名称,直接传入空指针的话
		 * \param newName 新的战斗系统的名称
		 * \return 是否创建成功
		 */
        [DllImport("123.dll")]
        public static extern bool createCombatSystem(string originName, string newName);

        /**
		 * \brief 以默认的战斗系统为模板创建一个新的战斗系统
		 * \param name 新的战斗系统的名称
		 * \return 是否创建成功
		 */
        [DllImport("123.dll")]
        public static extern bool createCombatSystemDefault(string name);

        /**
		 * \brief 销毁一个战斗系统
		 * \param name 销毁的战斗系统的名称
		 * \return 是否销毁成功
		 */
        [DllImport("123.dll")]
        public static extern bool releaseCombatSystem(string name);

        /**
		 * \brief 根据id取得对应的对象
		 * \param id 目标玩家的id
		 * \return 
		 */
        [DllImport("123.dll")]
        public static extern Player getPlayerById(int id);

        /**
		 * \brief 监听玩家对象被修改的事件
		 * \param event 回调函数
		 */
        [DllImport("123.dll")]
        public static extern void playerUpdate(Types.PlayerUpdateEvent e);

        /**
		 * \brief core的战斗数据发生了更新
		 */
        [DllImport("123.dll")]
        public static extern void update();

        /**
		 * \brief 触发core中的某个事件，参数还没有想好
		 */
        [DllImport("123.dll")]
        public static extern void coreEvent();

        /**
		 * \brief 通知core某个事件被触发，目前还没有想好参数
		 */
        [DllImport("123.dll")]
        public static extern void coreNotify();

        // /**
        //  * \brief core有信息变化时调用
        //  * \param update 
        //  */
        // [DllImport("123.dll")] public static extern void  event(NotifyUpdate update);

        /**
		 * \brief 目前感觉没什么用
		 */
        [DllImport("123.dll")]
        public static extern void tick();

        /**
		 * \brief 战斗开始
		 * \return 是否操作成功
		 */
        [DllImport("123.dll")]
        public static extern bool combatStart();

        /**
		 * \brief 战斗结束
		 * \return 操作的结果
		 */
        [DllImport("123.dll")]
        public static extern bool combatEnd();

        /**
		 * \brief 处理玩家的指令
		 * \param cmd 一个字符串
		 * \return 是否处理成功
		 */
        [DllImport("123.dll")]
        public static extern bool clientCmd(string cmd);

        /**
		 * \brief 
		 * \param cmd 
		 * \return 
		 */
        [DllImport("123.dll")]
        public static extern bool serverCmd(string cmd);

        [DllImport("123.dll")]
        public static extern bool serverCmd2(Types.Cmd cmd);

        /**
		 * \brief 处理玩家的输入信息
		 * \param cmd 
		 * \return 处理的结果
		 */
        [DllImport("123.dll")]
        public static extern bool clientCmd2(Types.Cmd cmd);

        [DllImport("123.dll")]
        public static extern bool regCmd(int playerId, Types.UserMsg msg);

        [DllImport("123.dll")]
        public static extern bool regPlayerMsg(int roomId, Types.UpdatePlayerMsgEvent msg);

        [DllImport("123.dll")]
        public static extern bool regPawnMsg(int roomId, Types.UpdatePawnMsgEvent msg);

        [DllImport("123.dll")]
        public static extern bool regCombatMsg(int roomId, Types.UpdateCombatMsgEvent msg);

        [DllImport("123.dll")]
        public static extern bool regPlayerCmd(int roomId, Types.UpdatePlayerInfoEvent info);

        // [DllImport("123.dll")] public static extern bool  regPawnCmd(int roomId, UpdatePawnInfoEvent* info);
        //
        // [DllImport("123.dll")] public static extern bool  regCombatCmd(int roomId, UpdateCombatInfoEvent* info);

        // /**
        //  * \brief 玩家开始匹配战斗
        //  * \param uid 玩家的uid
        //  * \return 是否操作成功
        //  */
        // [DllImport("123.dll")] public static extern bool  match(int uid);

        [DllImport("123.dll")]
        public static extern bool end();

        /**
		 * \brief 开始战斗
		 * \param playerId 进入战斗的玩家的id
		 * \return 
		 */
        [DllImport("123.dll")]
        public static extern bool battle(int playerId);
    }
}