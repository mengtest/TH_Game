#pragma once

#include <memory>
#include <vector>
#include <functional>

typedef void(*NormalFunction)(void);

class Singleton
{
private:
    static std::shared_ptr<Singleton> _instance;

    std::vector<std::function<void()>> v;
public:
    Singleton() = default;

    // void store(std::function<void(void)> f);

    void store(NormalFunction f);

    template <class T>
    typename std::enable_if<std::is_pointer_v<T> && (!std::is_function_v<T>), void>::type
    store(T t);

    static std::shared_ptr<Singleton> instance();

    ~Singleton();
};

template<class T>
typename std::enable_if<std::is_pointer_v<T> && (!std::is_function_v<T>), void>::type
Singleton::store(T t)
{
    v.emplace_back([t](){
        if (t != nullptr)
        {
            delete(t);
        	//这里去对这个t再赋值为空指针的话有用吗？
        }
    });
}