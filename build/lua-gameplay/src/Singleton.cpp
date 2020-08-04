#include "Singleton.h"

std::shared_ptr<Singleton> Singleton::_instance = nullptr;

Singleton::~Singleton()
{
	//先初始化的后释放，所以这里是逆序的
    auto begin = v.rbegin();
    for (;begin != v.rend(); ++begin)
    {
        (*begin)();
    }
}

// void Singleton::store(std::function<void(void)> f)
// {
//     v.emplace_back(f);
// }

void Singleton::store(NormalFunction f)
{
    v.emplace_back(f);
}

std::shared_ptr<Singleton> Singleton::instance()
{
    if (!_instance)
    {
        _instance = std::make_shared<Singleton>();
    }
    return _instance;
}
