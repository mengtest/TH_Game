#pragma once

#include "Base.h"
#include <string>
#include <functional>
#include <map>
#include <vector>

#if _HAS_CXX17
#include <any>
using object = std::any;
//如果没有开启CXX17的话，需要使用我自定义的any来作为object
#else
using object = void*;
#endif

//最好这三个宏一起定义，一起取消定义
#if !defined(CREATE_DELEGATE)
#define DELEGATE_PARAM2 __FUNCSIG__
#define DELEGATE_PARAM3 __LINE__
//这个宏第一个参数就是一个lambda表达式，第二参数为当前函数签名的宏，第三个参数为当前所在行号的宏
//用后面两个宏来区分委托
//所有的委托都是同样的参数，std::any组成的向量
#define CREATE_DELEGATE(__name__, __sentence)\
		Delegate __name__([](const std::vector<object> & objects) __sentence, __FUNCSIG__, __LINE__)
#endif

class Delegate
{
public:
	using Callback = std::function<bool(const std::vector<object> & objects)>;

private:
	//主要是为了解决std::function无法求hash的问题
	std::map<size_t, Delegate> _callList;
	//自身必须含有一个可以执行的方法
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

	Delegate& operator +=(const Delegate& cast);

	Delegate& operator -=(const Delegate& cast);

	bool operator==(const Delegate& cast);

	bool compare(const Delegate& cast);

	//简单的封装，
	template<class T>
	static T cast(object obj);

	//生成一个默认的委托对象
	static Delegate none();

	[[nodiscard]] std::size_t hash_code() const
	{
		return _hashCode;
	}

	std::size_t hash_code()
	{
		return _hashCode;
	}
};

template <class T>
T Delegate::cast(object obj)
{
	//这里会抛出异常，需要在调用cast的时候去捕获异常
#if _HAS_CXX17
	return std::any_cast<T>(obj);
#else
	return my_cast<T>(obj);
#endif
}

//需要完善这里的Listener以及上面的Delegate
//特化版本的委托，全部需要房间id作为参数
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
