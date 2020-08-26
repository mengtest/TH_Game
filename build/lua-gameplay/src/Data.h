#pragma once

#include <ostream>
#include "Base.h"

class Pawn;

//这个文件存放所有的不带方法的纯struct

//感觉所有的数据都应该分成原始数据、运行期数据、显示数据

//以下所有S(struct)结尾的类全部是cpp端存储的数据实体类，这些数据不做传输处理
//传输到其他端的类全部是以D(display)结尾的


//如果是网络模式，则只走联网的逻辑，不会加载本地的脚本（需要保证本地的脚本与客户端脚本中相同的脚本完全相同）
//如果是单机模式，则只走离线的逻辑，会去加载本地的脚本

//在默认的玩法(战斗系统中)，不存在浮点数，所有的东西全部是整形数，扩展的字段是一半、全部


//现在面临一个问题，就是要如何将通过脚本创建的棋子给显示出来？
//  1、在C#端读取到这些脚本中数据的部分并显示出来            //直接使用这个方案吧，免得还要在C++这边在存储这些数据


//可以在脚本中自定义一个buff
//也可以在脚本中自定义一个技能，但是不允许自定义一个棋子，棋子只能通过配置表来生成
struct BuffS
{
    int id;
    int unique_id;                          //产生buff时，会被分配一个唯一的id
    // int careTags[BUFF_TAG_LENGTH];          //这个buff感兴趣的tag
    // int tags[BUFF_TAG_LENGTH];              //该buff自身带有的tag，用于与其他buff交互
    int maxTime;                            //最大持续时间，-1表示永久
    int restTime;                           //buff的剩余时间
    //现在修改为buff为一个整体的类，而不是数据+单独的函数，所有这个字段移除
    // int attachFunctionId;                   //真正调用buff的函数id，这个函数从lua、cs、js来，这是一个额外的扩展，专用于一些特殊的buff
    int targetId;                           //buff影响的目标的id
    int sourcePawn;                         //谁给的这个buff
    int damage;                             //buff的伤害
    int damageType;                         //buff的伤害类型     0、无意义   1、物理伤害 2、魔法伤害 3、神圣伤害 4、治疗
    int maxOverlay;                         //最大叠加层数       0、无意义 1、不可叠加(有这个buff就表示有一层)   2、最大两层 3、最大三层 。。。 -1、可无限叠加
    int overlay;                            //当前叠加的层数
    int primaryOverlay;                     //buff的初始叠加层数
    //与baseType搭配使用，表示影响的目标属性的具体数值
    //正值表示增加(无论是否是增益效果)，复制表示减小
    int value;                           //影响的属性         0、不影响任何属性 1、攻击力 2、防御力 3、魔法攻击力 4、魔法防御力
    // buff的基础类型    0、表示特殊类型，需要做特殊处理，否则的话表示是基础类型，直接从预定好的处理方式中直接调用
    // 0表示是
    // 预定义的意义参考Constant中的定义
    int baseType;

	//新增字段，是否是增益(buff)
    bool benefit;

    friend std::ostream &operator<<(std::ostream &os, const BuffS &s);
};

struct PawnS
{
    int id;
    int unique_id;                          //单次战斗中会被分配的唯一id(每次战斗开始的时候，会获取所有玩家当前的所有卡牌，同时为这些卡牌分配唯一的id)
    int hp;                                 //生命值
    int mp;                                 //魔法值
    int matk;                               //魔法攻击力
    int atk;                                //攻击力
    int def;                                //防御力
    int mdef;                               //魔法防御力
    int buffs[PAWN_BUFF_LENGTH];            //当前棋子身上所有的buff,最大为30个
    int skills[PAWN_SKILL_LENGTH];          //棋子可以使用的技能，最大为5个
    int playerId;                           //持有这个棋子的玩家id
    int type;                               //n、r、sr、ssr
    int posType;                            //当前棋子所在的位置类型 0、无效 1、卡池 2、手卡 3、棋盘中
    int pos;                                //当前棋子所在的位置，这里对应当前所在的位置类型中数组的下标，-1表示无效

    friend std::ostream &operator<<(std::ostream &os, const PawnS &s);
};

struct SkillS
{
    int id;
    int buffs[SKILL_BUFF_LENGTH];               //该技能会产生的buff，最大为5个
    int cost;                                   //使用技能所需要的消耗
    int costType;                               //消耗的类型2   0、无消耗  1、HP 2、MP 3、能量(玩家拥有的一项属性)
    int targetType;                             //目标类型      0、自己 1、单个队友 2、单个队友不包含自己 3、单个敌人 4、所有人 5、所有人不包含自己 6、自己玩家 7、敌方玩家 8、随机的单个敌方棋子 9、随机的单个友方棋子 10、随机的玩家 11、所有友军 12、所有敌军
    int sourcePawn;                             //使用这个技能的棋子的id
    int damage;                                 //技能产生的伤害
    int damageType;                             //技能的伤害类型   0、无意义   1、物理伤害 2、魔法伤害 3、神圣伤害 4、治疗
    int passive;                                //是否是被动，如果是被动的话则产生buff的同时不会添加到buff列表中   只有0、1两个值与bool的意义一样
    int disperse;                               //是否驱散， 0、表示不驱散 1、表示驱散所有debuff 2、表示驱散所有buff 3、表示驱散任意一个增益效果 4、表示驱散任意一个减益效果 5、表示驱散全部

    friend std::ostream &operator<<(std::ostream &os, const SkillS &s);
};

struct PlayerS
{
    int uid;
    int cards[DECK_CARD_NUM];                          //本次战斗，该玩家所选择的卡组信息       这里是id而非unique_id
    int pawns[DECK_CARD_NUM];                          //当前玩家持有的所有卡牌的信息           这里应该是unique_id
    int handCards[HAND_CARD_NUM];           //该玩家手上持有的卡牌信息              这里应该是unique_id
    int combatCards[8];                     //该玩家正在战斗的卡牌信息              这里应该是unique_id
    int deckCards[DECK_CARD_NUM];                      //卡池中所有的卡牌信息                  这里应该是unique_id
    int hp;                                 //玩家剩余的血量
    int maxHp;                              //最大血量
    int energy;                             //玩家当前的能量
    int maxEnergy;                          //玩家所能拥有的最大能量，指的是每回合开始，玩家拥有的初始能量
    int gold;                               //玩家当前所持有的金币数

    friend std::ostream &operator<<(std::ostream &os, const PlayerS &s);
};

struct BuffD
{
    int id;
    int restTime;               //buff的剩余时间
    int unique_id;              //为这个buff分配的uid
    int overlay;

    friend std::ostream &operator<<(std::ostream &os, const BuffD &d);
};

struct PawnD
{
    //棋子拥有的技能是相对固定的，只要知道是什么棋子就能知道这个棋子有哪些技能，所以不返回棋子技能的信息
    int id;
    int unique_id;          //单次战斗中会被分配的唯一id(每次战斗开始的时候，会获取所有玩家当前的所有卡牌，同时为这些卡牌分配唯一的id)
    int hp;                 //生命值
    int mp;                 //魔法值
    int matk;               //魔法攻击力
    int atk;                //攻击力
    int def;                //防御力
    int mdef;               //模仿防御力
    int playerId;           //持有这个棋子的玩家id
    int type;               //n、r、sr、ssr
    int posType;            //当前棋子所在的地方的类型
    int pos;                //棋子所在的下标

    friend std::ostream &operator<<(std::ostream &os, const PawnD &d);
};

struct PlayerD
{

};

// //当前战斗中某个物体的属性发生变化的结构体
// struct AttrUpdateMsg
// {
//     int id;                     //玩家的id
//     int type;                   //1、玩家 2、棋子 3、buff
//     int objId;                  //属性变化了的对象id， 如果是玩家的属性可以不传这个
//     int attr;                   //属性的id
//     int value;                  //属性的值
// };

struct Config
{
    int normalDrawPrice;        //抽一次普通卡牌所需要的钱
    int highDrawPrice;          //抽一次高级卡牌所需要的钱
    int normal_nPercent;        //普通卡牌出n的概率  所有的概率都是万分比
    int normal_rPercent;        //普通卡牌出r的概率
    int normal_srPercent;       //         sr的概率
    int normal_ssrPercent;      //         ssr的概率
    int high_nPercent;          //高级卡牌出n的概率
    int high_rPercent;          //         r的概率
    int high_srPercent;         //         sr的概率
    int high_ssrPercent;        //         ssr的概率
    int primaryGold;            //初始金钱
    int salary;                 //每回合发放的金币
    int roundCard;              //每回合给的卡牌数量（普通）
    int primaryCard;            //初始的卡牌数量
    int maxRound;               //最大回合数
    int primaryEnergy;          //初始能量
    int energyGrow;             //每回合能量成长
    int maxEnergy;              //最大能量
    int primaryHp;              //初始血量
    int maxHp;                  //血量上限

    friend std::ostream &operator<<(std::ostream &os, const Config &config);
};

struct Damage
{
    //比如说dota里面的亚巴顿的大招会将伤害全部转化为治疗
    bool isHeal;        //是否是治疗量        //额外增加的一个字段表示当前的到底是伤害还是治疗
    int value;          //原始的伤害数值
    int curValue;       //当前伤害的数值
    int damageType;     //原始伤害类型    有可能某个buff会将魔法伤害转化成纯粹伤害  //技能的伤害类型   0、无意义   1、物理伤害 2、魔法伤害 3、神圣伤害 4、治疗
    int curDamageType;  //当前伤害类型
    Pawn* source;         //伤害或者治疗的来源   //如果cs要使用的话，这里直接定义成IntPtr就行了
    Pawn* target;         //伤害或者治疗的目标

    Damage(bool isHeal, int value, int curValue, int damageType, int curDamageType, Pawn* source, Pawn* target)
        : isHeal(isHeal), value(value), curValue(curValue), damageType(damageType), curDamageType(curDamageType),
        source(source),
        target(target)
    {

    }

    Damage(bool isHeal, int value, int damageType, Pawn* source, Pawn* target)
        : isHeal(isHeal),
        value(value),
        curValue(value),
        damageType(damageType),
        curDamageType(damageType),
        source(source),
        target(target)
    {

    }

    Damage() {}

    friend std::ostream &operator<<(std::ostream &os, const Damage &damage);
};

enum class Op
{
	plus,
	minus,
};

//战斗系统初始化所需要的玩家信息，因为可能会增加额外的信息，所以还是做成了结构体
struct CombatRequirePlayer
{
    int uid;                    //玩家的uid
    int cards[DECK_CARD_NUM];              //玩家当前所选择的卡组
};

struct AttrStruct
{
    int combatId;   //战斗实例的id
    int playerId;   //目标玩家的id，如果发给当前房间所有玩家，则设置为0
    int objectId;   //属性改变了的目标对象的id(比如棋子的id，buffId，如果是玩家，可以不传)
    int value;      //属性改变后的值
    int type;       //改变的是哪项属性(具体参考constant里面例举的值)
    int targetType; //新增属性，表示当前对象表示是哪种类型的，0、无效 1、棋子 2、玩家 3、buff 4、战斗本身

    friend std::ostream &operator<<(std::ostream &os, const AttrStruct &aStruct);
};

//struct Msg
//{
//
//};