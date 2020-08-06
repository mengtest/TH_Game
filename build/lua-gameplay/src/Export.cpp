#include "Export.h"
#include "Data.h"
#include "LuaFramework.h"
#include "CombatMgr.h"
#include "Combat.h"
#include "Pawn.h"
#include "BuffMachine.h"
#include "Loader.h"
#include "Agent.h"
#include "Singleton.h"
#include <filesystem>

namespace Export
{
    BuffD* get_buff(int combatId, int buffId)
    {
        auto * combat = CombatMgr::instance()->getCombat(combatId);
        if (combat == nullptr)
        {
            return nullptr;
        }
        return combat->getMachine()->getBuffByUid(buffId)->toDisplay();
    }

    PawnD* get_pawn(int combatId, int pawnId)
    {
        auto * combat = CombatMgr::instance()->getCombat(combatId);
        if (combat == nullptr)
        {
            return nullptr;
        }
        return combat->getPawnByUid(pawnId)->toDisplay();
    }

    PlayerS* get_player(int combatId, int uid)
    {
        auto * combat = CombatMgr::instance()->getCombat(combatId);
        if (combat == nullptr)
        {
            return nullptr;
        }
        return combat->getPlayer(uid)->data();
    }

    int create_combat()
    {
        auto combat = CombatMgr::instance()->create();
        if (combat == nullptr)
        {
            return -1;
        }
        return combat->id();
    }

    void init(std::string_view root, lua_State* L)
    {
        AgentMgr::instance()->curAgent()->setRoot(root);

    	//启动的时候就读取所有的配置表
        std::string scriptRoot = root.data();
        Loader::loadConfig(scriptRoot + "/jsons/global.json");
        Loader::loadAllPawns(scriptRoot + "/jsons/cards.json");
        Loader::loadAllSkills(scriptRoot + "/jsons/skills.json");
        Loader::loadAllBuffs(scriptRoot + "/jsons/buffs.json");

    	//再导出所有的lua导出api
        Export::export_lua(L);

    	//这个是加载所有的用户自定义lua脚本
        Export::lua_init();
    }

    void load_export()
    {
    	
    }

    void release_export()
    {
        CombatMgr::instance()->release(1);
    }

    void release_all()
    {
        Singleton::instance()->release();
    }

    void export_lua(lua_State* L)
    {
        //这个是导出所有的luaapi
        LuaFramework::constructor(L)->exportAll();
    }

    void* get_lua_state()
    {
        return LuaFramework::instance()->getLuaStack();
    }

    void entry_lua()
    {
        LuaFramework::instance()->entry();
    }

    void lua_init()
    {
        //如果没有设置跟目录，则直接退出
        if (AgentMgr::instance()->curAgent()->getRoot().empty())
        {
            return;
        }

        //加载所有的脚本文件
        LuaFramework::instance()->loadAll(AgentMgr::instance()->curAgent()->getRoot().data());
    }

    Combat* get_combat(int id)
	{
        return CombatMgr::instance()->getCombat(id);
    }

    void set_update_fun(UpdateAction fun)
    {
        AgentMgr::instance()->curAgent()->setUpdateAction(fun);
    }

	void set_notice_fun(NoticeFunction fun)
    {
        AgentMgr::instance()->curAgent()->setNoticeFunction(fun);
    }
}

