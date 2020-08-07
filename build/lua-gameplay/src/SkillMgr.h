#pragma once

#include <vector>
#include "Skill.h"

class Pawn;
class Player;
using SkillList = std::vector<Skill*>;

//没有导出的类，如果要使用技能的话，直接利用pawn来完成
class SkillMgr
{
private:
	static SkillMgr* _instance;

	SkillList _skills;

	SkillMgr() = default;
public:
	static SkillMgr* instance();

	void loadAll(SkillList& skills);

	bool contain(int id);

	Skill* require(int id);

	/**
	 * \brief 执行技能,会产生消耗，主要是方便懒人操作，在脚本当中可以通过调用一个函数来完成整个技能的执行操作
	 * \param skillId 目标技能的id 
	 * \param self 使用这个技能的
	 * \param target 
	 * \return 
	 */
	bool execute(int skillId, Pawn* self, Pawn* target);

	/**
	 * \brief 执行技能，但是不会产生任何消耗，可以完成一些自定义的功能，例如使用技能无消耗，或者消耗加倍等功能
	 * \param skillId 目标技能的id
	 * \param self 使用这个技能的
	 * \param target
	 * \return 
	 */
	bool executeWithoutCost(int skillId, Pawn* self, Pawn* target);

	~SkillMgr();
};
