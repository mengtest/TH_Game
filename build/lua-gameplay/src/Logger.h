#pragma once

#include <memory>
#include <string>
#include "Interfaces.h"

namespace spdlog
{
    class logger;
}

class Logger: IRelease
{
private:
	std::shared_ptr<spdlog::logger> _logger;

    std::shared_ptr<spdlog::logger> _combatLogger;

    std::shared_ptr<spdlog::logger> _consoleLogger;

    int _curCombatId = -1;

	static Logger* _instance;

	Logger();
public:
	static Logger* instance();

	void log(const char* fmt);

	void log(int id, const char* fmt);

	void free() override;
};

namespace nn
{
    void nlog(const char * str);

    void nlogS(const std::string& str);

    void nlogF(double f);

    void nlogI(int i);

    void log(const char* fmt);

    void log(const char* file, int line, const char* fmt);

    void log(int id, const char* file, int line, const char* fmt);
}

#define ylog(__fmt__, ...) \
	nn::log(__FILE__, __LINE__, fmt::format(__fmt__, __VA_ARGS__).c_str())
#define clog(__id__, __fmt__, ...) \
	nn::log(__id__, __FILE__, __LINE__, fmt::format(__fmt__, __VA_ARGS__).c_str())
#define yerror()