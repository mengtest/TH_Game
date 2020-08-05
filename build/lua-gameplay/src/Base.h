#pragma once

#define _CRT_SECURE_NO_WARNINGS

#if defined(__cplusplus) && __cplusplus >= 201703L
#define __CPP_17__ 1
#endif

//一些预定义的部分，例如宏、编译期常量、导出函数等

// #define CLIENT_EXTEND

//这个是可选项
#define TYPE_LUA 1

//以下两个是互不兼容的
#define TYPE_JS 2
#define TYPE_CS 1

#define CSDLL __declspec(dllexport) __cdecl
//最后直接在cs端替换成 public static extern
#define cspublic
#define RETURN_TYPE(__ARG__) __declspec(dllexport) __ARG__* __cdecl
//这个使用一个特殊的符号表示指针，为了方便在cs端替换(如果直接用*的话会破坏注释)
#define YUKI_POINTER *
//对应C#端的IntPtr，会在函数名中标识出当前api所返回的对象的类型
//使用void*就是方便统一所有的返回值类型
#define IntPtr __declspec(dllexport) void* _cdecl

//占位符，填了这个东西的地方表示现在还未实现
#define PASS 0
#define UNIMPLEMENTHANDLE() throw std::exception("未实现的函数")

#include "Constant.h"
#define yGlobal Constant::instance()

#define EXPORT_TYPE TYPE_CS

constexpr int YUKI_TEST = 1;

constexpr int PANEL_LENGTH = 8;
constexpr int PAWN_BUFF_LENGTH = 30;
constexpr int PAWN_SKILL_LENGTH = 5;
constexpr int SKILL_BUFF_LENGTH = 5;
constexpr int BUFF_TAG_LENGTH = 5;
constexpr int PRIORITY_TOP = 10000;
constexpr int HAND_CARD_NUM = 15;
constexpr int DECK_CARD_NUM = 50;
constexpr int MAX_FLAG_NUM = 5;
// constexpr int SKILL_TAG_LENGTH = 5;

constexpr int flags = 100000;
//禁止攻击
constexpr int FLAG_CANT_ATTACK = flags + 1;
//禁止使用技能
constexpr int FLAG_CANT_USE_SKILL = flags + 2;
//禁止行动
constexpr int FLAG_CANT_DO = flags + 3;
//不死 (会被斩杀)
constexpr int FLAG_UNDEAD = flags + 4;