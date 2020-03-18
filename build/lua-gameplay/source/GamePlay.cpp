#include "GamePlay.h"
#include "Test.h"

#include "lua.hpp"
#include "i64lib.h"

GamePlay::GamePlay(/* args */)
{

}

GamePlay::~GamePlay()
{

}

double GamePlay::call(double x, double y)
{
    auto test = new Test();
    auto res = test->add(x, y);
    delete test;
    return res;
}

const char * GamePlay::func(const std::string& name)
{
    char buffer[128] = {};
    sprintf_s(buffer, "你好啊 ,%s",name.c_str());
    return buffer;
}

static int null = -1;

static void setfuncs(lua_State* L, const luaL_Reg *funcs)
{
#if LUA_VERSION_NUM >= 502 // LUA 5.2 or above
	luaL_setfuncs(L, funcs, 0);
#else
	luaL_register(L, NULL, funcs);
#endif
}

static int add(lua_State* L)
{
	int l = luaL_checknumber(L, 1);
	int r = luaL_checknumber(L, 2);

	int top = lua_gettop(L);

	lua_settop(L, top);
	
    GamePlay gp;
    
	lua_pushnumber(L, gp.call(l, r));
	return 1;
}

static int hello(lua_State * L)
{
    size_t size = 0;
    auto s = luaL_checklstring(L, 1, &size);

    int top = lua_gettop(L);
    lua_settop(L, top);
    GamePlay gp;
    auto str = gp.func(s);
    lua_pushlstring(L, str, strlen(str));

    return 1;
}


static const luaL_Reg methods[] = {
    {"add" , add},
    {"hello", hello},


	{ NULL, NULL }          //一定要这个，不然会无法运行
};


extern "C" {
	LUALIB_API int luaopen_gameplay(lua_State* L)
	{
		lua_newtable(L); // [rapidjson]

		setfuncs(L, methods); // [rapidjson]

		lua_pushliteral(L, "gameplay"); // [rapidjson, name]
		lua_setfield(L, -2, "_NAME"); // [rapidjson]

		lua_pushliteral(L, "1.0.0"); // [rapidjson, version]
		lua_setfield(L, -2, "_VERSION"); // [rapidjson]

		lua_getfield(L, -1, "null"); // [rapidjson, json.null]
		null = luaL_ref(L, LUA_REGISTRYINDEX); // [rapidjson]

		return 1;
	}

}