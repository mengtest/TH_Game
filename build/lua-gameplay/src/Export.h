#pragma once

#include <string_view>
#include "Actions.h"

struct PlayerS;
struct PawnD;
struct BuffD;
class Combat;

namespace Export
{
	//导出给CS的一些api
	//获取到一个buff的实例对象(展示对象)
	BuffD* get_buff(int combatId, int buffId);

	//获取到一个pawn的实例对象(展示对象)
	PawnD* get_pawn(int combatId, int pawnId);

	//获取到一个玩家的实例对象(展示对象)
	PlayerS* get_player(int combatId, int uid);

	//创建一个房间，返回创建出来的战斗系统实例的id号
	int create_combat();

	//初始化核心类库
	void init(std::string_view root);

	//还需要导出两个api给cs去释放以及加载core导出部分的内存
	void load_export();

	//释放内存
	void release_export();

	void export_lua();

	//cpp端的lua栈肯定是唯一的
	void* get_lua_state();

	void entry_lua();

	void lua_init();

	void set_update_fun(UpdateAction fun);

	void set_notice_fun(NoticeFunction fun);

	Combat* get_combat(int id);
}

