#pragma once

#include <vector>
#include "Data.h"

class IBuff;
class Player;

//TODO 一定要实现自己的跳表
template<class T>
using SkipList = std::vector<T>;

//棋子不管理buff，但是会保有所有的buff的引用
//依旧是由BuffMachine管理所有的buff
class Pawn
{
private:
    PawnS *_data = nullptr;

    PawnD *_display = nullptr;

    Player *_player = nullptr;

    //如果查找与增删操作都多的话，应该用什么数据结构
    SkipList<IBuff *> _buffs;

    Pawn() = default;

    static Pawn *create(PawnS *data, int uid);

public:
    ~Pawn();

    PawnS *data();

    PawnD *toDisplay();

    int id();

    int unique_id();

    int hp();

    int mp();

    int matk();

    int atk();

    int def();

    int mdef();

    int type();

    size_t getBuffSize();

    //根据下标获取一个buff对象
    //但是buff是通过list存储的
    IBuff *getBuffByIndex(int index);

    IBuff *getBuffById(int id);

    IBuff *getBuffByUid(int uid);

    bool containBuff(int buffId);

    bool hasSkill(int id);

    Player *getOwner();

    //只在创建的时候会被调用一次，以后再调用不会生效
    //将当前棋子添加到目标玩家下面
    void addTo(Player *player);

    //当前棋子所在的位置类型 0、无效 1、卡池 2、手卡 3、棋盘中
    int posType();

    //当前棋子所在的位置坐标
	//这个只有在这个棋子在棋盘当中的时候才有意义，在卡池或者手牌中的时候，这个字段是没有意义的
    int pos();

    //将棋子移动到手牌中
    bool moveToHand();

    //将棋子移动到卡池中
    bool moveToDeck();

    //将棋子移动到棋盘中
    bool moveToPanel(int pos);

    //挂载一个buff
    //挂载buff的话，行为其实是确定的，所以会触发特殊调用
    int mount(IBuff *buff);

    //取消挂载一个buff
    //这个api不暴露给脚本
    //这个脚本不会调用任何buff自身的特殊函数
    int unmount(IBuff *buff);

    //取消挂载一个buff
    //脚本中只暴露这个api，
    //这个脚本不会调用任何buff自身的特殊函数
    //这种就是单纯的取消挂载一个buff
    int unmount(int buffId);

    //受到伤害
    bool hit(Damage *damage);

    //攻击目标
    bool attack(Pawn *target);

    //对玩家发动攻击，但是实际上只能对与自己对位的棋子发动攻击
    //如果对位的位置上没有棋子，则会对敌人直接发动攻击
    bool attack(Player *player);

    //使用技能
    //不会产生任何消耗
    bool useSkill(Pawn *target, int skillId);

    //使用技能
    //会产生消耗
    bool useSkillWithCost(Pawn *target, int skillId);

    //受到技能的影响
    bool sufferSkill(Pawn *source, int skillId);

    //治疗
    int heal(Damage *damage);

    //重置当前棋子的状态
    void reset();

    /**
     * \brief 棋子死亡
     * \param priority 死亡时间的优先级，正常死亡的优先级为100，优先级越低则约束越强 
     * \return 棋子是否真正死亡
     */
    bool dead(int priority = 100);

    //消耗当前棋子对应的可消耗的值
    int cost(int type, int value);

    //检测当前棋子是否有足够的对应数量的可消耗的值
    bool check(int type, int value);

    /**
     * \brief 棋子是否存活(在棋盘中),棋子死亡时会立即将其移动至卡池中
     */
    bool alive();

    //释放当前棋子所有的内存
    void release();

    //检测当前棋子是否能够执行某个操作
    //这里的action包含有攻击、使用技能、
    //action的意义是0、无意义 1、攻击 2、使用技能
    bool checkAction(int action);

  //   /*
  //    * 任何属性上的变化都会反映到客户端当中
  //    * 对应的属性增加，约定棋子的属性为
  //    * 1、hp
  //    * 2、mp
  //    * 3、攻击力
  //    * 4、防御力
  //    * 5、魔法值
  //    * 6、魔法攻击力
  //    * 7、魔法防御力
  //    */
  //   void plus(int type, int value);
  //
  //   /*
	 // * 对应的属性减少，约定棋子的属性为
	 // * 1、hp
	 // * 2、mp
	 // * 3、攻击力
	 // * 4、防御力
	 // * 5、魔法值
	 // * 6、魔法攻击力
	 // * 7、魔法防御力
	 // */
  //   void minus(int type, int value);

  //   /*
	 // * 修改棋子的属性至对应的值
	 // * 1、hp
	 // * 2、mp
	 // * 3、攻击力
	 // * 4、防御力
	 // * 5、魔法值
	 // * 6、魔法攻击力
	 // * 7、魔法防御力
	 // */
  //   void to(int type, int value);

    void opHp(int value);

    void opMp(int value);

    void opAtk(int value);

    void opDef(int value);

    void opMatk(int value);

    void opMdef(int value);

    friend class PawnMgr;
};
