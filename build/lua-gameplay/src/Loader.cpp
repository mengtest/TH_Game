#include "Loader.h"
#include "PawnMgr.h"
#include "Data.h"
#include "SkillMgr.h"
#include "BuffMachine.h"
#include "Agent.h"
// #include "3rd.h"
#include "Logger.h"
#include "rapidjson/filereadstream.h"
#include "rapidjson/document.h"
#include "fmt/format.h"
// #include "rapidjson/istreamwrapper.h"

//如果源文件的编码是utf8以及json文件的编码也是utf8的话，可以使用C++这边的读写来直接完成

void Loader::loadAllPawns(const std::string & text)
{
//    boost::property_tree::ptree t;
//    boost::property_tree::read_json("./../jsons/cards.json", t);
//    ylog("%d", t.size());
//    std::stringstream ss;
//    boost::property_tree::write_json(ss, t);
	// google::InitGoogleLogging("THCore");
	// LOG(INFO) << "";
	// google::FlushLogFiles(google::GLOG_INFO);

	fmt::format("111111111111");
	
    FILE* f = nullptr;
    f = fopen(text.c_str(), "r");
    fseek(f, 0, SEEK_END);
    auto size = ftell(f);
    rewind(f);
    char *buf = new char[size];
    rapidjson::FileReadStream fs{f, buf, strlen(buf)};
	// rapidjson::IStreamWrapper isw{};
	rapidjson::Document doc;
	//目前还没有确定这里的text到底是文本内容还是文本路径
	doc.ParseStream(fs);
    delete[] buf;
    fclose(f);

	//要求是数组
	if (/*doc.IsObject() && */doc.IsArray())
	{
		int size = doc.Size();

		//根据最大的id值来分配长度，而不是数组的长度来分配空间
		//这样做是为了避免中间id缺失的情况下无法做快速随机访问
		//这里直接修改其元素的实际长度而不是预留空间
		std::vector<PawnS*> pawns(doc[size - 1]["id"].GetInt(), nullptr);

		for (auto index =0;index <size ;++index)
		{
			auto& element = doc[index];
			auto id = element["id"].GetInt();
			//暂时先不使用grow相关的属性，等以后再说
			auto* pawn = new PawnS;
			memset(pawn, 0, sizeof PawnS);
			pawn->id = id;
			pawn->atk = element["atk"].GetInt();
			pawn->hp = element["hp"].GetInt();
			pawn->mp = element["mp"].GetInt();
			pawn->type = element["type"].GetInt();
			pawn->skills[0] = element["skill1"].GetInt();
			pawn->skills[1] = element["skill2"].GetInt();
			pawn->skills[2] = element["skill3"].GetInt();
			pawn->skills[3] = element["skill4"].GetInt();
			pawn->skills[4] = element["skill5"].GetInt();
			//初始化的时候所有的卡牌都在卡池中
			pawn->posType = 1;
			pawn->pos = -1;
			//这里还没有为棋子分配uid
			pawn->unique_id = -1;
			//预定义ai的id为-1，所以这里给出默认值为0
			pawn->playerId = 0;
			pawns[id - 1] = pawn;
            ylog(u8"%s", element.HasMember("name_cn") ? element["name_cn"].GetString() : "");
		}
		PawnMgr::loadAll(pawns);
	}

}

void Loader::loadConfig(const std::string & text)
{
    FILE* f = nullptr;
    f = fopen(text.c_str(), "r");
    fseek(f, 0, SEEK_END);
    auto size = ftell(f);
    rewind(f);
    char *buf = new char[size];
    rapidjson::FileReadStream fs{f, buf, strlen(buf)};
    rapidjson::Document doc;
    //目前还没有确定这里的text到底是文本内容还是文本路径
    doc.ParseStream(fs);
    delete[] buf;
    fclose(f);

	auto config = new Config;
	memset(config, 0, sizeof Config);
	//这个也需要导出到lua，以全局表的方式导出
	if (doc.IsObject())
	{
		//这个感觉就是直接给到lua去读取都可以
		config->energyGrow = doc["energyGrow"].GetInt();
		config->maxEnergy = doc["maxEnergy"].GetInt();
		config->highDrawPrice = doc["highDrawPrice"].GetInt();
		config->high_nPercent = doc["high_nPercent"].GetInt();
		config->high_rPercent = doc["high_rPercent"].GetInt();
		config->high_srPercent = doc["high_srPercent"].GetInt();
		config->high_ssrPercent = doc["high_ssrPercent"].GetInt();
		config->maxHp = doc["maxHp"].GetInt();
		config->maxRound = doc["maxRound"].GetInt();
		config->normalDrawPrice = doc["normalDrawPrice"].GetInt();
		config->normal_nPercent = doc["normal_nPercent"].GetInt();
		config->normal_rPercent = doc["normal_rPercent"].GetInt();
		config->normal_srPercent = doc["normal_srPercent"].GetInt();
		config->normal_ssrPercent = doc["normal_ssrPercent"].GetInt();
		config->primaryCard = doc["primaryCard"].GetInt();
		config->primaryEnergy = doc["primaryEnergy"].GetInt();
		config->primaryGold = doc["primaryGold"].GetInt();
		config->primaryHp = doc["primaryHp"].GetInt();
		config->roundCard = doc["roundCard"].GetInt();
		config->salary = doc["salary"].GetInt();
	}
	AgentMgr::instance()->curAgent()->setConfig(config);

}

void Loader::loadAllSkills(const std::string & text)
{
    FILE* f = nullptr;
    f = fopen(text.c_str(), "r");
    fseek(f, 0, SEEK_END);
    auto size = ftell(f);
    rewind(f);
    char *buf = new char[size];
    rapidjson::FileReadStream fs{f, buf, strlen(buf)};
    rapidjson::Document doc;
    //目前还没有确定这里的text到底是文本内容还是文本路径
    doc.ParseStream(fs);
    delete[] buf;
    fclose(f);
	//要求是数组
	if (/*doc.IsObject() && */doc.IsArray())
	{
		int size = doc.Size();

		//根据最大的id值来分配长度，而不是数组的长度来分配空间
		//这里直接修改其元素的实际长度而不是预留空间
		std::vector<SkillS*> skills(doc[size - 1]["id"].GetInt(), nullptr);

		for (auto index = 0; index < size; ++index)
		{
			auto& element = doc[index];
			auto id = element["id"].GetInt();
			//暂时先不使用grow相关的属性，等以后再说
			auto* skill = new SkillS;
			memset(skill, 0, sizeof SkillS);
			skill->id = id;
			skill->cost = element["cost"].GetInt();
			skill->costType = element["costType"].GetInt();
			skill->targetType = element["targetType"].GetInt();
			skill->damage = element["damage"].GetInt();
			skill->damageType = element["damageType"].GetInt();
			skill->passive = element["passive"].GetInt();
			skill->disperse = element["disperse"].GetInt();
			skill->buffs[0] = element["buff1"].GetInt();
			skill->buffs[1] = element["buff2"].GetInt();
			skill->buffs[2] = element["buff3"].GetInt();
			skill->buffs[3] = element["buff4"].GetInt();
			skill->buffs[4] = element["buff5"].GetInt();
			skills[id - 1] = skill;
		}
		SkillMgr::instance()->loadAll(skills);
	}
}

void Loader::loadAllBuffs(const std::string & text)
{
    FILE* f = nullptr;
    f = fopen(text.c_str(), "r");
    fseek(f, 0, SEEK_END);
    auto size = ftell(f);
    rewind(f);
    char *buf = new char[size];
    rapidjson::FileReadStream fs{f, buf, sizeof(buf)};
    rapidjson::Document doc;
    //目前还没有确定这里的text到底是文本内容还是文本路径
    doc.ParseStream(fs);
    delete[] buf;
    fclose(f);
	//要求是数组
	if (/*doc.IsObject() && */doc.IsArray())
	{
		int size = doc.Size();

		//根据最大的id值来分配长度，而不是数组的长度来分配空间
		//这里直接修改其元素的实际长度而不是预留空间
		std::vector<BuffS*> buffs(doc[size - 1]["id"].GetInt(), nullptr);

		for (auto index = 0; index < size; ++index)
		{
			auto& element = doc[index];
			auto id = element["id"].GetInt();
			//暂时先不使用grow相关的属性，等以后再说
			auto* buff = new BuffS;
			memset(buff, 0, sizeof BuffS);
			buff->id = id;
			buff->maxTime = element["maxTime"].GetInt();
			buff->damage = element["damage"].GetInt();
			buff->damageType = element["damageType"].GetInt();
			buff->maxOverlay = element["maxOverlay"].GetInt();
			buff->baseType = element["baseType"].GetInt();
			buff->value = element["value"].GetInt();
			buff->primaryOverlay = element["primaryOverlay"].GetInt();
			// buff->careTags[0] = element["careTags1"].GetInt();
			// buff->careTags[1] = element["careTags2"].GetInt();
			// buff->careTags[2] = element["careTags3"].GetInt();
			// buff->careTags[3] = element["careTags4"].GetInt();
			// buff->careTags[4] = element["careTags5"].GetInt();
			// buff->tags[0] = element["tags1"].GetInt();
			// buff->tags[1] = element["tags2"].GetInt();
			// buff->tags[2] = element["tags3"].GetInt();
			// buff->tags[3] = element["tags4"].GetInt();
			// buff->tags[4] = element["tags5"].GetInt();
			buffs[id - 1] = buff;
		}
		BuffMachine::loadAll(buffs);
	}
}
