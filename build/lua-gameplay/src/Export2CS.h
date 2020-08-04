#pragma once

#include "Base.h"
#include "Actions.h"

using string = const char*;

#define public

extern "C"
{
	//导出给CS的一些api
	//获取到一个buff的实例对象(展示对象)
	public IntPtr get_buff(int combatId, int buffId);

	//获取到一个pawn的实例对象(展示对象)
	public IntPtr get_pawn(int combatId, int pawnId);

	//获取到一个玩家的实例对象(展示对象)
	public IntPtr get_player(int combatId, int uid);

	//创建一个房间，返回创建出来的战斗系统实例的id号
	//在cs端这个不一定用得上
	public int CSDLL create_combat();

	//初始化核心类库
	//由于现在的项目结构变成了cs以及cpp使用同一个lua栈，所以
	//这里应该放置的是整个dll的初始化
	//同时初始化后不会释放，直到游戏结束的时候才会释放dll的内存
	public void CSDLL init(string root);

	public void CSDLL set_update_action(UpdateAction fun);

	public void CSDLL set_notice_action(NoticeFunction fun);

	//这个应该修改为释放整个dll中的内存
	//而不是释放某个combat的内存
	public void CSDLL release_export();

	//还需要导出两个api给cs去释放以及加载core导出部分的内存
	public void CSDLL load_export();

	//cpp端的lua栈肯定是唯一的
	public IntPtr get_lua_state();

	public void CSDLL lua_init();

	public void CSDLL release_dll();

	// public void CSDLL get_combat(int cid);

	//向战斗系统中的某个房间添加玩家
}

#undef public
