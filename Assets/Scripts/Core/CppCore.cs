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
    public static class CppCore
    {
        public const string DllName = @"Core.dll";

	    /// 运行流程		
	    ///			csCoreInit
	    ///			createCombatSystem
	    ///			combatStart			//如果满足游戏结束的条件的话，会自动结束战斗

        /**
		 * \brief cs核心的初始化，需要注册几个事件，以便于与core交互
		 * 这个对应流程图中的总的初始化
		 * \return 
		 */
        [DllImport(DllName)]
        public static extern bool csCoreInit(Types.UpdatePlayerMsgEvent event1, Types.UpdatePawnMsgEvent event2,
            Types.UpdateCombatMsgEvent event3);

        /**
		 * \brief 核心模块是否已经初始化
		 * \return 
		 */
        [DllImport(DllName)]
        public static extern bool isCoreInit();

        /**
		 * \brief 销毁核心模块，如果已被销毁，则没有任何效果
		 * \return 是否销毁成功
		 */
        [DllImport(DllName)]
        public static extern bool coreDestroy();

        /**
		 * \brief 创建一个新的战斗系统实例对象
		 * 对应流程图中的创建战斗系统
		 * \param originName 原始战斗系统的名称,直接传入空指针的话
		 * \param newName 新的战斗系统的名称
		 * \return 是否创建成功
		 */
        [DllImport(DllName)]
        public static extern bool createCombatSystem(string originName, string newName);

        /**
		 * \brief 以默认的战斗系统为模板创建一个新的战斗系统
		 * \param name 新的战斗系统的名称
		 * \return 是否创建成功
		 */
        [DllImport(DllName)]
        public static extern bool createCombatSystemDefault(string name);

        /**
		 * \brief 销毁一个战斗系统
		 * \param name 销毁的战斗系统的名称
		 * \return 是否销毁成功
		 */
        [DllImport(DllName)]
        public static extern bool releaseCombatSystem(string name);

        /**
		 * \brief 根据id取得对应的对象
		 * \param id 目标玩家的id
		 * \return 
		 */
        [DllImport(DllName)]
        public static extern Player getPlayerById(int id);
        
        /**
		 * \brief 战斗开始
		 * 这里对应战斗开始的函数，这里需要的实际信息是，当前玩家的id、以及当前玩家所选择的卡牌
		 * \return 是否操作成功
		 */
        [DllImport(DllName)]
        public static extern bool combatStart(Player player1, Player player2);
        
        /**
		 * \brief 战斗结束
		 * \return 操作的结果
		 */
        [DllImport(DllName)]
        public static extern bool combatEnd();

        //这里对应cs端传递消息给cpp端
        [DllImport(DllName)]
        public static extern bool cs2cpp(Types.Cmd cmd);

        //这里对应cpp端传递消息给cs端
        [DllImport(DllName)]
        public static extern bool cpp2cs(Types.Cmd cmd);

        /// <summary>
        ///好像没什么用
        /// </summary>
        /// <returns></returns>
        [DllImport(DllName)]
        public static extern bool end();

        /**
		 * \brief 开始战斗
		 * \param playerId 进入战斗的玩家的id
		 * \return 
		 */
        [DllImport(DllName)]
        public static extern bool battle(int playerId);

        [DllImport(DllName)]
        public static extern void testFunc();
    }
}