#pragma once

#include "Data.h"
#include <string>
#include "Actions.h"
#include "Interfaces.h"

class Buff;
class Player;
class Pawn;
class AgentMgr;
class IAgent;
class JsAgent;
class CsAgent;

//与客户端交互信息的模块，这是一个独立的功能，没有逻辑上的先后关系
class AgentMgr : IRelease
{
private:
	static AgentMgr* _instance;

	IAgent* _agent;

	AgentMgr() = default;
public:
	static AgentMgr* instance();

	IAgent* curAgent();

	void free() override;
	
	~AgentMgr();
};

// typedef void (*UpdateAction)(AttrStruct*);
// typedef void (*NoticeFunction)(const char *);

class IAgent
{
protected:
	Config* _config = nullptr;

	UpdateAction _update = nullptr;

	NoticeFunction _notice = nullptr;

	std::string_view _root;
public:
	void setConfig(Config* config);

	const Config& config();

	Config* getConfig();

	void setRoot(std::string_view str);

	std::string_view getRoot();

	void setUpdateAction(UpdateAction fun);

	void setNoticeFunction(NoticeFunction fun);

	//战斗中有任何属性更新的同时将具体消息发送给客户端
	virtual void update(AttrStruct* msg) = 0;

	/**
	 * \brief
	 * \param combatId
	 * \param playerId
	 * \param value
	 * \param type
	 * \param objectId
	 * \param objType 0、无效 1、棋子 2、玩家 3、buff 4、战斗本身
	 */
	virtual void update(int combatId, int playerId, int value, int type, int objectId, int objType) = 0;

	virtual void update(Pawn* pawn, int type, int value) = 0;

	virtual void update(Player* player, int type, int value) = 0;

	virtual void update(Buff* buff, int type, int value) = 0;

	//还需要实现一些特殊的消息通知
	//这个就需要CS那边设置函数过来了
	virtual void msg(const std::string & str);

	virtual ~IAgent();
};

class CsAgent : public IAgent
{
public:
	/**
	 * \brief 
	 * \param combatId 
	 * \param playerId 
	 * \param value 
	 * \param type 
	 * \param objectId 
	 * \param targetType 0、无效 1、棋子 2、玩家 3、buff 4、战斗本身
	 */
	void update(int combatId, int playerId, int value, int type, int objectId, int targetType) override;

	void update(Pawn* pawn, int type, int value) override;

	void update(Player* player, int type, int value) override;

	void update(Buff* buff, int type, int value) override;

	void update(AttrStruct* msg) override;
};

class JsAgent : public IAgent
{
public:
	void update(int combatId, int playerId, int value, int type, int objectId, int objType) override;

	void update(Pawn* pawn, int type, int value) override;

	void update(Player* player, int type, int value) override;

	void update(Buff* buff, int type, int value) override;

	void update(AttrStruct* msg) override;
};