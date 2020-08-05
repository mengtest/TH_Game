#pragma once

#include "Interfaces.h"

class LuaBuff: IBuff
{
private:
	sol::table _table;

	int _restTime;

	int _uid;

	int _overlay;

	LuaBuff(BuffMachine* machine, Pawn* source);

	LuaBuff();
public:
	~LuaBuff() override;

	IBuff* clone(BuffMachine* machine, int unique_id, Pawn* source) override;

	static LuaBuff* createBuff(sol::table tb);

	int id() override;

	int unique_id() override;

	int maxTime() override;

	int restTime() override;

	int targetId() override;

	int sourcePawn() override;

	int damage() override;

	int damageType() override;

	int maxOverlay() override;

	int overlay() override;

	int baseType() override;

	void reset() override;

	void release() override;

    int primaryOverlay() override;

    bool test(IBuff* buff) override;

	void onDestroy(Pawn* source, Pawn* target) override;

	void onCreate(Pawn* source, Pawn* target) override;

	void onInvoke(Pawn* source, Pawn* target) override;

	void onDispose(Pawn* source, Pawn* target) override;

	bool onInteractive(Pawn* source, Pawn* target, IBuff* buff, int type) override;
};