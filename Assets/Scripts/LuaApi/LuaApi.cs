using System.Runtime.InteropServices;
using System;
using UnityEngine;
using XLua;

[LuaCallCSharp]
public class LuaApi
{
    const int NN_EVENT_BEGIN = 10000;
    const int ATTR_BEGIN = 20000;
    const int PLAYER_ATTR_BEGIN = ATTR_BEGIN + 1000;
    const int PAWN_ATTR_BEGIN = ATTR_BEGIN + 2000;
    const int BUFF_ATTR_BEGIN = ATTR_BEGIN + 3000;
    const int PAWN_MOVE_BEGIN = ATTR_BEGIN + 4000;
    const int COST_BEGIN = 30000;
    const int PLAYER_COST_BEGIN = COST_BEGIN + 1000;
    const int PAWN_COST_BEGIN = COST_BEGIN + 2000;

	const int EventPawnAttrHp = PAWN_ATTR_BEGIN + 1;
	const int EventPawnAttrMp = PAWN_ATTR_BEGIN + 2;
	const int EventPawnAttrMatk = PAWN_ATTR_BEGIN + 3;
	const int EventPawnAttrAtk = PAWN_ATTR_BEGIN + 4;
	const int EventPawnAttrDef = PAWN_ATTR_BEGIN + 5;
	const int EventPawnAttrMdef = PAWN_ATTR_BEGIN + 6;
	const int EventPawnAttrBuff = PAWN_ATTR_BEGIN + 7;
	const int EventPawnAttrSkill = PAWN_ATTR_BEGIN + 8;
	const int EventPawnAttrPosType = PAWN_ATTR_BEGIN + 9;
	const int EventPawnAttrPos = PAWN_ATTR_BEGIN + 10;
	const int EventPawnAttrDead = PAWN_ATTR_BEGIN + 11;

	const int EventBuffAttrRestTime = BUFF_ATTR_BEGIN + 1;
	const int EventBuffAttrDispose = BUFF_ATTR_BEGIN + 2;
	const int EventBuffAttrOverlay = BUFF_ATTR_BEGIN + 3;
	const int EventBuffAttrDestroy = BUFF_ATTR_BEGIN + 4;

	const int EventPlayerAttrHp = PLAYER_ATTR_BEGIN + 1;
	const int EventPlayerAttrEnergy = PLAYER_ATTR_BEGIN + 2;
	const int EventPlayerAttrMaxEnergy = PLAYER_ATTR_BEGIN + 3;
	const int EventPlayerAttrGold = PLAYER_ATTR_BEGIN + 4;

	//以下为一些移动棋子的事件
	const int PlayerAttrHandCardsToDeck = PAWN_MOVE_BEGIN + 1;
	const int PlayerAttrCombatCardToDeck = PAWN_MOVE_BEGIN + 2;
	const int PlayerAttrDeckCardsToCombat = PAWN_MOVE_BEGIN + 3;
	const int PlayerAttrDeckCardsToHand = PAWN_MOVE_BEGIN + 4;
	const int PlayerAttrHandCardsToCombat = PAWN_MOVE_BEGIN + 5;
	const int PlayerAttrCombatCardsToHand = PAWN_MOVE_BEGIN + 6;

	const int CostPawnHp = 1 + PAWN_COST_BEGIN;
	const int CostPawnMp = 2 + PAWN_COST_BEGIN;
	const int CostPawnAtk = 3 + PAWN_COST_BEGIN;
	const int CostPawnDef = 4 + PAWN_COST_BEGIN;
	//无视这个就行了
	// const int CostPawnMp2 = 5 + PAWN_COST_BEGIN;
	const int CostPawnMatk = 6 + PAWN_COST_BEGIN;
	const int CostPawnMdef = 7 + PAWN_COST_BEGIN;

	const int CostPlayerHp = 1 + PLAYER_COST_BEGIN;
	const int CostPlayerEnergy = 2 + PLAYER_COST_BEGIN;
	const int CostPlayerMaxEnergy = 3 + PLAYER_COST_BEGIN;
	const int CostPlayerGold = 4 + PLAYER_COST_BEGIN;



    /// <summary>
    /// 现在先完成C#端的基本功能，然后出一个包，接下来就直接在生成的包中开发
    /// </summary>
    [LuaCallCSharp]
    public struct AttrStruct
    {
        public int combatId;   //战斗实例的id           //这个参数主要是为了，如果后期添加服务端的话，这个可以标识唯一的combat
        public int playerId;   //目标玩家的id，如果发给当前房间所有玩家，则设置为0
        public int objectId;   //属性改变了的目标对象的id(比如棋子的id，buffId，如果是玩家，可以不传)
        public int value;      //属性改变后的值
        public int type;       //改变的是哪项属性(具体参考constant里面例举的值)
        public int targetType; //新增属性，表示当前对象表示是哪种类型的，0、无效 1、棋子 2、玩家 3、buff 4、战斗本身

        public override string ToString()
        {
            return $"{nameof(combatId)}: {combatId}, {nameof(playerId)}: {playerId}, {nameof(objectId)}: {objectId}, {nameof(value)}: {value}, {nameof(type)}: {type}, {nameof(targetType)}: {targetType}";
        }
    };

    [LuaCallCSharp]
    public struct BuffD
    {
        public int id;
        public int restTime;               //buff的剩余时间
        public int unique_id;              //为这个buff分配的uid
        public int overlay;
    };

    [LuaCallCSharp]
    public struct PawnD
    {
        //棋子拥有的技能是相对固定的，只要知道是什么棋子就能知道这个棋子有哪些技能，所以不返回棋子技能的信息
        public int id;
        public int unique_id;          //单次战斗中会被分配的唯一id(每次战斗开始的时候，会获取所有玩家当前的所有卡牌，同时为这些卡牌分配唯一的id)
        public int hp;                 //生命值
        public int mp;                 //魔法值
        public int matk;               //魔法攻击力
        public int atk;                //攻击力
        public int def;                //防御力
        public int mdef;               //模仿防御力
        public int playerId;           //持有这个棋子的玩家id
        public int type;               //n、r、sr、ssr
        public int posType;            //当前棋子所在的地方的类型
        public int pos;                //棋子所在的下标
    };
    
    [LuaCallCSharp]
    public struct PlayerS
    {
        public int uid;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public int[] cards;                          //本次战斗，该玩家所选择的卡组信息       这里是id而非unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public int[] pawns;                          //当前玩家持有的所有卡牌的信息           这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public int[] handCards;           //该玩家手上持有的卡牌信息              这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public int[] combatCards;                     //该玩家正在战斗的卡牌信息              这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public int[] deckCards;                      //卡池中所有的卡牌信息                  这里应该是unique_id
        public int hp;                                 //玩家剩余的血量
        public int maxHp;                              //最大血量
        public int energy;                             //玩家当前的能量
        public int maxEnergy;                          //玩家所能拥有的最大能量，指的是每回合开始，玩家拥有的初始能量
        public int gold;                               //玩家当前所持有的金币数
    };

    public delegate void UpdateAction(AttrStruct attr);
    public delegate void NoticeFunction(string str);

    //合并thcore到xlua的dll中，所以这里直接使用xlua作为dllName
    public const string DllName = @"xlua";

    //导出给CS的一些api
	//获取到一个buff的实例对象(展示对象)
    //这个真正的返回值类型是BuffS
    [DllImport(DllName)]
	public static extern IntPtr get_buff(int combatId, int buffId);

	//获取到一个pawn的实例对象(展示对象)
    //这个真正的返回值类型是PawnS
    [DllImport(DllName)]
	public static extern IntPtr get_pawn(int combatId, int pawnId);

	//获取到一个玩家的实例对象(展示对象)
    //这里的实际返回类型为PlayerD，没有PlayerS数据
    [DllImport(DllName)]
	public static extern IntPtr get_player(int combatId, int uid);

    [DllImport(DllName)]
	public static extern void init(string root, IntPtr L);

    //方便获取core中的lua栈
    [DllImport(DllName)]
	public static extern IntPtr get_lua_state();

    //方便获取core中的lua栈
    [DllImport(DllName)]
	public static extern void release_all();

    //这个函数用于cs端或者js端获取所有战斗中所有的棋子信息更新
    [DllImport(DllName)]
	public static extern void set_update_action(UpdateAction fun);

    //这个函数用于cs端或者js端获取战斗中的自定义消息，接收的消息为一个字符串
	[DllImport(DllName)]
	public static extern void set_notice_action(NoticeFunction fun);

    public static PawnD GetPawn(int combatId, int pawnId)
    {
        var ptr = LuaApi.get_pawn(combatId, pawnId);
        if(ptr != IntPtr.Zero)
        {
            return Marshal.PtrToStructure<PawnD>(ptr);
        }
        return default;
    }

    public static PlayerS GetPlayer(int combatId, int uid)
    {
        var ptr = LuaApi.get_player(combatId, uid);
        if(ptr != IntPtr.Zero)
        {
            var data = Marshal.PtrToStructure<PlayerS>(ptr);
            return data;
        }
        return default;
    }

    public static BuffD GetBuff(int combatId, int buffId)
    {
        var ptr = LuaApi.get_buff(combatId, buffId);
        if(ptr != IntPtr.Zero)
        {
            var data = Marshal.PtrToStructure<BuffD>(ptr);
            return data;
        }
        return default;
    }
}