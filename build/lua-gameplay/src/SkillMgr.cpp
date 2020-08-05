#include "SkillMgr.h"
#include "Pawn.h"
#include "Player.h"
#include "BuffMachine.h"
#include "Combat.h"
#include "Helper.h"
#include "Singleton.h"

SkillMgr* SkillMgr::_instance;

SkillMgr* SkillMgr::instance()
{
	if (_instance == nullptr)
	{
		_instance = new SkillMgr;
        Singleton::instance()->store(_instance);
	}
	return _instance;
}

void SkillMgr::loadAll(SkillList& skills)
{
	//释放当前整个列表里面的元素，并且将清理列表
	for (auto skill : skills)
	{
        delete skill;
	}
    _skills.clear();
	_skills.swap(skills);
}

bool SkillMgr::contain(int id)
{
	if (id <= _skills.size() && id > 0)
	{
		return _skills.at(id) != nullptr;
	}
	return false;
}

Skill* SkillMgr::require(int id)
{
	if (id <= _skills.size() && id > 0)
	{
		return _skills.at(id);
	}
	return nullptr;
}

bool SkillMgr::execute(int skillId, Pawn* self, Pawn* target)
{
	auto* skill = require(skillId);
	//如果获取不到技能，则执行错误
	if (skill == nullptr)
	{
		return false;
	}

	//技能消耗相关的判定
	//如果技能需要消耗能量的话，需要去读取棋子所属玩家的能量属性
	// 1、HP 
    // 2、MP
    // 3、能量(玩家拥有的一项属性)
	if (skill->costType == 3)
    {
        //不满足条件
        if (!self->getOwner()->check(yGlobal.CostPlayerEnergy, skill->cost))
        {
            return false;
        }
        //满足条件的话，则产生对应的消耗
        self->getOwner()->opEnergy(-skill->cost);
        // self->getOwner()->opEnergy(-skill->cost);
    }
	else
    {
	    //可以执行技能
	    if(!self->check(costTypeTranslate(false, skill->costType), skill->cost))
        {
            return false;
        }
        self->cost(costTypeTranslate(false, skill->costType), skill->cost);
    }

    //  0、自己 1、单个队友 2、单个队友不包含自己 3、单个敌人 4、所有人 5、所有人不包含自己
    //  6、自己玩家 7、敌方玩家 8、随机的单个敌方棋子 9、随机的单个友方棋子 10、随机的玩家 11、所有友军 12、所有敌军
    //  TODO 以后再做
    //现在所有的技能都可以且只能选择一个目标
	switch (skill->targetType)
    {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        default:;
    }

	//伤害的判定
    Damage damage{ false, skill->damage, skill->damageType,self, target };
	if (skill->damageType)
	{
		if (skill->damageType == 4)
        {
		    damage.isHeal = true;
		    target->heal(&damage);
        }
		else
        {
            target->hit(&damage);
        }
	}
	
	//以及添加哪些buff的操作
    for (auto id : skill->buffs)
    {
        auto* buff = self->getOwner()->getCombat()->getMachine()->create(self, id);
        target->mount(buff);
    }
	return true;
}

bool SkillMgr::executeWithoutCost(int skillId, Pawn* self, Pawn* target)
{
    auto* skill = require(skillId);
    if (skill == nullptr)
    {
        return false;
    }
    Damage damage{false, skill->damage, skill->damage, skill->damageType, skill->damageType, self, target};
    if (skill->damageType)
    {
        if (skill->damageType == 4)
        {
            damage.isHeal = true;
            target->heal(&damage);
        }
        else
        {
            target->hit(&damage);
        }
    }
    //以及添加哪些buff的操作
    for (auto id : skill->buffs)
    {
        auto* buff = self->getOwner()->getCombat()->getMachine()->create(self, id);
        target->mount(buff);
    }
    return true;
}

SkillMgr::~SkillMgr()
{
    for (auto i : _skills)
    {
        delete(i);
    }
    _skills.clear();
}
