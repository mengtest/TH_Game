#include "LuaBuff.h"
#include "Pawn.h"
#include "Logger.h"
#include "fmt/format.h"

LuaBuff::LuaBuff(BuffMachine* machine, Pawn* source)
	: IBuff(machine, source)
	, _restTime(0)
	, _uid(0)
	, _overlay(0)
{
	ylog(u8"new LuaBuff");
}

LuaBuff::LuaBuff()
	: IBuff(nullptr, nullptr)
    , _restTime(0)
    , _uid(0)
    , _overlay(0)
{
	ylog(u8"new LuaBuff");
}

LuaBuff::~LuaBuff()
{
    // ylog(u8"free LuaBuff");
	// _table.clear();
}

IBuff* LuaBuff::clone(BuffMachine* machine, int unique_id, Pawn* source)
{
    auto *buff = new LuaBuff;
    buff->_machine = machine;
    buff->_uid = unique_id;
    //设置buff的来源
    buff->_source = source;
    // sol::table tb = buff->_table.get<sol::table>();
    sol::table temp = this->_table.get<sol::function>("new").call<sol::table>();
    buff->_table = temp;
	return buff;
}

LuaBuff* LuaBuff::createBuff(sol::table tb)
{
	auto* buff = new LuaBuff;
	buff->_table = tb;
    return buff;
}

int LuaBuff::id()
{
	return _table.get_or("id", -1);
}

int LuaBuff::unique_id()
{
	//自己存储uid
	return _uid;
}

int LuaBuff::maxTime()
{
	return _table.get_or("maxTime", 1);
}

int LuaBuff::restTime()
{
	return _restTime;
}

int LuaBuff::targetId()
{
    return _owner->unique_id();
}

int LuaBuff::sourcePawn()
{
    return _source->unique_id();
}

int LuaBuff::damage()
{
    //默认的buff不带有伤害
    return _table.get_or("damage", 0);
}

int LuaBuff::damageType()
{
    //默认的buff不带有伤害
    return _table.get_or("damageType", 0);
}

int LuaBuff::maxOverlay()
{
    //默认是不可叠加的
    return _table.get_or("maxOverlay", 1);
}

int LuaBuff::overlay()
{
	return _overlay;
}

int LuaBuff::baseType()
{
    //默认的基础类型为1、表示luabuff为特殊类型的buff
    return _table.get_or("baseType", 1);
}

int LuaBuff::primaryOverlay() {
    //默认值为1
    return _table.get_or("primaryOverlay", 1);
}

void LuaBuff::reset()
{

}

void LuaBuff::release()
{
    this->_machine->release(this);
}

bool LuaBuff::test(IBuff* buff)
{
	return true;
}

void LuaBuff::onDestroy(Pawn* source, Pawn* target)
{
    sol::lua_value lua_value = _table.get<sol::lua_value>("destroy");
    if (lua_value.is<sol::function>())
    {
        lua_value.as<sol::function>().call<void>(this, source, target);
    }
    else
    {
        // ylog(u8"无法调用buff:%d的销毁函数", this->unique_id());
    }
}

void LuaBuff::onCreate(Pawn* source, Pawn* target)
{
    sol::lua_value lua_value = _table.get<sol::lua_value>("create");
    if (lua_value.is<sol::function>())
    {
        lua_value.as<sol::function>().call<void>(this, source, target);
    }
    else
    {
        // ylog(u8"无法调用buff:%d的创建函数", this->unique_id());

    }
}

void LuaBuff::onInvoke(Pawn* source, Pawn* target)
{
    this->_overlay--;

    if (!this->_overlay)
    {
        //buff的叠加次数归零、可以销毁这个buff了
        destroy();
        return;
    }

    sol::lua_value lua_value = _table.get<sol::lua_value>("invoke");
    if (lua_value.is<sol::function>())
    {
        lua_value.as<sol::function>().call<void>(this, source, target);
    }
    else
    {
        // ylog(u8"无法调用buff:%d的执行函数", this->unique_id());

    }
}

void LuaBuff::onDispose(Pawn* source, Pawn* target)
{
    sol::lua_value lua_value = _table.get<sol::lua_value>("dispose");
    if (lua_value.is<sol::function>())
    {
        lua_value.as<sol::function>().call<void>(this, source, target);
    }
    else
    {
        // ylog(u8"无法调用buff:%d的驱散函数", this->unique_id());
    }
}

bool LuaBuff::onInteractive(Pawn* source, Pawn* target, IBuff* buff, int type)
{
    sol::lua_value lua_value = _table.get<sol::lua_value>("interactive");
    if (lua_value.is<sol::function>())
    {
        return lua_value.as<sol::function>().call<bool>(this, source, target, buff, type);
    }
    else
    {
        // ylog(u8"无法调用buff:%d的交互函数", this->unique_id());
    }
	return true;
}