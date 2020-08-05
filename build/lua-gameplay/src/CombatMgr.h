#pragma once

#include <map>
#include "Interfaces.h"
#include "Player.h"

class Combat;

//现在就不给出多个玩法算了，只有一种玩法
class CombatMgr: IRelease
{
private:
	int _maxId = 0;

	std::map<int, Combat*> _allCombats;

	CombatMgr() = default;

	static CombatMgr* _instance;

	int allocId();
public:
	~CombatMgr();

	static CombatMgr* instance();

	int count();

	Player* getPlayerByUid(int uid);

	//创建一个战斗系统的实例对象
	//同时将这个实例对象返回(会将这个对象添加到列表中)
	Combat* create();

	void release(Combat* combat);

	void release(int id);

	void free() override;

	Combat* getCombat(int id);

	//个人觉得最好的方式还是每个玩家都会存储当前玩家当前所在的combat的id
	Combat* getCombatByPlayerId(int uid);
};
