#pragma once

#include <vector>

struct CombatRequirePlayer;
class Player;
class BuffMachine;
class Pawn;

enum class TurnState
{
	invalid,	//无效的阶段			战斗还没有真正开始
	prepare,	//准备阶段			buff的倒计时计算，能量计算，卡牌发放
	start,		//开始阶段			金币发放，能量回复，魔法回复
	battle,		//战斗阶段			玩家可以控制棋子战斗、召唤棋子、抽取卡牌、出售卡牌、使用棋子技能
	over,		//结束阶段			回合数判定（比如设定40回合没有打完，判定为平局），控制权移交下一个玩家
};

//由combat管理所有的玩家
class Combat
{
private:
	const int _id;

	Player* _player1 = nullptr;

	Player* _player2 = nullptr;

	BuffMachine* _machine = nullptr;

	//现在不再单独表示棋盘中的棋子
	//需要查找对应的棋子的话，直接从玩家身上去查找

	TurnState _turnState = TurnState::invalid;

	Player* _workPlayer = nullptr;

	int _maxPawnId = 0;

	int _curTurn = 0;
public:
	Combat(int id);

	~Combat();

	int id();

	//释放当前房间的内存
	void release();

	//向当前房间中添加一个已经创建好了的玩家
	bool addPlayer(Player* player);

	//根据玩家的原始信息来创建并添加一个玩家
	//这个会有内存操作
	bool addPlayer(CombatRequirePlayer* info);

	//使用必要的数据来直接初始化玩家相关的信息
	//因为sol2无法使用vector的const引用作为参数，所以这里直接使用普通的vector作为参数
	//这个会有内存操作
	bool addPlayer(int uid, std::vector<int> v);

	//一个玩家退出房间，释放对应玩家的内存
	//删除鸡肋api
	// void releasePlayer(Player* player);

	//根据玩家的id释放对应玩家的内存
	void releasePlayer(int id);

	//目标玩家离开当前房间
	//需要提供这个api吗？
	// void playerLeave(int uid);

	//检测当前房间是否含有对应id的玩家
	bool hasPlayer(int id);

	//根据id获取目标玩家
	Player* getPlayer(int id);

	//根据棋子的id获取到唯一的棋子
	//这个api其实不明用途
	[[deprecated]] Pawn* getPawnById(int id);

	//根据棋子的uid获取到唯一的棋子
	Pawn* getPawnByUid(int uid);

	//当前玩家的回合结束
	//需要传入玩家参数判定，点击结束回合按钮的玩家是谁
	//传入参数为要结束回合的玩家的uid
	void turnEnd(int id);

	//开始当前的战斗
	bool start();

	//结束当前的战斗
	//由于lua中end是一个关键字，所以修改为over
	//这个函数是一个被动调用的函数(由THCore系统本身来调用)
	bool over();

	//获取player的敌对玩家
	//感觉主要就是获取当前玩家的敌对玩家
	Player* getEnemy(Player* player);

	//获取当前正在行动中的玩家
	Player* getWorkPlayer();

	//获取到下一个行动的玩家
	Player* getNextPlayer();

	//获取当前所处的战斗流程
	//感觉需要暴露这里的状态枚举给lua
	TurnState getCurState();

	//为棋子分配id
	//每场战斗中的棋子的id是唯一的
	//所以交由combat来分配棋子id
	int allocPawnId();

	//获取当前的回合数
	int getCurTurn();

	//获取当前的buff机
	BuffMachine* getMachine();

	//当前的战斗系统进入到下一个回合
	void nextFlow();
private:
	//当前处于非开启阶段的处理
	void processInvalid();

	//当前处于准备阶段的处理
	void processPrepare();

	//当前处于开始阶段的处理
	void processStart();

	//当前处于战斗阶段的处理
	void processBattle();

	//当前处于结束阶段的处理
	void processOver();
};
