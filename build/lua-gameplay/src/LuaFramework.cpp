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
#include <filesystem>
#include <set>

// template<class T>
// void add(T a, T b)
// {
//     return a + b;
// }

int LuaFramework::id = 0;

LuaFramework* LuaFramework::_instance = nullptr;

//简化sol中函数的注册
#define SOL_FUN(_CLASS_, _FUN_)\
    #_FUN_, &_CLASS_::_FUN_

#define SOL_READONLY(_CLASS_, _PROPERTY_)\
	#_PROPERTY_, sol::readonly(&_CLASS_::_PROPERTY_)

// #define SOL_READONLY_PROPERTY(_PROPERTY_)\
//     #_PROPERTY_ , _PROPERTY_

void LuaFramework::free()
{    
	//这种写法可以正常运行吗？
    delete _instance;
    _instance = nullptr;
}

LuaFramework::LuaFramework(lua_State* L)
    : _lua(L)
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
    BuffMachine::clearAllScriptBuff();
}

LuaFramework* LuaFramework::constructor(lua_State* L)
{
	if (_instance == nullptr)
	{
        _instance = new LuaFramework(L);
        ylog("a new luaframework object");
        // Singleton::instance()->store(_instance);
	}
    else
    {
        // Singleton::instance()->release();
        delete _instance;
        _instance = nullptr;
        _instance = new LuaFramework(L);
        ylog("a new luaframework object");
        // Singleton::instance()->store(_instance);
    }
    return _instance;
}

LuaFramework* LuaFramework::instance()
{
	//如果没有的话，不会构造新的对象
	if (!_instance)
	{
        throw std::exception("must call constructor method before this");
	}
    return _instance;
}

sol::state& LuaFramework::lua()
{
    return _lua;
}

void LuaFramework::loadAll(const std::string& path)
{
	//目前版本的思路应该是，每个脚本文件代表一个棋子
	//脚本当中应当包含当前棋子的各种属性，以及技能的属性、buff的属性
	//以及各个buff的特殊处理函数
	//
	//而不是以前的，棋子、技能、buff分别存放在不同的脚本中
    std::string root = path + "/script/";
    ylog("root : {0}", root.c_str());
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
    // nn::nlogI(++id);
	
#pragma region nn名称空间下面所有的全局函数
    //region nn名称空间下面所有函数的声明
    sol::table nn = _lua["nn"].get_or_create<sol::table>();
    nn.set_function("log", sol::overload(nn::nlog, nn::nlogS, nn::nlogF, nn::nlogI));
    nn.set_function("create_combat", Export::create_combat);
    nn.set_function("get_combat", Export::get_combat);
	//战斗结束后自动销毁所有相关的内存，所以不需要手动去销毁
    nn.set_function("create_combat", Export::create_combat);
    nn.set_function("release_export", Export::release_export);
    nn.set_function("getConfig", Export::get_config);
    // nn.set_function("set_notice_fun", Export::set_notice_fun);
    // nn.set_function("set_update_fun", Export::set_update_fun);
    
	
    //endregion
#pragma endregion

#pragma region PawnD,BuffD,PlayerS

    _lua.new_usertype<Config>("Config", sol::no_constructor
        , SOL_READONLY(Config, normalDrawPrice)
        , SOL_READONLY(Config, highDrawPrice)
        , SOL_READONLY(Config, normal_nPercent)
        , SOL_READONLY(Config, normal_rPercent)
        , SOL_READONLY(Config, normal_srPercent)
        , SOL_READONLY(Config, normal_ssrPercent)
        , SOL_READONLY(Config, high_nPercent)
        , SOL_READONLY(Config, high_rPercent)
        , SOL_READONLY(Config, high_srPercent)
        , SOL_READONLY(Config, high_ssrPercent)
        , SOL_READONLY(Config, primaryGold)
        , SOL_READONLY(Config, salary)
        , SOL_READONLY(Config, roundCard)
        , SOL_READONLY(Config, maxRound)
        , SOL_READONLY(Config, primaryEnergy)
        , SOL_READONLY(Config, energyGrow)
        , SOL_READONLY(Config, maxEnergy)
        , SOL_READONLY(Config, primaryHp)
        , SOL_READONLY(Config, maxHp));

	
    //     //棋子拥有的技能是相对固定的，只要知道是什么棋子就能知道这个棋子有哪些技能，所以不返回棋子技能的信息
    // int id;
    // int unique_id;          //单次战斗中会被分配的唯一id(每次战斗开始的时候，会获取所有玩家当前的所有卡牌，同时为这些卡牌分配唯一的id)
    // int hp;                 //生命值
    // int mp;                 //魔法值
    // int matk;               //魔法攻击力
    // int atk;                //攻击力
    // int def;                //防御力
    // int mdef;               //模仿防御力
    // int playerId;           //持有这个棋子的玩家id
    // int type;               //n、r、sr、ssr
    // int posType;            //当前棋子所在的地方的类型
    // int pos;                //棋子所在的下标
    _lua.new_usertype<PawnD>("PawnD", sol::no_constructor
        , SOL_READONLY(PawnD, id)
        , SOL_READONLY(PawnD, unique_id)
        , SOL_READONLY(PawnD, hp)
        , SOL_READONLY(PawnD, mp)
        , SOL_READONLY(PawnD, matk)
        , SOL_READONLY(PawnD, atk)
        , SOL_READONLY(PawnD, def)
        , SOL_READONLY(PawnD, mdef)
        , SOL_READONLY(PawnD, playerId)
        , SOL_READONLY(PawnD, type)
        , SOL_READONLY(PawnD, posType)
        , SOL_READONLY(PawnD, pos)
        );

    // int id;
    // int restTime;               //buff的剩余时间
    // int unique_id;              //为这个buff分配的uid
    // int overlay;
    _lua.new_usertype<BuffD>("BuffD", sol::no_constructor
        , SOL_READONLY(BuffD, id)
        , SOL_READONLY(BuffD, restTime)
        , SOL_READONLY(BuffD, unique_id)
        , SOL_READONLY(BuffD, overlay)
        );

    // int uid;
    // int cards[DECK_CARD_NUM];                          //本次战斗，该玩家所选择的卡组信息       这里是id而非unique_id
    // int pawns[DECK_CARD_NUM];                          //当前玩家持有的所有卡牌的信息           这里应该是unique_id
    // int handCards[HAND_CARD_NUM];           //该玩家手上持有的卡牌信息              这里应该是unique_id
    // int combatCards[8];                     //该玩家正在战斗的卡牌信息              这里应该是unique_id
    // int deckCards[DECK_CARD_NUM];                      //卡池中所有的卡牌信息                  这里应该是unique_id
    // int hp;                                 //玩家剩余的血量
    // int maxHp;                              //最大血量
    // int energy;                             //玩家当前的能量
    // int maxEnergy;                          //玩家所能拥有的最大能量，指的是每回合开始，玩家拥有的初始能量
    // int gold;                               //玩家当前所持有的金币数
    _lua.new_usertype<PlayerS>("PlayerS", sol::no_constructor
        , SOL_READONLY(PlayerS, uid)
        , SOL_READONLY(PlayerS, hp)
        , SOL_READONLY(PlayerS, maxHp)
        , SOL_READONLY(PlayerS, energy)
        , SOL_READONLY(PlayerS, maxEnergy)
        , SOL_READONLY(PlayerS, gold)
        , "cards", sol::readonly_property([](PlayerS& player) {return std::ref(player.cards); })
        , "pawns", sol::readonly_property([](PlayerS& player) {return std::ref(player.pawns); })
		, "handCards", sol::readonly_property([](PlayerS& player) {return std::ref(player.handCards); })
		, "combatCards", sol::readonly_property([](PlayerS& player) {return std::ref(player.combatCards); })
		, "deckCards", sol::readonly_property([](PlayerS& player) {return std::ref(player.deckCards); })
        );
	
    //     int combatId;   //战斗实例的id
    // int playerId;   //目标玩家的id，如果发给当前房间所有玩家，则设置为0
    // int objectId;   //属性改变了的目标对象的id(比如棋子的id，buffId，如果是玩家，可以不传)
    // int value;      //属性改变后的值
    // int type;       //改变的是哪项属性(具体参考constant里面例举的值)
    // int targetType; //新增属性，表示当前对象表示是哪种类型的，0、无效 1、棋子 2、玩家 3、buff 4、战斗本身
    _lua.new_usertype<AttrStruct>("AttrStruct", sol::no_constructor
        , SOL_READONLY(AttrStruct, combatId)
        , SOL_READONLY(AttrStruct, playerId)
        , SOL_READONLY(AttrStruct, objectId)
        , SOL_READONLY(AttrStruct, value)
        , SOL_READONLY(AttrStruct, type)
        , SOL_READONLY(AttrStruct, targetType));
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
        , SOL_FUN(Pawn, toDisplay)
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
        , SOL_FUN(Pawn, getSkillVec)
        , SOL_FUN(Pawn, getSkillList)
        , SOL_FUN(Pawn, getSkillByIndex)
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
        , SOL_FUN(Player, hasPawnInCombat)
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
        // , SOL_FUN(Player, toDisplay)
        , SOL_FUN(Player, getCombat)
        // PlayerS* data();
        , SOL_FUN(Player, data)
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
        , SOL_FUN(IBuff, toDisplay)
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

#pragma region Config
    //     int normalDrawPrice;        //抽一次普通卡牌所需要的钱
    // int highDrawPrice;          //抽一次高级卡牌所需要的钱
    // int normal_nPercent;        //普通卡牌出n的概率  所有的概率都是万分比
    // int normal_rPercent;        //普通卡牌出r的概率
    // int normal_srPercent;       //         sr的概率
    // int normal_ssrPercent;      //         ssr的概率
    // int high_nPercent;          //高级卡牌出n的概率
    // int high_rPercent;          //         r的概率
    // int high_srPercent;         //         sr的概率
    // int high_ssrPercent;        //         ssr的概率
    // int primaryGold;            //初始金钱
    // int salary;                 //每回合发放的金币
    // int roundCard;              //每回合给的卡牌数量（普通）
    // int primaryCard;            //初始的卡牌数量
    // int maxRound;               //最大回合数
    // int primaryEnergy;          //初始能量
    // int energyGrow;             //每回合能量成长
    // int maxEnergy;              //最大能量
    // int primaryHp;              //初始血量
    // int maxHp;                  //血量上限


#pragma endregion
	
}

void LuaFramework::exportConfig(Config * config)
{
    
}

void LuaFramework::entry()
{
    std::string root = AgentMgr::instance()->curAgent()->getRoot().data();
    root += "/script/entry.lua";
    std::filesystem::path dir{ root };
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

void LuaFramework::script(AttrStruct* attr)
{
    // nn.set_function("set_notice_fun", Export::set_notice_fun);
    // nn.set_function("set_update_fun", Export::set_update_fun);
    ylog(fmt::format("attr: combatId {0}, objectId {1}, playerId {2}, targetType {3}, type {4}, value {5}"
        , attr->combatId
        , attr->objectId
        , attr->playerId
        , attr->targetType
        , attr->type
        , attr->value ));
    _lua["UpdateFun"].get_or_create<sol::function>().call(attr);
}

void LuaFramework::script(const std::string& str)
{
    _lua["NoticeFun"].get_or_create<sol::function>().call(str);
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
