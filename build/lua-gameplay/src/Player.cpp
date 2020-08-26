#include "Player.h"
#include "Combat.h"
#include "Pawn.h"
#include "Agent.h"
#include "Constant.h"
#include "Helper.h"
#include "PawnMgr.h"
#include "Logger.h"
#include "fmt/format.h"

Player::Player(CombatRequirePlayer* info, Combat* combat)
	: _combat(combat)
{
	_data = new PlayerS;
	memset(_data, 0, sizeof(PlayerS));
	//通过赋值的方式设置uid，uid设置之后无法修改
	_data->uid = info->uid;
	ylog("new player %d", info->uid);
	for (int i = 0; i < ARYSIZE(info->cards); ++i)
	{
		_data->cards[i] = info->cards[i];
	}
}

Player::Player(int uid, const std::vector<int>& v, Combat* combat)
	: _combat(combat)
{
	_data = new PlayerS;
	memset(_data, 0, sizeof(PlayerS));
	_data->uid = uid;
    ylog("new player {0}", uid);
	for (int i = 0; i < ARYSIZE(_data->cards) && i < v.size(); ++i)
	{
		_data->cards[i] = v[i];
	}
}

Player::~Player()
{
	if (_data)
	{
        // ylog("free player %d", this->_data->uid);
		delete _data;
		_data = nullptr;
	}
	else
    {
        // ylog("free player");
    }
}

int Player::uid()
{
	return _data->uid;
}

int Player::gold()
{
	return _data->gold;
}

int Player::maxEnergy()
{
	return _data->maxEnergy;
}

int Player::energy()
{
	return _data->energy;
}

int Player::hp()
{
	return _data->hp;
}

bool Player::hasPawnInCombat()
{
	for (auto p : this->_panel)
	{
		if (p != 0)
		{
			return true;
		}
	}
	return false;
}

int Player::getMaxCombatPawnNumber()
{
	return PANEL_LENGTH;
}

int Player::getHandPawnNumber()
{
	return _handPawns.size();
}

int Player::getDeckPawnNumber()
{
	return _nPawns.size() + _rPawns.size() + _srPawns.size() + _ssrPawns.size() + _spPawns.size();
}

Pawn* Player::getCombatPawnByIndex(int index)
{
    if (index >= 0 && ARYSIZE(_panel) - 1 > index)
    {
        auto uid = _panel[index];
        if (uid > 0)
        {
            auto it = _allPawns.find(uid);
            if (it != _allPawns.end() && it->second->posType() == 3)
            {
                return it->second;
            }
        }
    }
	return nullptr;
}

Pawn* Player::getHandPawnByIndex(int index)
{
	if (_handPawns.size() > index && index >= 0)
	{
		auto begin = _handPawns.begin();
		while (index)
		{
			--index;
			++begin;
		}
		int uid = *begin;
		if (_allPawns.find(uid) != _allPawns.end())
		{
			return _allPawns[uid];
		}
	}
	return nullptr;
}

Pawn* Player::getPawnByUid(int uid)
{
	if (_allPawns.find(uid) != _allPawns.end())
	{
		return _allPawns[uid];
	}
	return nullptr;
}

bool Player::draw(int number, bool high)
{
	//不能为负数
	if (number <= 0)
	{
		return false;
	}

	const auto& config = AgentMgr::instance()->curAgent()->config();
	//不能超过规定的最大长度
	//如果手上的空位不足以抽取全部的卡牌，则超出的不会被抽取
	int percent1, percent2, percent3, percent4;
	if (high)
	{
		percent1 = config.high_nPercent;
		percent2 = percent1 + config.high_rPercent;
		percent3 = percent2 + config.high_srPercent;
		percent4 = percent3 + config.high_ssrPercent;
	}
	else
	{
		percent1 = config.normal_nPercent;
		percent2 = percent1 + config.normal_rPercent;
		percent3 = percent2 + config.normal_srPercent;
		percent4 = percent3 + config.normal_ssrPercent;
	}

	while (_handPawns.size() < HAND_CARD_NUM && number)
	{
		auto id = Helper::random(1, percent4);
		int type = 0;
		if (id <= percent1)
		{
			type = 1;
		}
		else if (id <= percent2)
		{
			type = 2;
		}
		else if (id <= percent3)
		{
			type = 3;
		}
		else if (id <= percent4)
		{
			type = 4;
		}

		// auto pawnIt = getDeckPawnItRandom(type);
		// if (pawnIt)
		// {
		// 	const auto& value = pawnIt.value();
		// 	//需要将目标卡牌移动到卡牌中
		// 	auto it = _allPawns.find(*value);
		// 	if (it != _allPawns.end())
		// 	{
		// 		auto id1 = (*value);
		// 		if (!(it->second->moveToHand() && removeIt(value, type)))
		// 		{
		// 			//移动失败
		// 			ylog("将棋子%d移动到手牌中出错", *value);
		// 		}
		// 		//将数据添加到手牌的数组中
		// 		// _handPawns.emplace_back(id1);
  //               ylog("玩家%d抽取到了棋子%d", this->uid() , id1);
		// 	}
		// 	else
		// 	{
		// 		ylog("获取到错误的棋子id");
		// 		continue;
		// 	}
		// 	--number;
		// }
		// else
		// {
		// 	ylog("遇到了某些未知的错误");
		// 	// return false;
		// }

		auto uid = getDeckPawnRandom(type);
		if (uid > 0)
		{
			auto it = _allPawns.find(uid);
			if (it != _allPawns.end())
			{
				if (!it->second->moveToHand())
				{
					ylog("将棋子{0}移动到手牌中出错", uid);
				}
				else
				{
					ylog("玩家{0}抽取到了棋子{1}", this->uid(), uid);
				}
			}
			else
			{
				ylog("获取到错误的棋子id");
				continue;
			}
			--number;
		}
		else
		{
			if (uid == -1)
			{
				//如果卡池中没有对应类型的卡牌，则直接返回金币
				//暂定卡牌的出售价格为1、2、4、10
				//后续可能要在配置表中添加
				if (type == 1)
				{
					this->opGold(1);
				}
				else if(type == 2)
				{
					this->opGold(2);
				}
				else if (type == 3)
				{
					this->opGold(4);
				}
				else if (type == 4)
				{
					this->opGold(10);
				}
			}
			else
			{
				ylog("遇到了某些未知的错误");
			}
		}
	}
	return false;
}

// //这个是被调函数，由Combat来调用
// //应该取消在脚本中导出这个函数
// void Player::turnEnd()
// {
// 	//当前玩家回合结束
// 	// TODO
// 	//调用当前的房间的下个阶段函数，
// 	// getCombat()->nextFlow();
//
// 	
// }

Pawn* Player::dissociate(int uid)
{
	if (_allPawns.find(uid) != _allPawns.end())
	{
		auto* pawn = _allPawns.at(uid);
		if (dissociatePawn(pawn))
		{
			return pawn;
		}
	}
	return nullptr;
}

bool Player::dissociatePawn(Pawn* pawn)
{
	auto uid = pawn->unique_id();
	auto posType = pawn->posType();
	if (posType == 1)
	{
		//从卡池中移除掉这个卡牌
		decltype(_nPawns)* l = nullptr;
		switch (pawn->type())
		{
		case 1: {
			l = &_nPawns;
			break;
		}
		case 2: {
			l = &_rPawns;
			break;
		}
		case 3: {
			l = &_srPawns;
			break;
		}
		case 4: {
			l = &_ssrPawns;
			break;
		}
		default:
			//没有这个类型的卡牌，返回false
			return false;
		}
		//移除掉这个卡牌
		l->remove(uid);
		return true;
	}
	else if (posType == 2)
	{
		//从手牌中移除掉这个卡牌
		this->_handPawns.remove(uid);
		return true;
	}
	else if (posType == 3)
	{
		// //从棋盘中移除掉这个卡牌
		// for (auto& i : this->_panel)
		// {
		// 	if (i == uid)
		// 	{
		// 		i = 0;
		// 	}
		// }
		auto pos = pawn->pos();
		if (this->_panel[pos] == uid)
		{
			this->_panel[pos] = 0;
			return true;
		}
	}
	else
	{
		//无效的位置
	}
	return false;
}

int Player::getHandPawnSize()
{
	return _handPawns.size();
}

bool Player::relate(Pawn* pawn)
{
	if (_allPawns.find(pawn->unique_id()) != _allPawns.end())
	{
		// auto* pawn = _allPawns.at(uid);
		auto posType = pawn->posType();
		if (posType == 1)
		{
			//从卡池中移除掉这个卡牌
			decltype(_nPawns)* l = nullptr;
			auto type = pawn->type();
			switch (type)
			{
			case 1: {
				l = &_nPawns;
				break;
			}
			case 2: {
				l = &_rPawns;
				break;
			}
			case 3: {
				l = &_srPawns;
				break;
			}
			case 4: {
				l = &_ssrPawns;
				break;
			}
			default:
				return false;
			}
			//增加这个卡牌到卡池中
			l->emplace_back(pawn->unique_id());
			return true;
		}
		else if (posType == 2)
		{
			//手中的卡牌最大数量为HAND_CARD_NUM
			if (this->_handPawns.size() >= HAND_CARD_NUM)
			{
				return false;
			}
			//增加这个卡牌到手中
			this->_handPawns.emplace_back(pawn->unique_id());
			return true;
		}
		else if (posType == 3)
		{
			//将棋子召唤到场地上
			auto pos = pawn->pos();
			if (this->_panel[pos] == 0)
			{
				this->_panel[pos] = pawn->unique_id();
				return true;
			}
		}
		else
		{
			//无效的位置
		}
	}
	return true;
}

void Player::summon(int pawnUid, int pos)
{
	//当前玩家召唤一个棋子

	//pos参数必须有效
	if (pos >= 0 && pos < PANEL_LENGTH)
	{
		//目标槽位上已经有了卡牌了
		if (_panel[pos] > 0)
		{
			//通知客户端提示“不能重复放置棋子”	
			//这个是正常的
			AgentMgr::instance()->curAgent()->msg("msg&exist_pawn_yet");
			return;
		}
	}
	else
	{
		//位置参数错误
		ylog("error pos param");
		return;
	}

	auto it = std::find_if(this->_handPawns.begin(), this->_handPawns.end(),
		[pawnUid](int v)
		{
			return pawnUid == v;
		});

	if (it == this->_handPawns.end())
	{
		ylog("this player don't contain {0} card", pawnUid);
		return;
	}

	//可以将选择的棋子召唤到目标位置上
	// _handPawns.erase(it);
	auto* pawn = _allPawns.at(pawnUid);
	pawn->moveToPanel(pos);
}

void Player::recover(int pawnUid)
{
	//收回一个棋子
	ylog("暂时没有实现的函数recover");
}

void Player::hit(int damage)
{
	//当前玩家受到伤害

	//这个是最终调用的函数
	//负数值的话则直接修改为0
	if (damage < 0)
	{
		damage = 0;
	}
	// ylog("玩家%d受到%d点伤害,hp剩余", this->_data->uid, this->_data->hp);
	this->_data->hp -= damage;
	clog(1, "玩家%d受到%d点伤害，hp:%d->%d", this->_data->uid, damage, this->_data->hp + damage, this->_data->hp);
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, damage);
	if (this->_data->hp <= 0)
	{
		//当前玩家血量归零，当前游戏结束
		AgentMgr::instance()->curAgent()->msg("msg&game_over");
	}
}

// // * 1、hp
// // * 2、能量
// // * 3、最大能量
// // * 4、金币
// void Player::plus(int type, int number)
// {
// 	//以下均做了数值是否有变化的判定
// 	if (type == yGlobal.EventPlayerAttrHp)
// 	{
// 		if (number > 0)
// 		{
// 			this->_data->hp += number;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 		}
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrEnergy)
// 	{
// 		if (number >= 0)
// 		{
// 			this->_data->energy += number;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->hp);
// 		}
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrMaxEnergy)
// 	{
// 		if (number >= 0)
// 		{
// 			this->_data->maxEnergy += number;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->hp);
// 		}
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrGold)
// 	{
// 		if (number >= 0)
// 		{
// 			this->_data->gold += number;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->hp);
// 		}
// 		return;
// 	}
// 	else
// 	{
//
// 	}
//
// 	
// 	// switch (type)
// 	// {
// 	// case 1:
// 	// {
// 	// 	if (number > 0)
// 	// 	{
// 	// 		this->_data->hp += number;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 2:
// 	// {
// 	// 	if (number >= 0)
// 	// 	{
// 	// 		this->_data->energy += number;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 3:
// 	// {
// 	// 	if (number >= 0)
// 	// 	{
// 	// 		this->_data->maxEnergy += number;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 4:
// 	// {
// 	// 	if (number >= 0)
// 	// 	{
// 	// 		this->_data->gold += number;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// default: ;
// 	// }
// }
//
// // * 1、hp
// // * 2、能量
// // * 3、最大能量
// // * 4、金币
// void Player::minus(int type, int number)
// {
// 	//以下均做了数值是否有变化的判定
// 	if (type == yGlobal.EventPlayerAttrHp)
// 	{
// 		//如果减少的数值大于当前数值，则强制锁定为1，(调用这个api不会导致血量归零而失败)
// 		if (this->_data->hp > number)
// 		{
// 			this->_data->hp -= number;
// 		}
// 		else
// 		{
// 			this->_data->hp = 1;
// 		}
// 		// AgentMgr::instance()->curAgent()->update()
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrEnergy)
// 	{
// 		//最低为0
// 		if (this->_data->energy >= number)
// 		{
// 			this->_data->energy -= number;
// 		}
// 		else
// 		{
// 			this->_data->energy = 0;
// 		}
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->hp);
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrMaxEnergy)
// 	{
// 		//最低为0
// 		if (this->_data->maxEnergy >= number)
// 		{
// 			this->_data->maxEnergy -= number;
// 		}
// 		else
// 		{
// 			this->_data->maxEnergy = 0;
// 		}
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->hp);
// 		return;
// 	}
// 	else if (type == yGlobal.EventPlayerAttrGold)
// 	{
// 		//最低为0
// 		if (this->_data->gold >= number)
// 		{
// 			this->_data->gold -= number;
// 		}
// 		else
// 		{
// 			this->_data->gold = 0;
// 		}
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->hp);
// 		return;
// 	}
// 	else
// 	{
//
// 	}
//
// 	
// 	// switch (type)
// 	// {
// 	// case 1:
// 	// {
// 	// 	//如果减少的数值大于当前数值，则强制锁定为1，(调用这个api不会导致血量归零而失败)
// 	// 	if (this->_data->hp > number)
// 	// 	{
// 	// 		this->_data->hp -= number;
// 	// 	}
// 	// 	else
// 	// 	{
// 	// 		this->_data->hp = 1;
// 	// 	}
// 	// 	// AgentMgr::instance()->curAgent()->update()
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 	// 	break;
// 	// }
// 	// case 2:
// 	// {
// 	// 	//最低为0
// 	// 	if (this->_data->energy >= number)
// 	// 	{
// 	// 		this->_data->energy -= number;
// 	// 	}
// 	// 	else
// 	// 	{
// 	// 		this->_data->energy = 0;
// 	// 	}
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->hp);
// 	// 	break;
// 	// }
// 	// case 3:
// 	// {
// 	// 	//最低为0
// 	// 	if (this->_data->maxEnergy >= number)
// 	// 	{
// 	// 		this->_data->maxEnergy -= number;
// 	// 	}
// 	// 	else
// 	// 	{
// 	// 		this->_data->maxEnergy = 0;
// 	// 	}
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->hp);
// 	// 	break;
// 	// }
// 	// case 4:
// 	// {
// 	// 	//最低为0
// 	// 	if (this->_data->gold >= number)
// 	// 	{
// 	// 		this->_data->gold -= number;
// 	// 	}
// 	// 	else
// 	// 	{
// 	// 		this->_data->gold = 0;
// 	// 	}
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->hp);
// 	// 	break;
// 	// }
// 	// default:;
// 	// }
// }

// // * 1、hp
// // * 2、能量
// // * 3、最大能量
// // * 4、金币
// void Player::to(int type, int number)
// {
// 	//以下均做了数值是否有变化的判定
// 	if (type == yGlobal.EventPlayerAttrHp)
// 	{
// 		if (this->_data->hp == number)
// 		{
// 			return;
// 		}
// 		this->_data->hp = number;
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 	}
// 	else if(type == yGlobal.EventPlayerAttrEnergy)
// 	{
// 		if (this->_data->energy == number)
// 		{
// 			return;
// 		}
// 		this->_data->energy = number;
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->energy);
// 	}
// 	else if (type == yGlobal.EventPlayerAttrMaxEnergy)
// 	{
// 		if (this->_data->maxEnergy == number)
// 		{
// 			return;
// 		}
// 		this->_data->maxEnergy = number;
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->maxEnergy);
// 	}
// 	else if (type == yGlobal.EventPlayerAttrGold)
// 	{
// 		if (this->_data->gold == number)
// 		{
// 			return;
// 		}
// 		this->_data->gold = number;
// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->gold);
// 	}
// 	else
// 	{
// 		
// 	}
// 	
// 	// switch (type)
// 	// {
// 	// case 1:
// 	// {
// 	// 	if (this->_data->hp == number)
// 	// 	{
// 	// 		return;
// 	// 	}
// 	// 	this->_data->hp = number;
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
// 	// 	break;
// 	// }
// 	// case 2:
// 	// {
// 	// 	if (this->_data->energy == number)
// 	// 	{
// 	// 		return;
// 	// 	}
// 	// 	this->_data->energy = number;
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->energy);
// 	// 	break;
// 	// }
// 	// case 3:
// 	// {
// 	// 	if (this->_data->maxEnergy == number)
// 	// 	{
// 	// 		return;
// 	// 	}
// 	// 	this->_data->maxEnergy = number;
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->maxEnergy);
// 	// 	break;
// 	// }
// 	// case 4:
// 	// {
// 	// 	if(this->_data->gold == number)
// 	// 	{
// 	// 		return;
// 	// 	}
// 	// 	this->_data->gold = number;
// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->gold);
// 	// 	break;
// 	// }
// 	// default:;
// 	// }
// }

bool Player::checkAction(int type)
{
	return true;
}

Combat* Player::getCombat()
{
	return _combat;
}

bool Player::hasPawn(int id)
{
	for (const auto& p : _allPawns)
	{
		if (p.second->id() == id)
		{
			return true;
		}
	}
	return false;
}

bool Player::hasPawnUid(int uid)
{
	return _allPawns.find(uid) != _allPawns.end();
}

void Player::release()
{
    ylog("release player {0} 's pawn", this->uid());
	//需要先释放所有的棋子的内存
	for (auto p : _allPawns)
	{
		PawnMgr::release(p.second);
	}
	_allPawns.clear();

	//再释放当前玩家相关的内存
}

int Player::combatId()
{
	return _combat->id();
}

void Player::addPawn(Pawn* pawn)
{
	this->_allPawns.insert({ pawn->unique_id(), pawn });
	
	// ylog("为玩家%d添加一枚棋子%d", this->uid(), pawn->unique_id());
	pawn->addTo(this);
	// TODO
	// 这里还需要根据棋子的id来判断这个棋子的类型，并添加到对应的列表中

	switch (pawn->type())
    {
        case 1:
        {
            this->_nPawns.emplace_back(pawn->unique_id());
            break;
        }
        case 2:
        {
            this->_rPawns.emplace_back(pawn->unique_id());
            break;
        }
        case 3:
        {
            this->_srPawns.emplace_back(pawn->unique_id());
            break;
        }
        case 4:
        {
            this->_ssrPawns.emplace_back(pawn->unique_id());
            break;
        }
        default:
        {
            this->_spPawns.emplace_back(pawn->unique_id());
            break;
        }
    }
}

int Player::getDeckPawnByIndex(int index, int type)
{
	decltype(_nPawns)* list;
	switch (type)
	{
        case 1: {
            list = &_nPawns;
            break;
        }
        case 2: {
            list = &_rPawns;
            break;
        }
        case 3: {
            list = &_srPawns;
            break;
        }
        case 4: {
            list = &_ssrPawns;
            break;
        }
        default:
            return -1;
    }

	if (index < 0 || index > list->size() - 1)
	{
		return -1;
	}

	auto begin = list->begin();
	while (index)
	{
		++begin;
		--index;
	}
	return *begin;
}

int Player::getDeckPawnRandom(int type)
{
	decltype(_nPawns)* list;
	switch (type)
	{
	case 1:
	{
		list = &_nPawns;
		break;
	}
	case 2:
	{
		list = &_rPawns;
		break;
	}
	case 3:
	{
		list = &_srPawns;
		break;
	}
	case 4:
	{
		list = &_ssrPawns;
		break;
	}
	default:
		return -400;
	}

	if (list->empty())
	{
		return -1;
	}

	auto index = Helper::random(0, list->size() - 1);
	auto begin = list->begin();
	while (index)
	{
		++begin;
		--index;
	}
	return *begin;
}

std::optional<Player::DeckPawnList::iterator> Player::getDeckPawnItRandom(int type)
{
	DeckPawnList* list;
	ylog("type:{0}", type);
	switch (type)
	{
	case 1:
	{
		list = &_nPawns;
		break;
	}
	case 2:
	{
		list = &_rPawns;
        break;
	}
	case 3:
	{
		list = &_srPawns;
		break;
	}
	case 4:
	{
		list = &_ssrPawns;
		break;
	}
	default:
		return std::nullopt;
	}

	if (list->empty())
	{
		return std::nullopt;
	}

	auto index = Helper::random(0, list->size() - 1);
	auto begin = list->begin();
	while (index)
	{
		++begin;
		--index;
	}
	return begin;
}

bool Player::removeIt(DeckPawnList::iterator it, int type)
{
	DeckPawnList* list;
	switch (type)
	{
	case 1:
	{
		list = &_nPawns;
		break;
	}
	case 2:
	{
		list = &_rPawns;
		break;
	}
	case 3:
	{
		list = &_srPawns;
		break;
	}
	case 4:
	{
		list = &_ssrPawns;
		break;
	}
	default:
		return false;
	}
	list->erase(it);
	return true;
}

void Player::createAllPawn()
{
    int index = 0;
	//创建并添加所有的棋子
	for (auto card : _data->cards)
	{
		//创建棋子的时候就会分配他的uid
//		ylog("%d", ++index);
		auto *pawn = PawnMgr::create(card, this->getCombat()->allocPawnId());
		if (nullptr != pawn)
		{
			this->addPawn(pawn);
			this->_data->pawns[index] = pawn->unique_id();
			this->_data->deckCards[index] = pawn->unique_id();
			// this->_data.
		}
		else
		{
			//创建失败，这里应该返回一个错误消息，并销毁当前的战斗实例对象
			//简化操作，不做这个步骤
			ylog("初始化玩家:{0}的棋子时遇到了一个致命的错误", uid());
			throw std::exception{"发生了一个致命的错误"};
		}
		index++;
	}
	ylog("玩家{0}的棋子数量分布为1:{1}, 2:{2}, 3:{3}, 4:{4}", this->uid(), this->_nPawns.size(), this->_rPawns.size(), this->_srPawns.size(), this->_ssrPawns.size());
}

void Player::opGold(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->gold += value;
	if (value < 0 && this->_data->gold < 0)
	{
		this->_data->gold = 0;
	}
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrGold, this->_data->gold);
}

void Player::opEnergy(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->energy += value;
	//能量也是最低为0
	if (value < 0 && this->_data->energy < 0)
	{
		this->_data->energy = 0;
	}
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrEnergy, this->_data->energy);
}

void Player::opMaxEnergy(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->maxEnergy += value;
	//最低为1
	if (value < 0 && this->_data->maxEnergy < 0)
	{
		this->_data->maxEnergy = 0;
	}
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrMaxEnergy, this->_data->maxEnergy);
}

void Player::opHp(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->hp += value;
	// TODO
	// 玩家的血量归零后判定为游戏结束
	if (value > 0 && this->_data->hp < 0)
	{
		this->_data->hp = 0;
	}
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPlayerAttrHp, this->_data->hp);
}

PlayerS* Player::data()
{
	//如果当前玩家的第一个棋子的uid为0的话，表示还没有拷贝这里的数据
	if (_data->pawns[0] == 0)
	{
		
	}
	return _data;
}

PlayerD* Player::toDisplay()
{
    //应该移除掉这个方法，
	return nullptr;
}

bool Player::check(int type, int value)
{
    if (type == yGlobal.CostPlayerHp)
    {
    	//生命值的检测必须为大于
        return this->_data->hp > value;
    }
    else if(type == yGlobal.CostPlayerEnergy)
    {
        return this->_data->energy >= value;
    }
    else if(type == yGlobal.CostPlayerMaxEnergy)
    {
        return this->_data->maxEnergy >= value;
    }
    else if(type == yGlobal.CostPlayerGold)
    {
        return this->_data->gold >= value;
    }
    else
    {
        return false;
    }
}