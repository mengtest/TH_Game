#pragma once

class Pawn;

//���������е�ai��Ҫ�õ��ĵ�������
class AI
{
public:
	Pawn* getPawnByHp(int combatId, int playerId, bool highest);

	Pawn* getPawnByHpCond(int combatId, int playerId, int value, int greater);
};