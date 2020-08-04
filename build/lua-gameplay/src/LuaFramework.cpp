#include <filesystem>
#include <set>
#include "LuaFramework.h"

#include "Agent.h"
#include "Pawn.h"
#include "Player.h"
#include "Interfaces.h"
#include "Combat.h"
#include "LuaBuff.h"
#include "Data.h"
#include "Logger.h"
#include "fmt/format.h"
#include "Singleton.h"
#include "Export.h"

//std::shared_ptr<LuaFramework> LuaFramework::_instance = std::shared_ptr<LuaFramework>(new LuaFramework);

LuaFramework* LuaFramework::_instance = nullptr;

//简化sol中函数的注册
#define SOL_FUN(_CLASS_, _FUN_)\
    #_FUN_, &_CLASS_::_FUN_

LuaFramework::LuaFramework()
{
    //打开所有的基础库s
    // _lua.open_libraries(sol::lib::base 
    //     // , sol::lib::bit32
    //     , sol::lib::coroutine
    //     , sol::lib::io
    //     , sol::lib::math
    //     , sol::lib::package
    //     , sol::lib::string
    //     , sol::lib::table
    //     // , sol::lib::utf8
    // );

    _lua.open_libraries();
}

LuaFramework::~LuaFramework()
{
	// for (auto script_buff : _scriptBuffList)
	// {
 //        delete script_buff.second;
	// }
 //    _scriptBuffList.clear();
}

LuaFramework* LuaFramework::instance()
{
	if (_instance == nullptr)
	{
        _instance = new LuaFramework();
        Singleton::instance()->store(_instance);
        Singleton::instance()->store(BuffMachine::clearAllScriptBuff);
	}
    return _instance;
}

sol::state& LuaFramework::lua()
{
    return _lua;
}

void LuaFramework::loadAll(const std::string& path)
{	
    std::string root = path + "/script/";
    ylog("%s", root.c_str());
    std::filesystem::path dir(root);

    if (exists(dir))
    {
        std::filesystem::path util(root + "/util/util.lua");
        if (exists(util))
        {
        	//util讲道理的话应该是在init中被加载的，这里先这样做吧，主要是为了不暴露出class函数
            (void)_lua.script_file(util.generic_string());
        }
    	
        std::filesystem::path global(root + "/init.lua");
        if (exists(global))
        {
            //root目录下面的init.lua文件为全局的脚本文件入口，在这里加载所有的自定义模块
            (void)_lua.script_file(global.generic_string());
        }

        auto skillDir = std::filesystem::directory_entry(std::filesystem::path(root) += "/skills/");
        auto pawnDir = std::filesystem::directory_entry(std::filesystem::path(root) += "/pawns/");
        auto buffDir = std::filesystem::directory_entry(std::filesystem::path(root) += "/buffs/");

        if (pawnDir.is_directory())
        {
            std::filesystem::directory_iterator it(pawnDir.path());
            for (auto& file : it)
            {
                auto t = _lua.script_file(file.path().generic_string());
                if (t.get_type(0) == sol::type::table)
                {
                    // sol::table table = t.get<sol::table>();
                	// 这里的做法应该是将这个lua文件中所有的数据全部读取并存入到cpp中，然后就可以不用管了
                }
            }
        }

        if (skillDir.is_directory())
        {
            std::filesystem::directory_iterator it(skillDir.path());
            for (auto& file : it)
            {
                auto t = _lua.script_file(file.path().generic_string());
                if (t.get_type(0) == sol::type::table)
                {
                    //要如何去存储这些表？
                    //技能表实际上就是一个纯数据实体类
                    //将里面的数据全部读取出来，然后这个表就可以不要了
                    // sol::table table = t.get<sol::table>();

                	//这里的做法应该是将这个lua文件中所有的数据全部读取并存入到cpp中，然后就可以不用管了
                }
            }
        }

        if (buffDir.is_directory())
        {
            std::filesystem::directory_iterator it(buffDir.path());
			//所有的原始buff都存放在nn名称空间下面的LuaBuffList中
        	//依据其id存储为_buff_id
            sol::table nn = _lua["nn"].get_or_create<sol::table>();
            // sol::table luaBuffList = nn["LuaBuffList"].get_or_create<sol::table>();
        	//所有的实际战斗系统中buff都存放在
        	//_combatId_buff_uid
            for (auto& file : it)
            {	
                auto t = _lua.script_file(file.path().generic_string());
                if (t.get_type(0) == sol::type::table)
                {
                    sol::table tab = t.get<sol::table>();
                    //需要将每个table存储在不同的LuaBuff中
                    //一个lua文件就是一个自定义buff

                    if (tab["id"].get_type() != sol::type::number)
                    {
                        continue;
                    }
                    
                    auto id = tab.get<int>("id");
                	//如果原始buff中已经有了这个id的buff则返回false
                	//或者脚本buff中出现了相同的id
                    if (BuffMachine::contain(id))
                    {
                        continue;
                    }
                	//必须有id、name、new函数，有任意一个不存在的话都不加载这个文件
                    if (tab["name"].get_type() != sol::type::string
                     || tab["new"].get_type() != sol::type::function)
                    {
	                    //无法加载这个buff
                        continue;
                    }
                    else
                    {
                    	// 添加一个原始buff
                        auto* buff = LuaBuff::createBuff(tab);
                    	//添加失败就释放这个buff的内存
                        BuffMachine::addBuff(buff);
                    }
                }
            }
        }
    }
}

/*
 * 脚本的目录结构如下:
 *  root：
 *      1、skills(纯数据实体类)
 *          可以将每个技能存放在单独的脚本里面，但是这样太耗空间了，应该直接存到一个脚本里面
 *      2、pawns(纯数据实体类)
 *          同上
 *      3、buffs(这里应该都是包含有数据与函数的脚本)
 *          每个buff都是一个单独的脚本，必须遵从类的形式来定义，且必须有返回自定义的类
 *      4、gameplay.lua
 *          存放如下等函数，在对应的时机会分别调用
 *          start
 *          next
 *          end
 *          想要在各个流程中嵌入操作的函数
 *      5、init.lua
 *          一些必要的全局的初始化操作
 */
void LuaFramework::exportAll() {
    //所有的导出类都存放到yuki这个表下面，充当名称空间的作用
    //sol::table yuki = _lua["yuki"].get_or_create<sol::table>();

    //所有的静态的create函数都存放到这里
    //sol::table create = _lua["create"].get_or_create<sol::table>();

#pragma region nn名称空间下面所有的全局函数
    //region nn名称空间下面所有函数的声明
    sol::table nn = _lua["nn"].get_or_create<sol::table>();
    nn.set_function("log", sol::overload(nn::nlog, nn::nlogS, nn::nlogF, nn::nlogI));
    nn.set_function("create_combat", Export::create_combat);
    nn.set_function("get_combat", Export::get_combat);
    nn.set_function("create_combat", Export::create_combat);
    nn.set_function("release_export", Export::release_export);
	
    //endregion
#pragma endregion 

	
    //region Pawn的声明
#pragma region Pawn的声明
    typedef int(Pawn::* unmount1)(int id);
    //        typedef int(Pawn::* unmount2)(IBuff *);
    unmount1 m1 = &Pawn::unmount;
    //        unmount2 m2 = &Pawn::unmount;

    typedef bool(Pawn::* attack_pawn)(Pawn*);
    typedef bool(Pawn::* attack_player)(Player*);
    attack_pawn a1 = &Pawn::attack;
    attack_player a2 = &Pawn::attack;
	
    // (void)_lua.new_usertype<Pawn>("Pawn", sol::no_constructor
    //     , SOL_FUN(Pawn, addTo)
    //     , SOL_FUN(Pawn, alive)
    //     , SOL_FUN(Pawn, atk)
    //     // , SOL_FUN(Pawn, attack)
    //     , "attack", sol::overload(a1, a2)
    //     , SOL_FUN(Pawn, checkAction)
    //     , SOL_FUN(Pawn, containBuff)
    //     , SOL_FUN(Pawn, check)
    //     , SOL_FUN(Pawn, cost)
    //     , SOL_FUN(Pawn, def)
    //     , SOL_FUN(Pawn, data)
    //     , SOL_FUN(Pawn, dead)
    //     , SOL_FUN(Pawn, getOwner)
    //     , SOL_FUN(Pawn, getBuffById)
    //     , SOL_FUN(Pawn, getBuffByIndex)
    //     , SOL_FUN(Pawn, getBuffByUid)
    //     , SOL_FUN(Pawn, getBuffSize)
    //     , SOL_FUN(Pawn, hp)
    //     , SOL_FUN(Pawn, hasSkill)
    //     , SOL_FUN(Pawn, heal)
    //     , SOL_FUN(Pawn, hit)
    //     , SOL_FUN(Pawn, id)
    //     , SOL_FUN(Pawn, mount)
    //     , SOL_FUN(Pawn, moveToDeck)
    //     , SOL_FUN(Pawn, moveToHand)
    //     , SOL_FUN(Pawn, moveToPanel)
    //     , SOL_FUN(Pawn, minus)
    //     , SOL_FUN(Pawn, plus)
    //     , SOL_FUN(Pawn, pos)
    //     , SOL_FUN(Pawn, posType)
    //     , SOL_FUN(Pawn, reset)
    //     , SOL_FUN(Pawn, sufferSkill)
    //     , SOL_FUN(Pawn, toDisplay)
    //     , SOL_FUN(Pawn, unique_id)
    //     , SOL_FUN(Pawn, useSkill)
    //     //重载成员函数的写法，
    //     //创建不同的函数指针，明确目标函数是谁
    //     //或者使用lambda表达式，类似于lua，第一个参数传递类对象本身
    //     , "unmount", sol::overload(m1/*, m2*/)
    //     );

    (void)_lua.new_usertype<Pawn>("Pawn", sol::no_constructor
        // PawnS * data();
		// PawnD * toDisplay();
        , SOL_FUN(Pawn, id)
        , SOL_FUN(Pawn, unique_id)
        , SOL_FUN(Pawn, hp)
        // , SOL_FUN(Pawn, attack)
        , SOL_FUN(Pawn, mp)
        , SOL_FUN(Pawn, matk)
        , SOL_FUN(Pawn, atk)
        , SOL_FUN(Pawn, def)
        , SOL_FUN(Pawn, mdef)
        , SOL_FUN(Pawn, getBuffSize)
        , SOL_FUN(Pawn, getBuffByIndex)
        , SOL_FUN(Pawn, getBuffById)
        , SOL_FUN(Pawn, getBuffByUid)
        , SOL_FUN(Pawn, containBuff)
        , SOL_FUN(Pawn, hasSkill)
        , SOL_FUN(Pawn, getOwner)
        , SOL_FUN(Pawn, addTo)
        , SOL_FUN(Pawn, posType)
        , SOL_FUN(Pawn, pos)
        , SOL_FUN(Pawn, moveToHand)
        , SOL_FUN(Pawn, moveToDeck)
        , SOL_FUN(Pawn, moveToPanel)
        , SOL_FUN(Pawn, mount)
        // , SOL_FUN(Pawn, moveToHand)
        // , SOL_FUN(Pawn, moveToPanel)
        , "unmount", sol::overload(m1/*, m2*/)
        // int unmount(IBuff * buff);
        , SOL_FUN(Pawn, hit)
        , "attack", sol::overload(a1, a2)
        , SOL_FUN(Pawn, useSkill)
        , SOL_FUN(Pawn, useSkillWithCost)
        , SOL_FUN(Pawn, sufferSkill)
        , SOL_FUN(Pawn, heal)
        , SOL_FUN(Pawn, reset)
        , SOL_FUN(Pawn, dead)
        , SOL_FUN(Pawn, cost)
        , SOL_FUN(Pawn, check)
        , SOL_FUN(Pawn, alive)
        , SOL_FUN(Pawn, opAtk)
        , SOL_FUN(Pawn, opHp)
        , SOL_FUN(Pawn, opMp)
        , SOL_FUN(Pawn, opMatk)
        , SOL_FUN(Pawn, opMdef)
        , SOL_FUN(Pawn, opMatk)
        // void release();
        , SOL_FUN(Pawn, checkAction)
        // , SOL_FUN(Pawn, plus)
        // , SOL_FUN(Pawn, minus)
        // , SOL_FUN(Pawn, to)
        );
#pragma endregion 
    //endregion

    //region Player的声明
#pragma region  Player
    // (void)_lua.new_usertype<Player>("Player", sol::no_constructor
    //     // 创建玩家的时候回一起创建所有的棋子，所以不支持单独创建棋子
    //     // , SOL_FUN(Player, addPawn)
    //     , SOL_FUN(Player, combatId)
    //     , SOL_FUN(Player, createAllPawn)
    //     , SOL_FUN(Player, data)
    //     , SOL_FUN(Player, draw)
    //     , SOL_FUN(Player, energy)
    //     , SOL_FUN(Player, gold)
    //     , SOL_FUN(Player, getCombat)
    //     , SOL_FUN(Player, getCombatPawnByIndex)
    //     , SOL_FUN(Player, getDeckPawnNumber)
    //     , SOL_FUN(Player, getHandPawnByIndex)
    //     , SOL_FUN(Player, getHandPawnNumber)
    //     , SOL_FUN(Player, getMaxCombatPawnNumber)
    //     , SOL_FUN(Player, getPawnByUid)
    //     , SOL_FUN(Player, hp)
    //     , SOL_FUN(Player, hasPawn)
    //     , SOL_FUN(Player, hasPawnUid)
    //     , SOL_FUN(Player, hit)
    //     , SOL_FUN(Player, maxEnergy)
    //     , SOL_FUN(Player, minus)
    //     , SOL_FUN(Player, plus)
    //     , SOL_FUN(Player, release)
    //     , SOL_FUN(Player, recover)
    //     , SOL_FUN(Player, summon)
    //     //                , SOL_FUN(Player, toDisplay)
    //     , SOL_FUN(Player, turnEnd)
    //     , SOL_FUN(Player, uid)
    //     //跟内存有关的操作，感觉不应该导出到lua
    //     // , "releasePawn", sol::overload()
    //     );

    (void)_lua.new_usertype<Player>("Player", sol::no_constructor
        // 创建玩家的时候回一起创建所有的棋子，所以不支持单独创建棋子
        // , SOL_FUN(Player, addPawn)
        , SOL_FUN(Player, uid)
        , SOL_FUN(Player, gold)
        , SOL_FUN(Player, maxEnergy)
        , SOL_FUN(Player, energy)
        , SOL_FUN(Player, hp)
        , SOL_FUN(Player, getMaxCombatPawnNumber)
        , SOL_FUN(Player, getHandPawnNumber)
        , SOL_FUN(Player, getDeckPawnNumber)
        , SOL_FUN(Player, check)
        , SOL_FUN(Player, getCombatPawnByIndex)
        , SOL_FUN(Player, getHandPawnByIndex)
        , SOL_FUN(Player, getPawnByUid)
        , SOL_FUN(Player, hasPawn)
        , SOL_FUN(Player, hasPawnUid)
        , SOL_FUN(Player, getHandPawnSize)
        // void release();
        , SOL_FUN(Player, combatId)
        // void createAllPawn();
        , SOL_FUN(Player, draw)
        // , SOL_FUN(Player, turnEnd)
        , SOL_FUN(Player, summon)
        , SOL_FUN(Player, recover)
        , SOL_FUN(Player, hit)
        , SOL_FUN(Player, opHp)
        , SOL_FUN(Player, opEnergy)
        , SOL_FUN(Player, opGold)
        , SOL_FUN(Player, opMaxEnergy)
        // , SOL_FUN(Player, plus)
        // , SOL_FUN(Player, minus)
        // , SOL_FUN(Player, to)
        //                , SOL_FUN(Player, toDisplay)
        , SOL_FUN(Player, getCombat)
        // PlayerS* data();
        );
#pragma endregion 

    //endregion

    //region IBuff 的声明
#pragma region IBuff
    // (void)_lua.new_usertype<IBuff>(
    //     "IBuff", sol::no_constructor
    //     , SOL_FUN(IBuff, baseType)
    //     , SOL_FUN(IBuff, create)
    //     , SOL_FUN(IBuff, clone)
    //     , SOL_FUN(IBuff, damageType)
    //     , SOL_FUN(IBuff, damage)
    //     , SOL_FUN(IBuff, destroy)
    //     , SOL_FUN(IBuff, dispose)
    //     , SOL_FUN(IBuff, getOwner)
    //     , SOL_FUN(IBuff, getMachine)
    //     , SOL_FUN(IBuff, getSource)
    //     , SOL_FUN(IBuff, id)
    //     , SOL_FUN(IBuff, invoke)
    //     , SOL_FUN(IBuff, maxOverlay)
    //     , SOL_FUN(IBuff, maxTime)
    //     , SOL_FUN(IBuff, overlay)
    //     , SOL_FUN(IBuff, release)
    //     , SOL_FUN(IBuff, reset)
    //     , SOL_FUN(IBuff, restTime)
    //     , SOL_FUN(IBuff, sourcePawn)
    //     , SOL_FUN(IBuff, toDisplay)
    //     , SOL_FUN(IBuff, targetId)
    //     , SOL_FUN(IBuff, test)
    //     , SOL_FUN(IBuff, unique_id)
    //     );

    (void)_lua.new_usertype<IBuff>(
        "IBuff", sol::no_constructor
        // , SOL_FUN(IBuff, data)
        // , SOL_FUN(IBuff, clone)
        , SOL_FUN(IBuff, reset)
        // , SOL_FUN(IBuff, release)
        , SOL_FUN(IBuff, getMachine)
        , SOL_FUN(IBuff, id)
        , SOL_FUN(IBuff, unique_id)
        , SOL_FUN(IBuff, maxTime)
        , SOL_FUN(IBuff, restTime)
        , SOL_FUN(IBuff, targetId)
        , SOL_FUN(IBuff, sourcePawn)
        , SOL_FUN(IBuff, damage)
        , SOL_FUN(IBuff, damageType)
        , SOL_FUN(IBuff, maxOverlay)
        , SOL_FUN(IBuff, primaryOverlay)
        , SOL_FUN(IBuff, overlay)
        , SOL_FUN(IBuff, baseType)
        , SOL_FUN(IBuff, test)
        , SOL_FUN(IBuff, callOverlay)
        // , SOL_FUN(IBuff, sourcePawn)
        , SOL_FUN(IBuff, getOwner)
        , SOL_FUN(IBuff, getSource)
        // , SOL_FUN(IBuff, toDisplay)
        );
#pragma endregion 
    //endregion

    //region Combat的声明
#pragma region Combat
    // typedef bool(Combat::* addPlayer)(int uid, std::vector<int> v);
    // addPlayer f = &Combat::addPlayer;
    // //导出api，在lua端添加玩家
    // (void)_lua.new_usertype<Combat>(
    //     "Combat", sol::no_constructor
    //     , "addPlayer", sol::overload(f)
    //     // , SOL_FUN(Combat, addPlayer)
    //     // , SOL_FUN(Combat, f)
    //     , SOL_FUN(Combat, allocPawnId)
    //     , SOL_FUN(Combat, end)
    //     , SOL_FUN(Combat, getPawnByUid)
    //     , SOL_FUN(Combat, getCurTurn)
    //     , SOL_FUN(Combat, getEnemy)
    //     , SOL_FUN(Combat, getMachine)
    //     , SOL_FUN(Combat, getNextPlayer)
    //     //                , SOL_FUN(Combat, getPawnById)
    //     , SOL_FUN(Combat, getPlayer)
    //     , SOL_FUN(Combat, getWorkPlayer)
    //     , SOL_FUN(Combat, hasPlayer)
    //     , SOL_FUN(Combat, id)
    //     , SOL_FUN(Combat, nextFlow)
    //     , SOL_FUN(Combat, release)
    //     // , SOL_FUN(Combat, releasePlayer)
    //     , SOL_FUN(Combat, start)
    //     );

	//TurnState枚举类型
    _lua.new_enum("TurnState",
        "invalid", TurnState::invalid,
        "prepare", TurnState::prepare,
        "start", TurnState::start,
        "battle", TurnState::battle,
        "over", TurnState::over
    );

    typedef bool(Combat::* addPlayer)(int uid, std::vector<int> v);
    addPlayer f = &Combat::addPlayer;
    //导出api，在lua端添加玩家
    (void)_lua.new_usertype<Combat>(
        "Combat", sol::no_constructor
        , "addPlayer", sol::overload(f)
        // , SOL_FUN(Combat, addPlayer)
        // , SOL_FUN(Combat, f)
        , SOL_FUN(Combat, id)
        , SOL_FUN(Combat, hasPlayer)
        , SOL_FUN(Combat, getPlayer)
        , SOL_FUN(Combat, getPawnByUid)
        , SOL_FUN(Combat, turnEnd)
        , SOL_FUN(Combat, start)
        , SOL_FUN(Combat, over)
        , SOL_FUN(Combat, getEnemy)
        , SOL_FUN(Combat, getWorkPlayer)
        , SOL_FUN(Combat, getNextPlayer)
        , SOL_FUN(Combat, getCurState)
        // int allocPawnId();
        , SOL_FUN(Combat, getCurTurn)
        , SOL_FUN(Combat, getMachine)
        // BuffMachine* getMachine();
        // , SOL_FUN(Combat, nextFlow)
        );
#pragma endregion 
    //endregion

    //还在考虑要不要导出BuffMachine的api？
    //如果导出buffMachine的话，意味着可以通过脚本来随意创建buff
    //region BuffMachine的声明
#pragma region BuffMachine
    typedef  bool(BuffMachine::* Execute1)(IBuff*);
    typedef  bool(BuffMachine::* Execute2)(int);
    Execute1 execute1 = &BuffMachine::buffExecute;
    Execute2 execute2 = &BuffMachine::buffExecute;
    (void)_lua.new_usertype<BuffMachine>(
        "Combat", sol::no_constructor
        , SOL_FUN(BuffMachine, create)
        , SOL_FUN(BuffMachine, executeAll)
        , SOL_FUN(BuffMachine, getRoomId)
        , SOL_FUN(BuffMachine, getBindRoom)
        , SOL_FUN(BuffMachine, getBuffByUid)
        // void release(int buffUid);
        // void release(IBuff* buff);
        , "buffExecute" , sol::overload(execute1, execute2)
        , SOL_FUN(BuffMachine, getBuffLength)
        , SOL_FUN(BuffMachine, getBuffLengthByType)
        );
#pragma endregion 
    //endregion

#pragma region Damage
    // bool isHeal;        //是否是治疗量        //额外增加的一个字段表示当前的到底是伤害还是治疗
    // int value;          //原始的伤害数值
    // int curValue;       //当前伤害的数值
    // int damageType;     //原始伤害类型    有可能某个buff会将魔法伤害转化成纯粹伤害  //技能的伤害类型   0、无意义   1、物理伤害 2、魔法伤害 3、神圣伤害 4、治疗
    // int curDamageType;  //当前伤害类型
    // Pawn* source;         //伤害或者治疗的来源   //如果cs要使用的话，这里直接定义成IntPtr就行了
    // Pawn* target;         //伤害或者治疗的目标
	
    (void)_lua.new_usertype<Damage>("Damage", sol::constructors<void(void), void(bool, int, int ,Pawn*, Pawn*)>()
        // , "1111", sol::readonly(&Damage::isHeal)
        , "isHeal", &Damage::isHeal
        , "value", &Damage::value
        , "curValue", &Damage::curValue
        , "damageType", &Damage::damageType
        , "curDamageType", &Damage::curDamageType
        , "source", &Damage::source
        , "target", &Damage::target
        );
#pragma endregion 
	
}

void LuaFramework::entry()
{
    std::string root = AgentMgr::instance()->curAgent()->getRoot().data();
    root += "/script/entry.lua";
    std::filesystem::path dir(root);
    if (exists(dir))
    {
        (void)_lua.script_file(dir.generic_string());
    }
}

void LuaFramework::script(int combatId, int buffId, ActionType type, Pawn *source, Pawn *target, int uid)
{
    // TODO
	
}

void LuaFramework::script(int combatId, int buffId, ActionType type, Damage* damage, int uid)
{
    // TODO
	
}

// void LuaFramework::script(int combatId, int uid, LuaFunctionName name)
// {
// 	
// }

// bool LuaFramework::newLuaBuff(int combatId, int buffId, int uid)
// {
// 	return true;
// }
//
// sol::optional<sol::table> LuaFramework::getLuaBuff(int combatId, int uid)
// {
//     auto it = _instanceBuffList.find(combatId);
//     if (it != _instanceBuffList.end())
//     {
//         // const auto& s = it->second;
//         // sol::table nn = _lua["nn"].get<sol::table>();
//         // sol::table luaBuffList = nn.get<sol::table>("LuaBuffList");
//         // sol::function(luaBuffList.get<sol::function>()).call<>();
//     }
//     return std::nullopt;
// }
//
// void LuaFramework::releaseLuaBuff(int combatId, int uid)
// {
// 	
// }

lua_State *LuaFramework::getLuaStack()
{
    return _lua.lua_state();
}
