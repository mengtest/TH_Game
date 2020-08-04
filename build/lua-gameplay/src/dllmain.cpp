////#include "Logger.h"
//#include "boost/thread.hpp"
//#include "lua.hpp"
//#include <iostream>
//int main()
//{
////    sol::state lua;
////    lua.open_libraries();
////    sol::table tb = lua.script_file("./main.lua").get<sol::table>();
////    sol::lua_value value = tb.get<sol::lua_value>("create");
////    if (value.is<sol::function>())
////    {
////        value.as<sol::function>().call<void>();
////    }
//
////    for (int i = 0; i < 10 ;i ++)
////    {
////        ylog("%d, %s", 123, "23333");
////    }
////    clog(1, "%d, %s", 123, "23333");
////    clog(1, "%d, %s", 123, "23333");
////    clog(1, "%d, %s", 123, "23333");
////    clog(1, "%d, %s", 123, "23333");
////    clog(1, "%d, %s", 123, "23333");
////    clog(1, "%d, %s", 123, "23333");
////    clog(2, "%d, %s", 123, "23333");
//
////    auto L = luaL_newstate();
////    luaL_openlibs(L);
////    luaL_dostring(L, "print('hello lua')");
////    lua_close(L);
//
//    boost::thread t([](){
//        std::cout << "hello thread\n";
//    });
//    t.join();
//}

//#include <iostream>
//#include "factory/Factory.h"
//
//int main()
//{
////    reg(1, [](){
////        std::cout << "hello\n";
////    });
////    reg(2, [](){
////        std::cout << "hello2\n";
////    });
////    reg(1, [](int id){
////        std::cout << "hello\n" << id << "\n";
////    });
//}