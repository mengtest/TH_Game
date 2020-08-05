#pragma once

// constexpr int PAWN_ATTR_BEGIN = 100;
// constexpr int BUFF_ATTR_BEGIN = 200;
// constexpr int PLAYER_ATTR_BEGIN = 300;
// constexpr int COST_BEGIN = 1000;


//所有的事件，玩家的属性、棋子的属性都会分配唯一的数值，以便于区分
//换句话说，所有的cost其实已经没用了
constexpr auto NN_EVENT_BEGIN = 10000;

constexpr auto ATTR_BEGIN = 20000;

constexpr auto PLAYER_ATTR_BEGIN = ATTR_BEGIN + 1000;

constexpr auto PAWN_ATTR_BEGIN = ATTR_BEGIN + 2000;

constexpr auto BUFF_ATTR_BEGIN = ATTR_BEGIN + 3000;

constexpr auto PAWN_MOVE_BEGIN = ATTR_BEGIN + 4000;

constexpr auto COST_BEGIN = 30000;

constexpr auto PLAYER_COST_BEGIN = COST_BEGIN + 1000;

constexpr auto PAWN_COST_BEGIN = COST_BEGIN + 2000;

//这一部分在敲定之后，直接写入到lua文件中
//这一个不需要释放，永远都只可能有一份，且不会有任何冲突
class Constant
{
private:
	Constant() = default;

	static Constant* _instance;
public:
	static const Constant& instance();

#pragma region 
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
#pragma endregion 

#pragma region
	const int CostPawnHp = 1 + PAWN_COST_BEGIN;
	const int CostPawnMp = 2 + PAWN_COST_BEGIN;
	const int CostPawnAtk = 3 + PAWN_COST_BEGIN;
	const int CostPawnDef = 4 + PAWN_COST_BEGIN;
	//无视这个就行了
	// const int CostPawnMp2 = 5 + PAWN_COST_BEGIN;
	const int CostPawnMatk = 6 + PAWN_COST_BEGIN;
	const int CostPawnMdef = 7 + PAWN_COST_BEGIN;
#pragma endregion


#pragma region
	const int CostPlayerHp = 1 + PLAYER_COST_BEGIN;
	const int CostPlayerEnergy = 2 + PLAYER_COST_BEGIN;
	const int CostPlayerMaxEnergy = 3 + PLAYER_COST_BEGIN;
	const int CostPlayerGold = 4 + PLAYER_COST_BEGIN;
#pragma endregion

// #pragma region 
// 	//棋子的血量变化
// 	const int PawnAttrHp = PAWN_ATTR_BEGIN + 1;
// 	//棋子的魔法变化
// 	const int PawnAttrMp = 102;
// 	//棋子的魔法攻击力变化
// 	const int PawnAttrMatk = 103;
// 	//物理攻击力变化
// 	const int PawnAttrAtk = 104;
// 	//防御力变化
// 	const int PawnAttrDef = 105;
// 	//魔法防御力变化
// 	const int PawnAttrMdef = 106;
// 	//棋子身上增加了一个buff
// 	const int PawnAttrBuff = 107;
// 	//棋子使用了一个技能
// 	const int PawnAttrSkill = 108;
// 	//棋子所在的位置类型变化
// 	const int PawnAttrPosType = 109;
// 	//棋子的位置变化
// 	const int PawnAttrPos = 110;
// 	//棋子死亡
// 	const int PawnAttrDead = 111;
//
// 	//buff的倒计时变化
// 	const int BuffAttrRestTime = 201;
// 	//buff消失
// 	const int BuffAttrDispose = 202;
// 	//buff的叠加层数变化
// 	const int BuffAttrOverlay = 203;
// 	//buff添加到棋子身上
// #pragma endregion  
//
// #pragma region 
// 	//棋子从手牌到卡组
// 	const int PlayerAttrHandCardsToDeck = 301;
// 	const int PlayerAttrCombatCardToDeck = 302;
// 	const int PlayerAttrDeckCardsToCombat = 303;
// 	const int PlayerAttrDeckCardsToHand = 304;
// 	const int PlayerAttrHandCardsToCombat = 305;
// 	const int PlayerAttrCombatCardsToHand = 306;
// #pragma endregion
// 	
// 	//玩家的血量变化
// 	const int PlayerAttrHp = 307;
// 	//玩家的能量变化
// 	const int PlayerAttrEnergy = 308;
// 	//玩家的最大能量变化
// 	const int PlayerAttrMaxEnergy = 309;
// 	//玩家的金币变化
// 	const int PlayerAttrGold = 310;
//
// 	const int PlayerHp = 1;
// 	const int PlayerEnergy = 2;
// 	const int PlayerMaxEnergy = 3;
// 	const int PlayerGold = 4;
//
// 	const int PawnHp = 1;
// 	const int PawnMp = 2;
// 	const int PawnAtk = 3;
// 	const int PawnDef = 4;
// 	const int PawnMAtk = 5;
// 	const int PawnMDef = 6;
//
// 	//以下是统一的，所有的消耗类型数值
// const int CostPawnHp = COST_BEGIN + 1;
// const int CostPawnMp = COST_BEGIN + 2;
// const int CostPawnAtk = COST_BEGIN + 3;
// const int CostPawnMatk = COST_BEGIN + 4;
// const int CostPawnDef = COST_BEGIN + 5;
// const int CostPawnMdef = COST_BEGIN + 6;
//
// const int CostPlayerHp = COST_BEGIN + 101;
// const int CostPlayerEnergy = COST_BEGIN + 102;
// const int CostPlayerMaxEnergy = COST_BEGIN + 103;
// const int CostPlayerGold = COST_BEGIN + 104;
};