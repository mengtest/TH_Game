#pragma once

#include <vector>
#include <map>
#include "Data.h"
#include "3rd.h"

class Player;
class LuaBuff;
class Pawn;
class IBuff;
class Buff;
class Combat;

using BuffList = std::vector<BuffS*>;

//这里可能在最后会是ScriptBuff
using UserBuffList = std::map<int, LuaBuff*>;

class BuffMachine
{
private:
	static BuffList _originBuffs;

	//这个就是原始的脚本buff，是一个lua表
	static UserBuffList _scriptBuffs;

public:
	static void loadAll(BuffList& buffs);

	//这里主要就是添加自定义的buff例如LuaBuff
	static bool addBuff(LuaBuff* buff);

	static void clearScriptBuff();
	
	static bool addBuff(sol::table tb);

	static bool contain(int id);

	static void clearAllScriptBuff();

	//从原始数据中删除一个buff
	//主要指的就是删除LuaBuff
	static void removeBuff(int id);
private:
	std::map<int, IBuff*> _buffs;

	int _maxId = 0;

	//当前buff机所在的战斗
	Combat* _combat;

	//要展示的buff，每次获取的时候都会重新赋值
	BuffD* _display;

	/**
	 * \brief 为一个buff分配运行期唯一的id
	 * \return 分配的id
	 */
	int allocBuffId();

	/**
	 * \brief 添加一个buff到当前的buff机中
	 * \param buff
	 * \return 0表示插入失败、1表示插入成功、2表示非插入(叠加或者重置时间)
	 */
	int insertBuffToList(IBuff* buff);

public:
	//释放当前buff机中所有的内存
	//所有直接操作内存的api都不会导出
	void release();

	// //释放一个pawn相关所有的buff
	// [[maybe_unused]]void release(Pawn* pawn);

	/**
	 * \brief 构建一个新的buff,buff创建成功就会被添加到buff机中，
	 * 后续添加(mount)到具体哪个棋子身上需要脚本去完成
	 *  正确的创建buff的流程：
	 *		1、BuffMachine::create	创建buff
	 *		2、Pawn::mount			挂载buff到目标棋子身上
	 *		
	 * \param pawn buff的来源
	 * \param id 要创建的buff的id
	 * \return 创建失败则返回空指针
	 */
	IBuff* create(Pawn* pawn, int id);

	// /**
	//  * \brief 构建一个新的buff,buff创建成功就会被添加到buff机中，
	//  * 后续添加(mount)到具体哪个棋子身上需要脚本去完成
	//  *  正确的创建buff的流程：
	//  *		1、BuffMachine::create	创建buff
	//  *		2、Pawn::mount			挂载buff到目标棋子身上
	//  *
	//  * \param pawn buff的来源
	//  * \param id 要创建的buff的id
	//  * \return
	//  */
	// IBuff* create(int id);

	/**
	 * \brief 指定玩家所有场上的棋子身上的buff都执行一次
	 * \param player
	 */
	void executeAll(Player* player);

	explicit BuffMachine(Combat* combat);

	//获取当前buff机所在的房间的id
	int getRoomId();

	//获取到当前buff机所属的房间
	Combat* getBindRoom();

	//根据uid获取目标buff，如果没有则返回空
	IBuff* getBuffByUid(int uid);

	// //添加指定的buff到指定的棋子身上
	// [[deprecated]] void addBuffToPawn(Pawn* pawn, IBuff* buff);
	//
	// //添加指定的buff到指定的棋子身上
	// [[deprecated]] void addBuffToPawn(Pawn* pawn, int buffId);

	//释放一个buff的空间
	void release(int buffUid);

	//注意：buff接口中的release做自己的release调用，同时调用buffMachine的release
	//buff机中只做buff机中相关的清除,这一步操作完成之后，这个buff就没有了
	//另外：由于buff是buff机创建的，所以也应当由buff机来释放内存
	//释放一个buff的空间
	void release(IBuff* buff);

	/**
	 * \brief 将buff转化成前端需要的纯数据形式
	 * \param buff
	 * \return 
	 */
	BuffD* toDisplay(IBuff* buff);

	/**
	 * \brief 根据uid获取buff的display信息
	 * \param uid
	 * \return
	 */
	BuffD* toDisplay(int uid);

	/**
	 * \brief 一个回合结束，执行某些buff的操作
	 */
    [[maybe_unused]] void tick();

	// /**
	//  * \brief 创建一个buff实例对象,同时将buff添加到目标棋子身上
	//  * \param id buff的名称
	//  * \param sourceId buff的来源
	//  * \param pawnId 给对应的棋子这个buff
	//  * \return buff的实例对象，创建失败的话，就会返回空指针
	//  */
	// IBuff* createBuff(int id, int sourceId, int pawnId);

	/**
	 * \brief 执行一个buff
	 * \param buff buff对象本身
	 * \return 是否成功执行
	 */
    bool buffExecute(IBuff* buff);

	bool buffExecute(int buffId);

	int getBuffLength(int pawnId);

	int getBuffLengthByType(int type);

	~BuffMachine();
};
