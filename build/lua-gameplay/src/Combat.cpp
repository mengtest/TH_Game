#include "Combat.h"
#include "BuffMachine.h"
#include "Player.h"
#include "Helper.h"
#include "Agent.h"
#include "Logger.h"
#include "fmt/format.h"

Combat::Combat(int id)
	: _id(id)
	, _machine(new BuffMachine(this))
{

}

Combat::~Combat()
{
	delete _player1;
	delete _player2;
	delete _machine;
}

int Combat::id()
{
	return _id;
}

void Combat::release()
{
	//释放整个战斗系统实例的内存

	//先释放所有玩家的内存，
	//玩家会释放所有棋子的内存
	//棋子会释放所有buff的内存
    if (_player1 != nullptr)
    {
        _player1->release();
    }

    if (_player2 != nullptr)
    {
        _player2->release();
    }

	//buff机再释放
    if (_machine != nullptr)
    {
        _machine->release();
    }
}

bool Combat::addPlayer(Player* player)
{
	if (hasPlayer(player->uid()))
	{
		return false;
	}
	if (_player1 == nullptr)
	{
		_player1 = player;
	}
	else if(_player2 == nullptr)
	{
		_player2 = player;
	}
	else
	{
		//如果两个玩家都不为空的话，则无法再次添加新的玩家
		return false;
	}
	//添加玩家的时候创建这个玩家所有的棋子
	player->createAllPawn();
	return true;
}

bool Combat::addPlayer(CombatRequirePlayer* info)
{
	auto player = new Player(info, this);
	if (this->addPlayer(player))
	{
		return true;
	}
	else
	{
		delete player;
		player = nullptr;
		return false;
	}
}

bool Combat::addPlayer(int uid, std::vector<int> v)
{
	ylog("call combat's addplayer method");
	auto player = new Player(uid, v, this);
	if (this->addPlayer(player))
	{
		return true;
	}
	else
	{
		delete player;
		player = nullptr;
		ylog("添加玩家失败");
		return false;
	}
}

void Combat::releasePlayer(int id)
{
	if (_player1 && _player1->uid() == id)
	{
		_player1->release();
		delete _player1;
		_player1 = nullptr;
	}
	else if (_player2 && _player2->uid() == id)
	{
		_player2->release();
		delete _player2;
		_player2 = nullptr;
	}
}

bool Combat::hasPlayer(int id)
{
	return (_player1 && _player1->uid() == id) || (_player2 && _player2->uid() == id);
}

Player* Combat::getPlayer(int id)
{
	if (_player1 && _player1->uid() == id)
	{
		return  _player1;
	}
	else if (_player2 && _player2->uid() == id)
	{
		return _player2;
	}
	return nullptr;
}

Pawn* Combat::getPawnById(int id)
{
	return nullptr;
}

Pawn* Combat::getPawnByUid(int uid)
{
	Pawn* pawn = nullptr;
	if (_player1)
	{
		pawn = _player1->getPawnByUid(uid);
	}
	if (!pawn && _player2)
	{
		pawn = _player2->getPawnByUid(uid);
	}
	return pawn;
}

bool Combat::start()
{
    //双方有一个玩家不存在，则无法开始战斗
    if (!_player1 || !_player2)
    {
        clog(this->_id, "not enough number of players,cant start combat");
        return false;
    }
    clog(this->_id, "combat start");
    //还需要通知当前战斗中所有的玩家，战斗正式开始了
    // TODO
	//后续还是要看，怎么让战斗流程可以正确进行
	this->processInvalid();
	return true;
}

bool Combat::over()
{
    clog(this->_id, "战斗结束");
	//战斗结束时调用
	//释放所有的
	// TODO
	this->release();
	return true;
}

Player* Combat::getEnemy(Player* player)
{
	//如果当前房间中存在这个玩家，则返回对应的敌对玩家，否则返回空
	if ( (_player1 && player->uid() == _player1->uid()) 
		|| (_player2 && player->uid() == _player2->uid()))
	{
		if (player->uid() == _player1->uid())
		{
			return _player2;
		}
		return _player1;
	}
	return nullptr;
}

Player* Combat::getWorkPlayer()
{
	return _workPlayer;
}

Player* Combat::getNextPlayer()
{
	if (_workPlayer->uid() == _player1->uid())
	{
		return _player2;
	}
	return _player1;
}

TurnState Combat::getCurState()
{
	return _turnState;
}

int Combat::allocPawnId()
{
	return ++_maxPawnId;
}

int Combat::getCurTurn()
{
	return _curTurn;
}

BuffMachine* Combat::getMachine()
{
	return _machine;
}

void Combat::nextFlow()
{
    clog(this->id(), "当前阶段是{0}进入下一阶段", int(this->_turnState));
	switch (this->_turnState) 
	{ 
	case TurnState::invalid: 
		{
			// this->_turnState = TurnState::prepare; 
			processInvalid(); 
			break;
		}
	case TurnState::prepare:
		{
			// this->_turnState = TurnState::start;
			processPrepare(); 
			break;
		}
	case TurnState::start: 
		{
			// this->_turnState = TurnState::battle;
			processStart();
			break;
		}
	case TurnState::battle: 
		{
			// this->_turnState = TurnState::over;
			processBattle();
			break;
		}
	case TurnState::over: 
		{
			// this->_turnState = TurnState::prepare;
			processOver();
			break;
		}
	default: ;
	}
}

//start的时候直接调用这个函数，开始战斗
void Combat::processInvalid()
{
	//这里要做的事有
	//选择一个玩家作为先攻的玩家
	int first = Helper::random(1, 2);
	if (first == 1)
	{
		_workPlayer = _player1;
	}
	else
	{
		_workPlayer = _player2;
	}
    clog(1, "产生的随机数是{0}", first);
	clog(1, "先攻的玩家是{0}", _workPlayer->uid());
	// 通知客户端先攻的玩家的id是_workPlayer
	// AgentMgr::instance()->curAgent()->msg(fmt::format("first&{0}", _workPlayer->uid()));
    // TODO

	const auto& config = AgentMgr::instance()->curAgent()->config();

	//重置当前所有玩家的状态，同时发送给当前所有的玩家
	Player* player = nullptr;
	for (int i = 0; i < 2; ++i)
	{
		if (i % 2 == 0)
		{
			player = _player1;
		}
		else
		{
			player = _player2;
		}

		//所有玩家的状态全部初始化
		player->opHp(config.primaryHp);
		player->opEnergy(config.primaryEnergy);
		player->opMaxEnergy(config.primaryEnergy);
		player->opGold(config.primaryGold);

		//发放玩家初始的卡牌
		player->draw(config.primaryCard, false);
	}
	// this->_turnState = TurnState::prepare;
	//设置当前回合为1，每次回合结束的时候才会去+1
	//还需要发送当前的回合数给所有的客户端
	this->_curTurn = 1;
	this->_turnState = TurnState::prepare;
	nextFlow();
}

void Combat::processPrepare()
{
	auto* worker = getWorkPlayer();
	const auto& config = AgentMgr::instance()->curAgent()->config();

	//第一回合不会增长能量上限
	if (1 != this->_curTurn)
	{
		//最大能量不能超过配置中的数值
		if (worker->maxEnergy() <= config.maxEnergy)
		{
			worker->opMaxEnergy(config.energyGrow);
		}
	}

	//发放卡牌
	worker->draw(config.roundCard, false);

	//当前玩家场上所有的正在战斗中的棋子，身上的buff全部执行一遍
	this->getMachine()->executeAll(worker);

	this->_turnState = TurnState::start;

	nextFlow();
}

void Combat::processStart()
{
	const auto& config = AgentMgr::instance()->curAgent()->config();
	auto* worker = this->getWorkPlayer();
	//能量恢复到最大数值
	// worker->to(yGlobal.EventPlayerAttrEnergy, worker->maxEnergy());
	worker->opEnergy(worker->maxEnergy() - worker->energy());
	worker->opGold(config.salary);

	//所有当前玩家正在战斗中的棋子的魔法回复对应的值
	//目前直接阉割掉这个部分
	//发送一条消息给cs端

	this->_turnState = TurnState::battle;

	nextFlow();
}

void Combat::processBattle()
{
	//这个阶段时，对应的玩家的客户端可以接收玩家所有的输入，并转化成程序所需要的信息处理
	//非当前行动的玩家，将无法进行任何操作
	//非战斗阶段，玩家点击结束回合按钮无效

	// this->_turnState = TurnState::over;
	//战斗状态不能直接跳转到结束状态，只有玩家点击结束按钮，或者当前回合的时间结束时才会结束当前回合
	//但是目前不实现倒计时相关的功能
	//只有玩家点击结束回合按钮时才会结束当前回合


	// this->_turnState = TurnState::over;
}

void Combat::processOver()
{
	//结束的时候为第40回合则执行一些特殊的操作
	if (this->_curTurn == 40)
	{
		//判定游戏平局，看具体怎么做
		PASS;
		return;
	}
	
	this->_curTurn++;
	_workPlayer = this->getNextPlayer();
	this->_turnState = TurnState::prepare;
	nextFlow();
}

void Combat::turnEnd(int id)
{
	//只有当前正在行动的玩家点击结束回合按钮才有效
	if (id == this->_workPlayer->uid() 
		&& _turnState == TurnState::battle)
	{
		ylog("玩家{0}点击了结束回合按钮", _workPlayer->uid());
		//如果操作这个api的是当前正在工作的玩家
		//则可以结束当前的回合
		this->_turnState = TurnState::over;
		this->nextFlow();
	}
}
