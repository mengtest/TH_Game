#include "Singleton.h"
#include "Interfaces.h"

std::shared_ptr<Singleton> Singleton::_instance = nullptr;

Singleton::~Singleton()
{
    //优先释放所有的handle
    release();
	
	//先初始化的后释放，所以这里是逆序的
    auto begin = v.rbegin();
    for (;begin != v.rend(); ++begin)
    {
        (*begin)();
    }
}

void Singleton::store(NormalFunction f)
{
    v.emplace_back(f);
}

void Singleton::store(IRelease* handle)
{
    _handles.emplace_back(handle);
}

void Singleton::release()
{
    auto handle = _handles.rbegin();
    for (; handle != _handles.rend(); ++handle)
    {
        (*handle)->free();
        delete (*handle);
    }
    _handles.clear();
}

std::shared_ptr<Singleton> Singleton::instance()
{
    if (!_instance)
    {
        _instance = std::make_shared<Singleton>();
    }
    return _instance;
}