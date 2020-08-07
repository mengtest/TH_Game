#pragma once

#include <string>

//添加rapidJson文件的引用

//加载所有必须的数据（配置文件等）
class Loader
{
public:
	Loader() = delete;

	static void loadAllPawns(const std::string & text);

	static void loadConfig(const std::string &text);

	static void loadAllSkills(const std::string & text);

	static void loadAllBuffs(const std::string &text);
};
