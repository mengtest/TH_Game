#pragma once

#include <random>
#include <string>
#include <memory>
#include "Data.h"

/**
 * \brief 获取传入的参数的名称
 * \param __ARG__
 */
#define NAMEOF(__ARG__) (#__ARG__)

 /**
  * \brief 求静态数组的长度
  * \param __ARG__
  */
#define ARYSIZE(__ARG__) (sizeof( __ARG__ ) / sizeof( (__ARG__)[0] ))

  /**
   * \brief 将静态数组的所有元素设置为0
   * \param __ARG__
   */
#define MEMSET(__ARG__) Helper::memset( (__ARG__) , ( ARYSIZE(__ARG__) ) )

class StringBuilder
{
private:
	static StringBuilder* _instance;

	std::string _view;

	int _max;

	bool _call;

	StringBuilder() = default;
public:
	static StringBuilder& instance();

	const std::string& build();

	StringBuilder* push(const std::string& key, const std::string& value);

	template<class T>
	StringBuilder* push(const std::string& key, const T& value)
	{
		return push(key, std::to_string(value));
	}

	//棋子添加buff的字符串格式
	StringBuilder* push(const std::string& key, int pawnId, int buffId);

	//这里是hp回复或者收到伤害
	// StringBuilder* push(const std::string& key, int type, int from, int to);
};

// class LogImpl;

class Helper
{
private:
	static std::random_device r;
	static std::default_random_engine e;
	static float _seed;
	//是否使用帧同步
	static bool _useFrame;
public:
	Helper() = delete;

	//帧同步的种子使用这个
	static void seed(float s);

	static float seed();

	static int random(int min, int max);

	static float random(float min, float max);

	static float random();

	static void memset(int* ary, int size);

	// static void setFileSystemReaderCallback(FileSystemReader callback);

	////这个就是cs的调用，可以再加一些其他处理，这里只读取了所有的文件，可以再加上文件夹以及目标目录是否存在的判断
	// public static IntPtr hh(string path, out int size)
	// {
	// 	DirectoryInfo dir = new DirectoryInfo("./");
	// 	var files = dir.GetFiles();
	// 	size = files.Length;
	// 	var names = new string[size];
	// 	for (int i = 0; i < size; i++)
	// 	{
	// 		names[i] = files[i].Name;
	// 	}
	//
	// 	IntPtr header = Marshal.AllocHGlobal(size * sizeof(long));
	// 	var strings = new List<IntPtr>();
	// 	foreach(var str in names)
	// 	{
	// 		strings.Add(Marshal.StringToHGlobalAnsi(str));
	// 	}
	// 	Marshal.Copy(strings.ToArray(), 0, header, strings.Count);
	// 	return header;
	// }

private:
	static void init();
};

//struct Damage
//{
//    //比如说dota里面的亚巴顿的大招会将伤害全部转化为治疗
//    bool isHeal;        //是否是治疗量
//    int value;          //原始的伤害数值
//    int curValue;       //当前伤害的数值
//    int damageType;     //原始伤害类型    有可能某个buff会将魔法伤害转化成纯粹伤害
//    int curDamageType;  //当前伤害类型
//    int source;         //伤害或者治疗的来源
//    int target;         //伤害或者治疗的目标
//};

//using DamageWarpper = std::shared_ptr<Damage>;
//
//DamageWarpper make_damage(int value, int type, Pawn* source, Pawn* target, bool isHeal = false)
//{
//    return std::make_shared<Damage>(isHeal, value, value, type, type, source, target);
//}

/**
 * \brief 将配置文件中的cost类型转化成统一的类型值
 * \param player 是否是玩家，如果不是玩家的话，则必定是棋子
 * \param type 配置文件中给定的值
 */
int costTypeTranslate(bool player, int type);
