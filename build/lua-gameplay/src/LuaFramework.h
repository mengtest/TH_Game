#pragma once

#include "3rd.h"
#include "Interfaces.h"

class Pawn;
struct Damage;

// struct ScriptBuffInfo
// {
// 	//buff文件加载之后
// 	int id;					//这里存放buff的原始id
// 	bool create;			//是否有创建函数
// 	bool invoke;			//是否有执行函数
// 	bool destroy;			//...
// 	bool interactive;		
// 	bool test;
// 	bool dispose;
// };
//
// struct RunTimeBuffInfo
// {
// 	int id;
// 	std::string_view name;
// };

//保存有当前的lua栈的对象，这个lua栈与xlua中的栈为同一个，所以xlua侧不释放lua栈，而是由这个来释放
// new sol::state ----> new xlua.LuaEnv ---> free xlua.LuaEnv ---> free sol::state 
class LuaFramework : IRelease
{
private:
	sol::state _lua;

	//这里存放当前lua框架中所有的脚本中buff的id以及其名称
	//存下这个的意义就是每次可以从这里直接找到对应的buff的原始信息
	//这个的意义就是直接做判断，目标buff中是否存在某个函数，如果不存在的话则不去调用
	// std::map<int, ScriptBuffInfo*> _scriptBuffList;

	//这里存放当前lua框架中所有的实例化脚本的uid及其相关映射
	//根据combat的id来存放所有的buff
	//每个房间中的buff的id是唯一的，所以直接存其uid，每次要取出时根据uid来合成其真正的id
	// std::map<int, std::set<std::string_view>> _instanceBuffList;

	static int id;
	
    static LuaFramework* _instance;
public:
	void free() override;
	
    LuaFramework();

	~LuaFramework();

	static LuaFramework* instance();

	sol::state& lua();

	//加载所有的用户自定义脚本文件
	void loadAll(const std::string& root);

	void exportAll();

	//执行entry.lua文件
	//这个就是用于测试的函数
	void entry();

	enum class ActionType
    {
	    attack = 1,
	    hit = 1 << 1,
	    useSkill = 1 << 2,
	    sufferSkill = 1 << 3,
	    heal = 1 << 4,
		playerHit = 1 << 5,
    };

	enum class LuaFunctionName
	{
		create = 1,
		invoke = 1 << 1,
		destroy = 1 << 2,
		interactive = 1 << 3,
		test = 1 << 4,
		dispose = 1 << 5,
	};

	//这个就是调用脚本函数的接口，但是个人感觉应该是一个房间一个，这样的话可以做到在多线程的环境中调用
	void script(int combatId, int buffId, ActionType type, Pawn* source, Pawn* target, int uid);

    //这个就是调用脚本函数的接口，但是个人感觉应该是一个房间一个，这样的话可以做到在多线程的环境中调用
    void script(int combatId, int buffId, ActionType type, Damage* damage, int uid);

	// /**
	//  * \brief 创建一个新的luabuff，
	//  * \param combatId 战斗系统id
	//  * \param buffId 要创建的buff的原始id
	//  * \param uid 创建出来的buff的uid，如果唯一的话则创建失败
	//  * \return 是否创建成功
	//  */
	// bool newLuaBuff(int combatId, int buffId, int uid);
	//
	// sol::optional<sol::table> getLuaBuff(int combatId, int uid);
	//
	// void releaseLuaBuff(int combatId, int uid);

    //直接在脚本中调用lua暴露的api来操作

	//获取当前lua框架中唯一的lua栈，主要是为了方便在xlua中使用这边的lua栈
	lua_State * getLuaStack();
};
