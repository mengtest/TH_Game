#pragma once

#include "Base.h"
#include <string>
#include <functional>
#include <map>
#include <vector>

#if __CPP_17__
#include <any>
using object = std::any;
//如果没有开启CXX17的话，需要使用我自定义的any来作为object
#else
using object = void*;
#endif

#define CREATE_DELEGATE(__name__, __sentence)\
		Delegate __name__([](const std::vector<object> & objects) __sentence, __FUNCSIG__, __LINE__)

class Delegate
{
public:
	using Callback = std::function<bool(const std::vector<object> & objects)>;

private:
	//主要是为了解决std::function无法求hash的问题
	std::map<size_t, Delegate> _callList;
	Callback _callback;
	size_t _hashCode{};

public:
	Delegate(Callback callback, const std::string& name, int line);

	Delegate() = default;

	Delegate(const Delegate& other);

	Delegate(Delegate&& other) noexcept;

	Delegate& operator=(const Delegate& other);

	Delegate& operator=(Delegate&& other) noexcept;

	bool operator()(const std::vector<object>& objects);

	bool invoke(const std::vector<object>& objects);

	Delegate& operator +=(Delegate& cast);

	Delegate& operator -=(Delegate cast);

	bool operator==(const Delegate& cast);

	bool compare(const Delegate& cast);

	template<class T>
	T cast(object obj);

	std::size_t hash_code()
	{
		return _hashCode;
	}
};

template <class T>
T Delegate::cast(object obj)
{
	//这里会抛出异常，需要在调用cast的时候去捕获异常
#if __CPP_17__
	return std::any_cast<T>(obj);
#else
	return my_cast<T>(obj);
#endif
}

//需要完善这里的Listener以及上面的Delegate
class Listener
{
private:
	std::map<int, std::map<std::string, Delegate>> _delegates;

public:
	/**
	 * \brief 触发一个事件
	 * \param name 事件的名称
	 * \param roomId 房间的名称
	 * \param objects 参数列表，暂时先用这个来做，后面可能会替换成不定参数
	 * \return 是否触发成功
	 */
	bool event(const std::string& name, int roomId, const std::vector<object>& objects);

	/**
	 * \brief 注册一个事件,所有的事件，按房间来存储，传入的参数为roomId,
	 * 其他参数根据监听的事件的类型来给出不同的参数，这里所有的id都可能会被改成直接传递对象
	 * 攻击：攻击者id	，目标id
	 * 使用技能：使用技能者id，目标id，技能id
	 * 挂载buff：buff来源id，buff目标id，buff的id
	 * 取消buff：buff来源id，buff目标id，buff的id
	 * 棋子死亡：棋子id
	 * 召唤棋子：玩家id，棋子id
	 * \param name 事件名
	 * \param roomId 房间名
	 * \param delegate 要注册的委托
	 * \return 是否注册成功
	 */
	bool on(const std::string& name, int roomId, Delegate& delegate);

	/**
	 * \brief 注销一个事件
	 * \param name 事件的名称
	 * \param roomId 房间id
	 * \param delegate 取消注册的委托
	 * \return 是否注册成功
	 */
	bool off(const std::string& name, int roomId, const Delegate& delegate);
};
