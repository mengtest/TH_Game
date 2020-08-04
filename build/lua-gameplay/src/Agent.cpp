﻿#include "Agent.h"
//#include "Base.h"
#include "Pawn.h"
#include "Buff.h"
#include "Player.h"
#include "Combat.h"
#include "Singleton.h"

AgentMgr* AgentMgr::_instance;

AgentMgr* AgentMgr::instance()
{
	if (_instance == nullptr)
	{
		_instance = new AgentMgr;
#if defined(CLIENT_EXTEND)
		_instance->_agent = new CsAgent;
#elif defined(SERVER_EXTEND)
		_instance->_agent = new JsAgent;
#endif
        Singleton::instance()->store(_instance);
	}
	return _instance;
}

IAgent* AgentMgr::curAgent()
{
	return _agent;
}

AgentMgr::~AgentMgr()
{
	delete _agent;
}

void IAgent::setConfig(Config* config)
{
	_config = config;
}

const Config& IAgent::config()
{
	return *_config;
}

void IAgent::setUpdateAction(UpdateAction fun)
{
	_update = fun;
}

void IAgent::setNoticeFunction(NoticeFunction fun)
{
	_notice = fun;
}

void IAgent::msg(const std::string & str)
{
    if (_notice != nullptr)
    {
        _notice(str.c_str());
    }
}

IAgent::~IAgent()
{
	delete _config;
}

void IAgent::setRoot(std::string_view str)
{
    _root = str;
}

std::string_view IAgent::getRoot()
{
    return _root;
}

void CsAgent::update(int combatId, int playerId, int value, int type, int objectId, int targetType)
{
	
	//这种可以做成注册两个不同的函数，一个函数会返回结构体，另一个返回所有的值
	AttrStruct msg{
        combatId,
        playerId,
        objectId,
        value,
        type,
		targetType,
	};
//	msg.combatId = combatId;
//	msg.playerId = playerId;
//	msg.value = value;
//	msg.type = type;
//	msg.objectId = objectId;
	update(&msg);
}

void CsAgent::update(Pawn* pawn, int type, int value)
{
	update(pawn->getOwner()->combatId(), pawn->getOwner()->uid(), value, type, pawn->unique_id(), 1);
}

void CsAgent::update(Player* player, int type, int value)
{
	update(player->combatId(), player->uid(), value, type, player->uid(), 2);
}

void CsAgent::update(Buff* buff, int type, int value)
{
	update(buff->getMachine()->getBindRoom()->id(), -1, value, type, buff->unique_id(), 3);
}

void CsAgent::update(AttrStruct* msg)
{
	if (_update != nullptr)
	{
		_update(msg);
	}
}

void JsAgent::update(int combatId, int playerId, int value, int type, int objectId, int objType)
{

}

void JsAgent::update(Pawn* pawn, int type, int value)
{

}

void JsAgent::update(Player* player, int type, int value)
{

}

void JsAgent::update(Buff* buff, int type, int value)
{

}

void JsAgent::update(AttrStruct* msg)
{

}