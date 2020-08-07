#pragma once

#include <vector>

struct PawnS;
class Pawn;

using PawnList = std::vector<PawnS*>;

class PawnMgr
{
private:
	//所有棋子的原始数据
	static PawnList _pawns;

	PawnMgr() = default;
public:
	static void loadAll(PawnList & list);

	//只负责创建，不负责销毁
	static Pawn* create(int id, int uid);

	//谁创建，谁来销毁
	static void release(Pawn* pawn);
};
