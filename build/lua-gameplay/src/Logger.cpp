#include "Logger.h"
#include "Singleton.h"
#include "spdlog/sinks/stdout_color_sinks.h"
#include "spdlog/spdlog.h"
#include "spdlog/sinks/daily_file_sink.h"
#include "spdlog/sinks/basic_file_sink.h"

Logger* Logger::_instance;

Logger::Logger()
{
	_logger = spdlog::daily_logger_mt("YUKI_LOG", "logs/daily.txt", 0, 0);
    _consoleLogger = spdlog::stdout_color_mt("console");
}

Logger* Logger::instance()
{
	if (_instance == nullptr)
	{
		_instance = new Logger;
		//这个也是free中调用删除，避免出现文件一直被占用的情况
		Singleton::instance()->store(_instance);
	}
	return _instance;
}

void Logger::log(const char* fmt)
{
	_logger->info(fmt);
	_logger->flush();
}

void Logger::log(int id, const char* fmt)
{
	if (this->_curCombatId == -1 || this->_curCombatId != id)
	{
		this->_curCombatId = id;
		if (!_combatLogger)
		{
			_combatLogger = spdlog::basic_logger_mt("Combat", fmt::format("logs/combat_{0}.txt", this->_curCombatId));
			_combatLogger->flush();
		}
	}
	
	if (this->_curCombatId > 0)
	{
		_combatLogger->info(fmt);
		_combatLogger->flush();
	}
}

void Logger::free()
{
	delete _instance;
	_instance = nullptr;
}

void nn::nlog(const char *str) {
    Logger::instance()->log(str);
}

void nn::nlogS(const std::string& str)
{
	Logger::instance()->log(str.c_str());
}

void nn::nlogF(double f)
{
	Logger::instance()->log(std::to_string(f).c_str());
}

void nn::nlogI(int i)
{
	Logger::instance()->log(std::to_string(i).c_str());
}

void nn::log(const char* fmt)
{
	Logger::instance()->log(fmt);
}

void nn::log(const char* file, int line, const char* fmt)
{
	// char buf[256] = {};
	// sprintf(buf, fmt, args...);
	auto f = fmt::format("[FILE:{0}\tLINE:{1}] [MSG:{2}]", file, line, fmt);
	Logger::instance()->log(f.c_str());
	spdlog::get("console")->info(f.c_str());
}

void nn::log(int id, const char* file, int line, const char* fmt)
{
	Logger::instance()->log(id, fmt::format("[FILE:{0}\tLINE:{1}] [MSG:{2}]", file, line, fmt).c_str());
}
