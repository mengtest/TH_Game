#include "BuffMachine.h"
#include "Combat.h"
#include "Buff.h"
#include "LuaBuff.h"
#include "Pawn.h"
#include "Player.h"
#include "Logger.h"
#include "Singleton.h"
#include "fmt/format.h"

BuffList BuffMachine::_originBuffs;
UserBuffList BuffMachine::_scriptBuffs;

bool BuffMachine::addBuff(LuaBuff* buff)
{	
	//不允许出现重复的id
	if ( _scriptBuffs.find(buff->id()) == _scriptBuffs.end() )
	{
		_scriptBuffs.insert({ buff->id(), buff });
		return true;
	}
	//出现了重复的id，则无法添加这个buff并释放对应的内存
	else
	{
		delete buff;
		//提示重复的id
		return false;
	}
}

void BuffMachine::clearScriptBuff()
{
	for (auto i : _scriptBuffs)
	{
		delete(i.second);
	}
	_scriptBuffs.clear();
}

bool BuffMachine::addBuff(sol::table tb)
{
	// luabuff实际上就是一个lua表
	// TODO
	return false;
}

bool BuffMachine::contain(int id)
{
	//即使这个id的buff刚好空缺了，也判定为有了这个buff
	if (id > 0 && id <= _originBuffs.size() || _scriptBuffs.find(id) != _scriptBuffs.end())
	{
		return true;
	}
	return false;
}

void BuffMachine::clearAllScriptBuff()
{
	for (auto i : _scriptBuffs)
	{
		delete(i.second);
	}
	_scriptBuffs.clear();
}

void BuffMachine::removeBuff(int id)
{
	if (_scriptBuffs.find(id) != _scriptBuffs.end())
	{
		//这样操作的时候还需要删除当前所有的这个对应buff的使用
		_scriptBuffs.erase(id);
	}
}

void BuffMachine::release()
{
	//只有当前房间销毁的时候才会去调用这个release函数
	//删除当前房间中所有剩余的buff对象
    for (auto p : _buffs) {
        p.second->release();
        delete(p.second);
    }
    _buffs.clear();
}

// void BuffMachine::release(Pawn* pawn)
// {
//     //	auto size = pawn->getBuffSize();
//     // 意义不明，不太用得上
//
// }

void BuffMachine::loadAll(BuffList& buffs)
{
	_originBuffs.swap(buffs);
	Singleton::instance()->store([]{
		for (auto i : _originBuffs)
		{
			delete(i);
		}
		_originBuffs.clear();
	});
}

IBuff* BuffMachine::create(Pawn* pawn, int id)
{
	IBuff* ibuff = nullptr;
	//创建buff的时候添加到当前的buff机中
	if (_originBuffs.size() >= id && id > 0 && _originBuffs.at(id - 1) != nullptr)
	{
		auto* buff = new Buff(this, pawn);
		//构建buff对象的时候不会分配data的内存空间，所以直接这样写，通过赋值的方式设置其中的data
		buff->_data = new BuffS(*_originBuffs.at(id));
		// buff->_machine = this;
		buff->_data->unique_id = allocBuffId();
		buff->_data->sourcePawn = pawn->unique_id();
		ibuff = buff;
	}
	else if(_scriptBuffs.find(id) != _scriptBuffs.end())
	{
		//如果是脚本中的buff，则直接使用clone方法来构建新的buff
		ibuff = _scriptBuffs.at(id)->clone(this, allocBuffId(), pawn);
	}
	if (ibuff == nullptr)
    {
        return nullptr;
    }
	//重置buff到最初的状态
	ibuff->reset();
	//只要能够成功创建出这个buff，这个buff就会被添加到buff机中
	//如果只创建了buff却没有挂载的话，在下次invoke的时候就会自动销毁
	if (insertBuffToList(ibuff))
	{
		return ibuff;
	}
	//插入失败，需要释放这个buff的内存
	ibuff->release();
	delete ibuff;
	return nullptr;
}

void BuffMachine::executeAll(Player* player)
{
    clog(1 ,u8"执行玩家%d身上所有的buff", player->uid());
	//执行一个玩家身上所有的buff
    auto count = player->getMaxCombatPawnNumber();
    for (int i = 0; i < count; ++i)
    {
        auto pawn = player->getCombatPawnByIndex(i);
        if (pawn == nullptr)
        {
			continue;
        }
        auto size = pawn->getBuffSize();
        for (int j = 0; j < size; ++j)
        {
            this->buffExecute(pawn->getBuffByIndex(j));
        }
    }
    clog(1 ,u8"玩家%d身上所有的buff执行完成", player->uid());
}

BuffMachine::BuffMachine(Combat* combat)
	: _combat(combat)
	, _display(new BuffD)
{

}

int BuffMachine::getRoomId()
{
	return _combat->id();
}

Combat* BuffMachine::getBindRoom()
{
	return _combat;
}

IBuff* BuffMachine::getBuffByUid(int uid)
{
	auto it = _buffs.find(uid);
	if (it != _buffs.end())
	{
		return it->second;
	}
	return nullptr;
}

// void BuffMachine::addBuffToPawn(Pawn* pawn, IBuff* buff)
// {
//
// }
//
// void BuffMachine::addBuffToPawn(Pawn* pawn, int buffId)
// {
//
// }

void BuffMachine::release(int buffUid)
{
	auto it = _buffs.find(buffUid);
	IBuff* buff = nullptr;
	if (it != _buffs.end())
	{
		buff = it->second;
		_buffs.erase(it);
		delete buff;
	}
}

//buff的release方法调用这个方法
void BuffMachine::release(IBuff* buff)
{
	if (_buffs.find(buff->unique_id()) != _buffs.end())
	{
		_buffs.erase(buff->unique_id());
		delete buff;
	}
}

BuffD* BuffMachine::toDisplay(IBuff* buff)
{
	_display->id = buff->id();
	_display->restTime = buff->restTime();
	_display->unique_id = buff->unique_id();
	_display->overlay = buff->overlay();
	return _display;
}

BuffD* BuffMachine::toDisplay(int uid)
{
	auto it = this->_buffs.find(uid);
	//查询到了这个buff
	if (it != this->_buffs.end())
	{
		auto* buff = this->_buffs[uid];
		_display->unique_id = buff->unique_id();
		_display->id = buff->id();
		_display->restTime = buff->restTime();
		_display->overlay = buff->overlay();
		return _display;
	}
	return nullptr;
}

void BuffMachine::tick()
{
    //这个其实就是当前行动的玩家上所有的buff都执行一次
    //这个不用管

}

// IBuff* BuffMachine::createBuff(int id, int sourceId, int pawnId)
// {
// 	return nullptr;
// }

bool BuffMachine::buffExecute(IBuff* buff)
{
    buff->invoke();
	return true;
}

bool BuffMachine::buffExecute(int buffId)
{
    auto it = this->_buffs.find(buffId);
    if (it != this->_buffs.end())
    {
        it->second->invoke();
    }
	return true;
}

int BuffMachine::getBuffLength(int pawnId)
{
	auto* pawn = _combat->getPawnByUid(pawnId);
	if (pawn)
	{
		return pawn->getBuffSize();
	}
	return -1;
}

int BuffMachine::getBuffLengthByType(int type)
{
    //TODO
	return -1;
}

int BuffMachine::allocBuffId()
{
	return ++_maxId;
}

int BuffMachine::insertBuffToList(IBuff* buff)
{
	if (_buffs.find(buff->unique_id()) == _buffs.end())
	{
		//将buff添加到buff机中，如果后续没有挂载这个buff，则这个buff会自动销毁
		_buffs.insert({ buff->unique_id(), buff });
		return 1;
	}
	return 0;
}

BuffMachine::~BuffMachine()
{
	for (auto buff : _buffs)
	{
		buff.second->release();
		delete buff.second;
	}
	_buffs.clear();

	if (_display != nullptr)
	{
		delete(_display);
		_display = nullptr;
	}
}