#include "CombatMgr.h"
#include "Combat.h"
#include "Logger.h"
#include "Singleton.h"
#include "fmt/format.h"

CombatMgr* CombatMgr::_instance;

int CombatMgr::allocId()
{
	return ++_maxId;
}

CombatMgr::~CombatMgr()
{
	//释放所有的combat的实例对象
	for (auto v : _allCombats)
    {
        v.second->release();
        delete(v.second);
    }
	_allCombats.clear();
}

CombatMgr* CombatMgr::instance()
{
	if (nullptr == _instance)
	{
		_instance = new CombatMgr;
        Singleton::instance()->store(_instance);
	}
	return _instance;
}

Combat* CombatMgr::create()
{
	auto* combat = new Combat(allocId());
	if (_allCombats.find(combat->id()) == _allCombats.end())
	{
		_allCombats.insert({ combat->id(), combat });
		ylog("创建了一个新的战斗系统实例，id为{0}，当前正在进行的比赛数量为{1}", combat->id(), this->_allCombats.size());
	}
	else
	{
		//出现重复的id了，可以抛出异常
		ylog("重复id{0}的战斗系统，程序异常", combat->id());
	}
	return combat;
}

void CombatMgr::release(Combat* combat)
{
	auto id = combat->id();
	combat->release();
	_allCombats.erase(combat->id());
	delete combat;
	ylog("销毁了一个战斗系统实例，id为{0}，当前正在进行的比赛数量为{1}", id, this->_allCombats.size());
}

void CombatMgr::release(int id)
{
	auto it = _allCombats.find(id);
	if (it != _allCombats.end())
	{
		it->second->release();
		delete (it->second);
		_allCombats.erase(id);
		ylog("销毁了一个战斗系统实例，id为{0}，当前正在进行的比赛数量为{1}", id, this->_allCombats.size());
	}
}

void CombatMgr::free()
{
	delete _instance;
	_instance = nullptr;
}

Combat* CombatMgr::getCombat(int id)
{
	auto it = _allCombats.find(id);
	if (it != _allCombats.end())
	{
		return it->second;
	}
	return nullptr;
}

Combat* CombatMgr::getCombatByPlayerId(int uid)
{
	for (auto&& combatPair : _allCombats)
	{
		auto combat = combatPair.second;
		if (combat->hasPlayer(uid))
		{
			return combat;
		}
	}
	return nullptr;
}

int CombatMgr::count()
{
	return _allCombats.size();
}

Player* CombatMgr::getPlayerByUid(int uid)
{
	for (const auto & combatPair : _allCombats)
	{
		auto* player = combatPair.second->getPlayer(uid);
		if (player != nullptr)
		{
			return player;
		}
	}
	return nullptr;
}
