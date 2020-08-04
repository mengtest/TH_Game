#include "Export2CS.h"
#include "Export.h"

void* get_buff(int combatId, int buffId)
{
	return Export::get_buff(combatId, buffId);
}

void* get_pawn(int combatId, int pawnId)
{
	return Export::get_pawn(combatId, pawnId);
}

void* get_player(int combatId, int uid)
{
	return Export::get_player(combatId, uid);
}

int create_combat()
{
	return Export::create_combat();
}

void init(string root)
{
	Export::init(root);
}

void load_export()
{
	Export::load_export();
}

void release_export()
{
	Export::release_export();
}

void* get_lua_state()
{
	return Export::get_lua_state();
}

void lua_init()
{
	Export::lua_init();
}

void set_update_action(UpdateAction fun)
{
	Export::set_update_fun(fun);
}

void set_notice_action(NoticeFunction fun)
{
	Export::set_notice_fun(fun);
}