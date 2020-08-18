#include "Pawn.h"
#include "Buff.h"
#include "Player.h"
#include "Agent.h"
#include "Logger.h"
#include "LuaFramework.h"
#include "Combat.h"
#include "SkillMgr.h"
#include "fmt/format.h"

Pawn::~Pawn()
{
	// ylog("free pawn %d", _data->unique_id);
    delete(_data);
    delete(_display);
}

PawnS* Pawn::data()
{
	return _data;
}

PawnD* Pawn::toDisplay()
{
	if (nullptr == _display)
	{
		_display = new PawnD;
	}
	_display->unique_id = _data->unique_id;
	_display->atk = _data->atk;
	_display->def = _data->def;
	_display->hp = _data->hp;
	_display->id = _data->id;
	_display->matk = _data->matk;
	_display->mdef = _data->mdef;
	_display->mp = _data->mp;
	_display->type = _data->type;
	return _display;
}

Pawn* Pawn::create(PawnS* data, int uid)
{
	auto* pawn = new Pawn;
	pawn->_data = new PawnS(*data);
	pawn->_display = nullptr;
	pawn->_player = nullptr;
	pawn->_data->unique_id = uid;
	ylog("new pawn {0}", uid);
	return pawn;
}

int Pawn::id()
{
	return _data->id;
}

int Pawn::unique_id()
{
	return _data->unique_id;
}

int Pawn::hp()
{
	return _data->hp;
}

int Pawn::mp()
{
	return _data->mp;
}

int Pawn::matk()
{
	return _data->matk;
}

int Pawn::atk()
{
	return _data->atk;
}

int Pawn::def()
{
	return _data->def;
}

int Pawn::mdef()
{
	return _data->mdef;
}

int Pawn::type()
{
	return _data->type;
}

size_t Pawn::getBuffSize()
{
	return _buffs.size();
}

IBuff* Pawn::getBuffByIndex(int index)
{
	if (_buffs.size() > index && index >= 0)
	{
        return _buffs[index];
	}
	return nullptr;
}

IBuff* Pawn::getBuffById(int id)
{
	for (auto* buff : _buffs)
	{
		if (buff->id() == id)
		{
			return buff;
		}
	}
	return nullptr;
}

IBuff* Pawn::getBuffByUid(int uid)
{
	for (auto* buff : _buffs)
	{
		if (buff->unique_id() == uid)
		{
			return buff;
		}
	}
	return nullptr;
}

bool Pawn::containBuff(int buffId)
{
	for (auto buff : _buffs)
	{
		if (buff->unique_id() == buffId)
		{
			return true;
		}
	}
	return false;
}

bool Pawn::hasSkill(int id)
{
	for (auto sk : _data->skills)
	{
		if (id == sk)
		{
			return true;
		}
	}
	return false;
}

Player* Pawn::getOwner()
{
	return _player;
}

void Pawn::addTo(Player* player)
{
	_player = player;
	//这里应该还有很多操作
}

int Pawn::posType()
{
	return _data->posType;
}

int Pawn::pos()
{
	return _data->pos;
}

bool Pawn::moveToHand()
{
	auto curType = this->_data->posType;
	if (curType == 2)
	{
		return false;
	}

	if (this->_player->dissociatePawn(this))
	{
		this->_data->posType = 2;
		if (this->_player->relate(this))
		{
			//成功的设置了棋子到新的位置
			//添加到手牌中的时候，有一些信息需要修改
			// TODO 还有一部分功能没有实现
			
			//卡牌可以从卡池中移动到手中
			if (curType == 1)
			{
				AgentMgr::instance()->curAgent()->update(
					_player, yGlobal.PlayerAttrDeckCardsToHand, unique_id()
				);
				return true;
			}
			else if (curType == 2)
			{
				// return false;
			}
			//卡牌可以从棋盘中移动到手牌中
			//这个就相当于收回卡牌，感觉暂时还是不做好一点
			// TODO
			else if (curType == 3)
			{
				//还需要在当前玩家的内存中做出相应的改变
				AgentMgr::instance()->curAgent()->update(
					_player, yGlobal.PlayerAttrCombatCardsToHand, unique_id()
				);
				return true;
			}
			else
			{
				// return false;
			}
		}
	}
	//如果设置失败了，则将卡牌所在的位置还原
	this->_data->posType = curType;
	return false;
}

bool Pawn::moveToDeck()
{
	auto curType = this->_data->posType;
	if (curType == 1 || curType == 2)
	{
		return false;
	}

	if (this->_player->dissociatePawn(this))
	{
		this->_data->posType = 1;
		if (this->_player->relate(this))
		{
			//成功的设置了棋子到新的位置
			//添加到手牌中的时候，有一些信息需要修改
			// TODO 还有一部分功能没有实现

			if (curType == 1)
			{
				// AgentMgr::instance()->curAgent()->update(
				// 	_player, yGlobal.PlayerAttrDeckCardsToHand, unique_id()
				// );
				// return true;
			}
			//如果要做这个功能的话，就相当于要实现出售的功能
			else if (curType == 2)
			{
				// return false;
			}
			//卡牌可以从棋盘中移动到手牌中
			else if (curType == 3)
			{
				//还需要在当前玩家的内存中做出相应的改变
				AgentMgr::instance()->curAgent()->update(
					_player, yGlobal.PlayerAttrCombatCardToDeck, unique_id()
				);
				return true;
			}
			else
			{
				// return false;
			}
		}
	}
	//如果设置失败了，则将卡牌所在的位置还原
	this->_data->posType = curType;
	return false;

	
	// //回到卡池的时候需要做出一些处理，比如说取消所有的buff
 //    // TODO 还有一部分功能没有实现
 //
	// if (this->_data->posType == 1)
	// {
	// 	return false;
	// }
	// //如果要实现这个功能的话，就相当于是出售卡牌了
	// else if (this->_data->posType == 2)
	// {
	// 	return false;
	// }
	// //棋子死亡后回到卡池中
	// else if (this->_data->posType == 3)
	// {
	// 	//还需要在当前玩家的内存中做出相应的改变
	// 	AgentMgr::instance()->curAgent()->update(
	// 		_player, yGlobal.PlayerAttrCombatCardToDeck, unique_id()
	// 	);
	// }
	// else
	// {
	// 	return false;
	// }
	// this->_data->posType = 1;
	// return true;
}

bool Pawn::moveToPanel(int pos)
{
	auto curType = this->_data->posType;
	auto oriPos = this->_data->pos;
	if (curType == 1 || curType == 3)
	{
		return false;
	}

	//取消卡牌与玩家的关联关系
	if (this->_player->dissociatePawn(this))
	{
		//如果取消成功了，则
		this->_data->posType = 3;
		this->_data->pos = pos;
		if (this->_player->relate(this))
		{
			//成功的设置了棋子到新的位置
			//添加到手牌中的时候，有一些信息需要修改
			// TODO 还有一部分功能没有实现

			//卡牌可以从卡池中移动到手中
			if (curType == 1)
			{
				// AgentMgr::instance()->curAgent()->update(
				// 	_player, yGlobal.PlayerAttrDeckCardsToHand, unique_id()
				// );
				// return true;
			}
			else if (curType == 2)
			{
				// return false;
				// AgentMgr::instance()->curAgent()->update(
				// 	_player, yGlobal.PlayerAttrHandCardsToCombat, unique_id()
				// );
				AgentMgr::instance()->curAgent()->update(_player->combatId(), _player->uid(), pos, yGlobal.PlayerAttrHandCardsToCombat
					, unique_id(), 1);
				return true;
			}
			else if (curType == 3)
			{
				// //还需要在当前玩家的内存中做出相应的改变
				// AgentMgr::instance()->curAgent()->update(
				// 	_player, yGlobal.PlayerAttrCombatCardsToHand, unique_id()
				// );
				// return true;
			}
			else
			{
				// return false;
			}
		}
	}
	//如果设置失败了，则将卡牌所在的位置还原
	this->_data->posType = curType;
	this->_data->pos = oriPos;
	return false;
	
	// //实例化的时候，有一些信息需要初始化
 //    // TODO 还有一部分功能没有实现
 //
	// // 卡牌无法从卡池中直接移动到棋盘中
	// if (this->_data->posType == 1)
	// {
	// 	return false;
	// }
	// else if (this->_data->posType == 2)
	// {
	// 	AgentMgr::instance()->curAgent()->update(
	// 		_player, yGlobal.PlayerAttrHandCardsToCombat, unique_id()
	// 	);
	// }
	// // 卡牌无法从卡池中直接移动到棋盘中
	// else if (this->_data->posType == 3)
	// {
	// 	// //还需要在当前玩家的内存中做出相应的改变
	// 	// AgentMgr::instance()->curAgent()->update(
	// 	// 	_player, yGlobal.PlayerAttrCombatCardsToHand, unique_id()
	// 	// );
	// 	return false;
	// }
	// else
	// {
	//     ylog("战斗中的棋子无法交换位置");
	// 	return false;
	// }
	// this->_data->posType = 3;
	// clog(1, "玩家召唤了棋子%d", unique_id());
	// return true;
}

int Pawn::mount(IBuff* buff)
{
	//如果当前buff的长度超过了最大值，则挂载失败
	if (_buffs.size() >= PAWN_BUFF_LENGTH)
	{
		return 0;
	}

	//能否添加buff的测试
	for (auto* buf : _buffs)
	{
		//如果buf为空，则跳出循环(还没确定buff的存储方式)
		if (buf == nullptr)
		{
			continue;
		}

		//不可能出现拥有同uid的buff，挂载失败
		if (buf->unique_id() == buff->unique_id())
		{
			return 0;
		}

		//最大叠加数量为1的话，表示不可叠加
		if (buff->maxOverlay() == 1)
		{
			//不可叠加的话，同id的buff是无法添加的
			if (buf->id() == buff->id())
			{
				return 0;
			}
		}
		//可以叠加的话，则直接调用叠加的逻辑并返回成功
		else
		{
			buf->callOverlay();
			return 1;
		}
		
		//有任何一个buff没有通过测试，无法添加这个buff
		if (!buf->test(buff))
		{
			return 0;
		}
	}

	//正式地调用create
	buff->create(this);

	//可以添加buff的情况下
	//与当前棋子身上所有的buff全部交互一遍
	for (auto* buf : _buffs)
	{
		if (buf == nullptr)
		{
			continue;
		}
		//通知当前棋子身上所有的buff有一个新的buff被挂载上来
		//buff刚刚挂载到棋子上的时候不会触发invoke，只会触发交互函数
		buf->onInteractive(buff->getSource(), this, buff, 1);
	}

	return 1;
}

int Pawn::unmount(IBuff* buff)
{
	//只能取消挂在当前棋子身上的buff
	if (buff->getOwner()->unique_id() == _data->unique_id)
	{
		//从自己身上移除这个buff
		auto it = std::find_if(_buffs.begin(), _buffs.end(), [buff](IBuff* l)
		{
			return l->unique_id() == buff->unique_id();
		});
		if (it != _buffs.end())
		{
			_buffs.erase(it);
			buff->release();
			return 1;
		}
	}
	return 0;
}

int Pawn::unmount(int buffId)
{
	//只能取消挂在当前棋子身上的buff
	if (buffId == _data->unique_id)
	{
		//从自己身上移除这个buff
		auto it = std::find_if(_buffs.begin(), _buffs.end(), [buffId](IBuff* l)
		{
			return l->unique_id() == buffId;
		});
		if (it != _buffs.end())
		{
			auto* buff = *it;
			_buffs.erase(it);
			buff->release();
			return 1;
		}
	}
	return 0;
}

bool Pawn::hit(Damage* damage)
{
    clog(1, "id为{0}的棋子受到了id为{1}的棋子的伤害", this->unique_id(), damage->source->unique_id());
	//可能会有各种特殊buff的触发
	//需要在脚本中进行一些特殊处理
	//触发一个特殊事件
    for (auto buff: this->_buffs)
    {
        LuaFramework::instance()->script(this->_player->getCombat()->id(),buff->id(),
            LuaFramework::ActionType::hit, damage->source, this, buff->unique_id());
    }

	return true;
}

bool Pawn::attack(Pawn* target)
{
    ylog("pawn {0} attack pawn {1}", this->unique_id(), target->unique_id());
    //由于这里其实是会产生各种触发的，所以需要调用一个lua脚本中的函数
    Damage damage{false, this->atk(), 1, this, target};
    for (auto buff: this->_buffs)
    {
        LuaFramework::instance()->script(this->_player->getCombat()->id(),buff->id(),
            LuaFramework::ActionType::attack, &damage, buff->unique_id());
    }
    target->hit(&damage);
	return true;
}

bool Pawn::attack(Player* player)
{
    ylog("pawn {0} attack player {1}", this->unique_id(), player->uid());
    //攻击玩家的时候不会触发任何特殊函数
    player->hit(this->atk());
	return true;
}

bool Pawn::useSkill(Pawn* target, int skillId)
{
    if (SkillMgr::instance()->contain(skillId))
    {
        //当self的不满足技能的使用条件时，则返回false，但是这里一定会返回true
        if(!SkillMgr::instance()->executeWithoutCost(skillId, this, target))
        {
            ylog("棋子{0}执行技能{1}失败", this->_data->unique_id, skillId);
            return false;
        }
        clog(this->_player->getCombat()->id(), "棋子{0}对棋子{1}使用技能{2}", this->_data->unique_id, target->unique_id(), skillId);
    }
    else
    {
        ylog("skill {0} not exist", skillId);
        return false;
    }

    for (auto buff: this->_buffs)
    {
        LuaFramework::instance()->script(this->_player->getCombat()->id(), buff->id(),
            LuaFramework::ActionType::useSkill, this, target, buff->unique_id());
    }
    return true;
}

bool Pawn::useSkillWithCost(Pawn *target, int skillId)
{
    if (SkillMgr::instance()->contain(skillId))
    {
        if(!SkillMgr::instance()->execute(skillId, this, target))
        {
            ylog("棋子{0}执行技能{1}失败", this->_data->unique_id, skillId);
            return false;
        }
        clog(this->_player->getCombat()->id(), "棋子{0}对棋子{1}使用技能{2}", this->_data->unique_id, target->unique_id(), skillId);
    }
    else
    {
        ylog("skill {0} not exist", skillId);
        return false;
    }

    for (auto buff: this->_buffs)
    {
        LuaFramework::instance()->script(this->_player->getCombat()->id(), buff->id(),
            LuaFramework::ActionType::useSkill, this, target, buff->unique_id());
    }
    return true;
}

bool Pawn::sufferSkill(Pawn* source, int skillId)
{
    for (auto buff: this->_buffs)
    {
        LuaFramework::instance()->script(this->_player->getCombat()->id(),buff->id(),
            LuaFramework::ActionType::sufferSkill, source, this, buff->unique_id());
    }
	return true;
}

int Pawn::heal(Damage* damage)
{
    for (auto buff: this->_buffs)
    {
        //这里假如说能够取得到是谁为当前的玩家恢复了生命值的话，则可以做出反馈的动作，比如目标玩家恢复这个值的一半的生命值
        LuaFramework::instance()->script(this->_player->getCombat()->id(),buff->id(),
             LuaFramework::ActionType::heal, damage, buff->unique_id());
    }

    //生命值回复的数值必定为非负整数
    if (damage->curValue >= 0)
    {
        this->_data->hp += damage->curValue;
    }

    return this->_data->hp;
}

void Pawn::reset()
{
    //重置当前棋子的所有属性
    //棋子是召唤的时候重置属性还是回到卡池的时候重置属性？
}

bool Pawn::dead(int priority)
{
    //如何去检测当前棋子是否会死亡(比如说要做dota里面戴泽的薄葬的效果)
    moveToDeck();
	return true;
}

int Pawn::cost(int type, int value)
{
    if (type == yGlobal.CostPawnHp)
    {
        this->_data->hp -= value;
        AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
        if (this->_data->hp <= 0)
        {
            //棋子死亡
            this->dead();
        }
        return this->_data->hp;
    }
    else if(type == yGlobal.CostPawnMp)
    {
        this->_data->mp -= value;
        if (this->_data->mp < 0)
        {
            this->_data->mp = 0;
        }
        AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
        return this->_data->mp;
    }
//    else if(type == yGlobal.CostPawnAtk)
//    {
//        //攻击力可以为负值
//        this->_data->atk -= value;
//        //负值是一个面板数值，但是实际上最低为0
//        return this->_data->atk;
//    }
//    else if(type == yGlobal.CostPawnDef)
//    {
//        this->_data->def -= value;
//        return _data->def;
//    }
//    else if(type == yGlobal.CostPawnMatk)
//    {
//        this->_data->matk -= value;
//        return _data->matk;
//    }
//    else if(type == yGlobal.CostPawnMdef)
//    {
//        this->_data->mdef -= value;
//        return _data->mdef;
//    }
    else
    {
        return -1;
    }
}

bool Pawn::check(int type, int value)
{
    if (type == yGlobal.CostPawnHp)
    {
        return this->_data->hp >= value;
    }
    else if(type == yGlobal.CostPawnMp)
    {
        return this->_data->mp >= value;
    }
//    else if(type == yGlobal.CostPawnAtk)
//    {
//        return this->_data->atk >= value;
//    }
//    else if(type == yGlobal.CostPawnDef)
//    {
//        return this->_data->def >= value;
//    }
//    else if(type == yGlobal.CostPawnMatk)
//    {
//        return this->_data->matk >= value;
//    }
//    else if(type == yGlobal.CostPawnMdef)
//    {
//        return this->_data->mdef >= value;
//    }
    else
    {
        return false;
    }
}

bool Pawn::alive()
{
    //在场地上，并且血量大于0的话就表示当前的棋子处于存活的状态
    //血量为0的时候，无论如何这个棋子都会死亡
    return this->posType() == 3 && this->hp() > 0;
}

void Pawn::release()
{
	//释放当前棋子中所有buff
    for (auto* buff: _buffs)
    {
        buff->release();
        delete buff;
    }
    _buffs.clear();
	//释放当前棋子相关的内存
    //PawnMgr::release(this);
}

bool Pawn::checkAction(int action)
{
    //如何检测当前棋子是否能够执行某个操作？
    //目前暂时只有1、攻击 2、使用技能
    //暂时先不做这一块的功能
    // TODO
	
	return true;
}

// void Pawn::plus(int type, int value)
// {
// 	if (type == yGlobal.EventPawnAttrHp)
// 	{
// 		if (value > 0)
// 		{
// 			this->_data->hp += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMp)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mp += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrAtk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->atk += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrDef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->def += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMatk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->matk += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMdef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mdef += value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
// 		}
// 	}
// 	// else if (type == yGlobal.EventPawnAttrMp)
// 	// {
// 	//
// 	// }
// 	else
// 	{
//
// 	}
// 	
// 	// switch (type)
// 	// {
// 	// case 1:
// 	// {
// 	// 	if (value > 0)
// 	// 	{
// 	// 		this->_data->hp += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 2:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->mp += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 3:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->atk += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 4:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->def += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 5:
// 	// {
// 	// 	// if (value >= 0)
// 	// 	// {
// 	// 	// 	this->_data->def += value;
// 	// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.PlayerAttrGold, this->_data->hp);
// 	// 	// }
// 	// 	break;
// 	// }
// 	// case 6:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->matk += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 7:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->mdef += value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
// 	// 	}
// 	// 	break;
// 	// }
// 	// default:;
// 	// }
// }
//
// void Pawn::minus(int type, int value)
// {
// 	if (type == yGlobal.EventPawnAttrHp)
// 	{
// 		if (value > 0)
// 		{
// 			this->_data->hp -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMp)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mp -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrAtk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->atk -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrDef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->def -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
// 		}
//
// 	}
// 	else if (type == yGlobal.EventPawnAttrMatk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->matk -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMdef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mdef -= value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
// 		}
// 	}
// 	// else if (type == yGlobal.EventPawnAttrMp)
// 	// {
// 	//
// 	// }
// 	else
// 	{
//
// 	}
// 	
// 	// switch (type)
// 	// {
// 	// case 1:
// 	// {
// 	// 	if (value > 0)
// 	// 	{
// 	// 		this->_data->hp -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 2:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->mp -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 3:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->atk -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 4:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->def -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 5:
// 	// {
// 	// 	// if (value >= 0)
// 	// 	// {
// 	// 	// 	this->_data->def += value;
// 	// 	// 	AgentMgr::instance()->curAgent()->update(this, yGlobal.PlayerAttrGold, this->_data->hp);
// 	// 	// }
// 	// 	break;
// 	// }
// 	// case 6:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->matk -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
// 	// 	}
// 	// 	break;
// 	// }
// 	// case 7:
// 	// {
// 	// 	if (value >= 0)
// 	// 	{
// 	// 		this->_data->mdef -= value;
// 	// 		AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
// 	// 	}
// 	// 	break;
// 	// }
// 	// default:;
// 	// }
// }

// void Pawn::to(int type, int value)
// {
// 	if (type == yGlobal.EventPawnAttrHp)
// 	{
// 		if (value > 0)
// 		{
// 			this->_data->hp = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
// 		}
// 	}
// 	else if(type == yGlobal.EventPawnAttrMp)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mp = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrAtk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->atk = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrDef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->def = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
// 		}
//
// 	}
// 	else if (type == yGlobal.EventPawnAttrMatk)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->matk = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
// 		}
// 	}
// 	else if (type == yGlobal.EventPawnAttrMdef)
// 	{
// 		if (value >= 0)
// 		{
// 			this->_data->mdef = value;
// 			AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
// 		}
// 	}
// 	// else if (type == yGlobal.EventPawnAttrMp)
// 	// {
// 	//
// 	// }
// 	else
// 	{
// 		
// 	}
// 	
//     // switch (type)
//     // {
//     //     case 1:
//     //     {
//     //         if (value > 0)
//     //         {
//     //             this->_data->hp = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
//     //         }
//     //         break;
//     //     }
//     //     case 2:
//     //     {
//     //         if (value >= 0)
//     //         {
//     //             this->_data->mp = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
//     //         }
//     //         break;
//     //     }
//     //     case 3:
//     //     {
//     //         if (value >= 0)
//     //         {
//     //             this->_data->atk = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
//     //         }
//     //         break;
//     //     }
//     //     case 4:
//     //     {
//     //         if (value >= 0)
//     //         {
//     //             this->_data->def = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
//     //         }
//     //         break;
//     //     }
//     //     case 5:
//     //     {
//     //         // if (value >= 0)
//     //         // {
//     //         // 	this->_data->def += value;
//     //         // 	AgentMgr::instance()->curAgent()->update(this, yGlobal.PlayerAttrGold, this->_data->hp);
//     //         // }
//     //         break;
//     //     }
//     //     case 6:
//     //     {
//     //         if (value >= 0)
//     //         {
//     //             this->_data->matk = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
//     //         }
//     //         break;
//     //     }
//     //     case 7:
//     //     {
//     //         if (value >= 0)
//     //         {
//     //             this->_data->mdef = value;
//     //             AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
//     //         }
//     //         break;
//     //     }
//     //     default:;
//     // }
// }

void Pawn::opHp(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->hp += value;
	if (value > 0 && this->_data->hp < 0)
	{
		this->_data->hp = 0;
	}
	// TODO
	// 如果棋子的血量归零了，应该有些什么处理？
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrHp, this->_data->hp);
}

void Pawn::opMp(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->mp += value;
	//魔法最低为0
	if (value > 0 && this->_data->mp < 0)
	{
		this->_data->mp = 0;
	}
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMp, this->_data->mp);
}

// 是否要增加攻击力为负数相关的设定
void Pawn::opAtk(int value)
{
	// 如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	// 如果攻击力为负数的话则攻击敌人不会造成伤害(并不会给人回血)
	this->_data->atk += value;
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrAtk, this->_data->atk);
}

void Pawn::opDef(int value)
{
	// 如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	// 如果防御力为负值的话，受到伤害时会有相应的增加
	this->_data->def += value;
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrDef, this->_data->def);
}

void Pawn::opMatk(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->matk += value;
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMatk, this->_data->matk);
}

void Pawn::opMdef(int value)
{
	//如果值为0的话，则没有任何操作
	if (value == 0)
	{
		return;
	}
	this->_data->mdef += value;
	AgentMgr::instance()->curAgent()->update(this, yGlobal.EventPawnAttrMdef, this->_data->mdef);
}