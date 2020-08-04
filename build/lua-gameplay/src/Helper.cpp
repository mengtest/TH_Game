#include "Helper.h"
#include <functional>
#include "Base.h"
#include "Singleton.h"
// #include "spdlog/sinks/daily_file_sink.h"

// class LogImpl
// {
// private:
// 	std::shared_ptr<spdlog::logger> _logger;
// public:
// 	LogImpl()
// 	{
// 		_logger = spdlog::daily_logger_mt("daily_logger", "logs/daily.txt", 0, 0);
// 	}
//
// 	template<typename... Args>
// 	void log(const char* fmt, const Args&... args)
// 	{
// 		_logger->debug(fmt, args);
// 	};
// };

StringBuilder* StringBuilder::_instance = nullptr;

std::random_device Helper::r;
std::default_random_engine Helper::e(r());
float Helper::_seed = 0;
bool Helper::_useFrame = false;
// LogImpl* Helper::_logger = new LogImpl;
// FileSystemReader Helper::_callback = nullptr;

StringBuilder& StringBuilder::instance()
{
	if (_instance == nullptr)
	{
		_instance = new StringBuilder;
		Singleton::instance()->store(_instance);
		//设置缓存最大为10k
		_instance->_max = 1024 * 10;
		_instance->_call = false;
	}
	return *_instance;
}

const std::string& StringBuilder::build()
{
	//调用build之后，会清除缓存
	_call = true;
	return _view;
}

StringBuilder* StringBuilder::push(const std::string& key, const std::string& value)
{
	//清空当前的缓存
	if (_call)
	{
		_view.clear();
		_call = false;
	}
	char buff[1024] = { '\0' };
	//为空则在要格式化的字符串前面添加;，否则的话不添加
	//最后可以在其他端通过;与&对字符串做切割
	if (_view.empty())
	{
		// sprintf();
		snprintf(buff, sizeof(buff) ,"%s&%s", key.c_str(), value.c_str());
	}
	else
	{
		snprintf(buff, sizeof(buff), ";%s&%s", key.c_str(), value.c_str());
	}
	//最大长度不能超过1024
	//超过了的话，则返回空指针
	if (_view.size() + strlen(buff) < this->_max)
	{
		_view += buff;
	}
	else
	{
		return nullptr;
	}
	return _instance;
}

StringBuilder* StringBuilder::push(const std::string& key, int pawnId, int buffId)
{
	//清空当前的缓存
	if (_call)
	{
		_view.clear();
		_call = false;
	}
	char buff[1024] = { '\0' };
	//为空则在要格式化的字符串前面添加;，否则的话不添加
	//最后可以在其他端通过;与&对字符串做切割
	if (_view.empty())
	{
		snprintf(buff, sizeof(buff), "%s&%d->%d", key.c_str(), pawnId, buffId);
	}
	else
	{
		snprintf(buff, sizeof(buff), ";%s&%d->%d", key.c_str(), pawnId, buffId);
	}
	//最大长度不能超过1024
	//超过了的话，则返回空指针
	if (_view.size() + strlen(buff) < this->_max)
	{
		_view += buff;
	}
	else
	{
		return nullptr;
	}
	return _instance;
}

void Helper::seed(float s)
{
	_seed = s;
	e.seed(_seed);
}

float Helper::seed()
{
	return _seed;
}

int Helper::random(int min, int max)
{
	if (min > max)
	{
		const auto temp = min;
		min = max;
		max = temp;
	}
	return std::uniform_int_distribution<>(min, max)(e);
}

float Helper::random(float min, float max)
{
	if (min > max)
	{
		const auto temp = min;
		min = max;
		max = temp;
	}
	return std::uniform_real_distribution<>(min, max)(e);
}

float Helper::random()
{
	return std::uniform_real_distribution<>(0, 1)(e);
}

void Helper::memset(int* ary, int size)
{
	for (int i = 0; i < size; ++i)
	{
		ary[size] = 0;
	}
}

// void Helper::log(const char* str, ...)
// {
// 	// auto logger = spdlog::daily_logger_mt("daily_logger", "logs/daily.txt", 0, 0);
// 	_logger->log(str);
// }


// void Helper::setFileSystemReaderCallback(FileSystemReader callback)
// {
// 	_callback = callback;
// }
//
// const char** Helper::readDir(const char* path, int* size)
// {
// 	if (_callback == nullptr)
// 	{
// 		return nullptr;
// 	}
// 	return _callback(path, size);
// }

// int Helper::random(int size)
// {
// 	if (size == 0)
// 	{
// 		return 0;
// 	}
// 	return std::uniform_int_distribution<>(1, size)(e);
// }

void Helper::init()
{

}


int costTypeTranslate(bool player, int type)
{
    if (player)
    {
        switch (type)
        {
            case 1:
                return yGlobal.CostPlayerHp;
            case 2:
                return yGlobal.CostPlayerEnergy;
            case 3:
                return yGlobal.CostPlayerMaxEnergy;
            case 4:

            case 5:

            case 6:

            default:
                return 0;
        }
    }
    else
    {
        switch (type)
        {
            case 1:
                return yGlobal.CostPawnHp;
            case 2:
                return yGlobal.CostPawnMp;
            case 3:
                return yGlobal.CostPawnAtk;
            case 4:
                return yGlobal.CostPawnMatk;
            case 5:
                return yGlobal.CostPawnDef;
            case 6:
                return yGlobal.CostPawnMdef;
            default:
                return 0;
        }
    }
}