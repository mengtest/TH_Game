#pragma once

#include "Data.h"
#include "Interfaces.h"

class BuffMachine;
class Pawn;

class Buff : public IBuff
{
private:
	//运行期的buff中所保存的数据
	//展示数据由包含有这个buff的buff机来保存并调用
	BuffS* _data;

	// BuffMachine* _machine;

	// Pawn* _owner;

	//buff可以处于游离状态(没有从属的棋子)，但是一定有从属的buff机,以及buff的来源棋子(谁使用技能产生了这个buff)
	Buff(BuffMachine* machine, Pawn* source);

 	Buff();
public:
	const BuffS* data();

	IBuff* clone(BuffMachine* machine, int unique_id, Pawn* source) override;

	void reset() override;

	void release() override;

	int id() override;

	int unique_id() override;

	int maxTime() override;

	int restTime() override;

	int targetId() override;

	int sourcePawn() override;

	int damage() override;

	int damageType() override;

	int maxOverlay() override;

    int primaryOverlay() override;

    int overlay() override;

	int baseType() override;

	bool test(IBuff* buff) override;

    void callOverlay() override;

    void onDestroy(Pawn* source, Pawn* target) override;

	void onCreate(Pawn* source, Pawn* target) override;

	//需要提供一个功能：每次执行的时候，如果该buff没有被添加到棋子上，则自动销毁这个buff，并且不会有任何触发
	void onInvoke(Pawn* source, Pawn* target) override;

	void onDispose(Pawn* source, Pawn* target) override;

	bool onInteractive(Pawn* source, Pawn* target, IBuff* buff, int type) override;

	//在析构函数中清除释放其他内存
	~Buff();

	friend class BuffMachine;
};
