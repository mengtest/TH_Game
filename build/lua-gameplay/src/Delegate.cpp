#include "Delegate.h"
#include <variant>

Delegate::Delegate(Callback callback, const std::string& name, int line)
	: _callback(std::move(callback))
{
	_hashCode = 0x221DB867;
	_hashCode ^= (_hashCode << 6) + (_hashCode >> 2) + 0x3E007940 + std::hash<std::string>{}(name);
	_hashCode ^= (_hashCode << 6) + (_hashCode >> 2) + 0x6D947001 + static_cast<std::size_t>(line);
}

Delegate::Delegate(const Delegate& other)
	: _callList(other._callList)
	, _callback(other._callback)
	, _hashCode(other._hashCode)
{
}

Delegate::Delegate(Delegate&& other) noexcept
	: _callList(std::move(other._callList))
	, _callback(std::move(other._callback))
	, _hashCode(other._hashCode)
{
}

Delegate& Delegate::operator=(const Delegate& other)
{
	if (this == &other)
		return *this;
	_callList = other._callList;
	_callback = other._callback;
	_hashCode = other._hashCode;
	return *this;
}

Delegate& Delegate::operator=(Delegate&& other) noexcept
{
	if (this == &other)
		return *this;
	_callList = std::move(other._callList);
	_callback = std::move(other._callback);
	return *this;
}

bool Delegate::operator()(const std::vector<object>& objects)
{
	_callback(objects);
	for (auto& callObject : _callList)
	{
		callObject.second.invoke(objects);
	}
	return true;
}

bool Delegate::invoke(const std::vector<object>& objects)
{
	_callback(objects);
	for (auto& callObject : _callList)
	{
		callObject.second.invoke(objects);
	}
	return true;
}

Delegate& Delegate::operator+=(Delegate& cast)
{
	//如果已经存在，则不再添加
	if (_callList.find(cast.hash_code()) == _callList.end())
	{
		_callList.insert({ cast.hash_code(), cast });
	}
	for (auto&& callable : cast._callList)
	{
		if (_callList.find(callable.first) == _callList.end())
		{
			_callList.insert({ callable.first, callable.second });
		}
	}
	cast._callList.clear();
	return *this;
}

Delegate& Delegate::operator-=(Delegate cast)
{
	//这个还可以完善，需要遍历整个的树
	if (_callList.find(cast.hash_code()) != _callList.end())
	{
		_callList.erase(cast.hash_code());
	}
	return *this;
}

bool Delegate::operator==(const Delegate& cast)
{
	return compare(cast);
}

bool Delegate::compare(const Delegate& cast)
{
	return _hashCode == cast._hashCode;
}



bool Listener::event(const std::string& name, int roomId, const std::vector<object>& objects)
{
	if (_delegates.find(roomId) == _delegates.end())
	{
		return false;
	}
	if (_delegates[roomId].find(name) == _delegates[roomId].end())
	{
		return false;
	}
	else
	{
		return _delegates[roomId][name].invoke(objects);
	}
}

bool Listener::on(const std::string& name, int roomId, Delegate& delegate)
{
	if (_delegates.find(roomId) == _delegates.end())
	{
		_delegates[roomId] = {};
	}
	if (_delegates[roomId].find(name) == _delegates[roomId].end())
	{
		_delegates[roomId][name] = delegate;
		return true;
	}
	else
	{
		_delegates[roomId][name] += delegate;
		return true;
	}
}

bool Listener::off(const std::string& name, int roomId, const Delegate& delegate)
{
	if (_delegates.find(roomId) == _delegates.end())
	{
		return true;
	}
	if (_delegates[roomId].find(name) == _delegates[roomId].end())
	{
		return true;
	}
	else
	{
		_delegates[roomId][name] -= delegate;
		return true;
	}
}