#pragma once

#include <map>
#include "Data.h"
#include <list>
#include <vector>
#include <optional>

class Combat;
class Pawn;

//由玩家管理所有的棋子
class Player
{
private:
	using DeckPawnList = std::list<int>;

	PlayerS* _data = nullptr;

	std::map<int, Pawn*> _allPawns;

	//以下所有的数据全部都是uid
	std::list<int> _handPawns;

	int _panel[PANEL_LENGTH] = { 0 };

	//当前卡池中的n卡
	std::list<int> _nPawns;

	//当前卡池中的r卡
	std::list<int> _rPawns;

	//当前卡池中的sr卡
	std::list<int> _srPawns;

	//当前卡池中的ssr卡
	std::list<int> _ssrPawns;

	//当前卡池中的sp卡
	std::list<int> _spPawns;

	Combat* _combat;

	//为当前玩家添加一个棋子,在初始化的时候调用这个
	void addPawn(Pawn* pawn);

	/**
	 * \brief 根据下标获取一个卡池中的棋子
	 * \param index 
	 * \param type 1、n 2、r 3、sr 4、ssr
	 * \return 目标棋子的uid
	 */
	int getDeckPawnByIndex(int index, int type);

	/**
	 * \brief 随机获取一个卡池中的棋子
	 * \param type 1、n 2、r 3、sr 4、ssr
	 * \return 目标棋子的uid,如果返回-400表示棋子的类型错误，如果没有对应类型的棋子，则返回-1
	 */
	int getDeckPawnRandom(int type);

	/**
	 * \brief 随机获取一个卡池中的棋子
	 * \param type 1、n 2、r 3、sr 4、ssr
	 * \return 目标棋子的uid
	 */
	std::optional<DeckPawnList::iterator> getDeckPawnItRandom(int type);

	bool removeIt(DeckPawnList::iterator it, int type);
public:
	/**
	 * 导出操作当前对象的所有函数
	 * 1、抽卡
	 * 2、结束回合
	 * 3、扣除金币
	 * 4、增加金币
	 * 5、增加能量点
	 * 6、减少能量点
	 * 7、增加最大能量点
	 * 8、减少最大能量点
	 * 9、掉血
	 * 10、回血
	 * 11、召唤棋子
	 * 。。。
	 */

	//player不需要分配uid，直接从传入的数据中取出id就行了
	Player(CombatRequirePlayer* info, Combat* combat);

	Player(int uid,const std::vector<int>& v, Combat* combat);

	~Player();

	int uid();

	int gold();

	int maxEnergy();

	int energy();

	int hp();

	bool hasPawnInCombat();

	int getMaxCombatPawnNumber();

	int getHandPawnNumber();

	int getDeckPawnNumber();

	//检测当前玩家的血量、能量等是否满足条件
	bool check(int type, int value);

	Pawn* getCombatPawnByIndex(int index);

	Pawn* getHandPawnByIndex(int index);

	Pawn* getPawnByUid(int uid);

	//是否含有目标id(非uid)的棋子
	bool hasPawn(int id);

	//是否含有目标id(非uid)的棋子
	bool hasPawnUid(int uid);

	//释放当前玩家的所有内存
	void release();

	//没什么卵用的api
	int combatId();

	//
	// //从当前的战斗中移除一个棋子(感觉是多余的,因为每场战斗中棋子的最大数量为40,无法添加新的棋子)
	// [[deprecated]] void removePawn(int uid);
	//
	// //从当前的战斗中移除一个棋子(感觉是多余的)
	// [[deprecated]] void removePawn(Pawn* pawn);

	void createAllPawn();

	void opGold(int value);
	
	void opEnergy(int value);
	
	void opMaxEnergy(int value);

	void opHp(int value);

	//抽卡
	bool draw(int number, bool high);

	//结束当前回合，这个是玩家的输入，但是感觉应该由combat来控制
	//没什么卵用，要结束当前玩家的回合，应该直接调用combat的turnEnd函数
	// [[deprecated]] void turnEnd();

	//让uid的棋子处于游离状态
	//并返回游离的棋子对象，如果没有这个棋子，则返回空
	Pawn* dissociate(int uid);

	//使目标棋子处于游离状态
	//在moveToXXX函数中判断是否能够 移动，如果能够移动则调用这个函数
	bool dissociatePawn(Pawn * pawn);

	int getHandPawnSize();

	// Pawn* getHandPawnByIndex(int index);

	//关联目标棋子
	//需要先调用棋子的moveToXXX函数
	//移动完毕之后调用这个函数
	bool relate(Pawn* pawn);
	
	//从手中召唤一个棋子到棋盘中
	void summon(int pawnUid, int pos);

	//将一个棋子收回到手中
	void recover(int pawnUid);

	//当前玩家受到伤害
	//玩家没有任何特殊效果，也不会受到任何特殊效果的影响
	//受到伤害时，也是直接减去对应的数值
	void hit(int damage);

	// /*
	//  * 玩家的属性增加,约定玩家的属性如下
	//  * 1、hp
	//  * 2、能量
	//  * 3、最大能量
	//  * 4、金币
	//  */
	// void plus(int type, int number);
	//
	// /*
	//  * 玩家的属性减少,约定玩家的属性如下
	//  * 1、hp
	//  * 2、能量
	//  * 3、最大能量
	//  * 4、金币
	//  */
	// void minus(int type, int number);

	//对应的属性设置成目标数值
	// void to(int type, int number);

	bool checkAction(int type);

	Combat* getCombat();

	PlayerS* data();

	//但是实际上感觉player的展示数据与运行期数据是高度相似的
	//可以直接使用同一份数据
	[[deprecated]]PlayerD* toDisplay();
};
