#pragma once

#include <memory>
#include <vector>
#include <functional>

class IRelease;
typedef void(*NormalFunction)();

class Singleton
{
private:
    static std::shared_ptr<Singleton> _instance;

    std::vector<std::function<void()>> v;

	//这里存储所有的单例对象，当调用release的时候释放所有的单例对象的内存
	//所有的IRelease对象都有free函数，free函数里面会释放内存，并且将对象设置为nullptr
    std::vector<IRelease*> _handles;
public:
    Singleton() = default;

    // void store(std::function<void(void)> f);

    void store(NormalFunction f);

    void store(IRelease* handle);

    void release();

    template <class T>
    typename std::enable_if<
        std::is_pointer_v<T>
		&& (!std::is_function_v<T>)
		&& (!std::is_convertible_v<T, IRelease*>), void>::type
    store(T t);

    static std::shared_ptr<Singleton> instance();

    ~Singleton();
};

template<class T>
typename std::enable_if<
	std::is_pointer_v<T>
	&& (!std::is_function_v<T>)
    && (!std::is_convertible_v<T, IRelease*>), void>::type
Singleton::store(T t)
{
    v.emplace_back(
        [t]() {
            if (t != nullptr)
            {
                delete(t);
            }
        });
}