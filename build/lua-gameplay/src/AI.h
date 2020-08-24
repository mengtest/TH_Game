#pragma once

class Pawn;

//这里是所有的ai需要用到的导出函数
class AI
{
public:
	Pawn* getPawnByHp(int combatId, int playerId, bool highest);

	Pawn* getPawnByHpCond(int combatId, int playerId, int value, int greater);
};