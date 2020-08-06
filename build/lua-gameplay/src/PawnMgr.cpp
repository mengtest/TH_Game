#include "PawnMgr.h"
#include "Pawn.h"
#include "Singleton.h"
#include "Logger.h"
#include "fmt/format.h"

PawnList PawnMgr::_pawns;

void PawnMgr::loadAll(PawnList& list)
{
    ylog("list的长度为%d",list.size());
    for (auto pawn : _pawns)
    {
		delete pawn;
    }
	_pawns.clear();
	_pawns.swap(list);
	Singleton::instance()->store([](){
		for (auto p : _pawns)
		{
			delete(p);
		}
		_pawns.clear();
	});
}

Pawn* PawnMgr::create(int id, int uid)
{
//    ylog("棋子列表的长度为%d", _pawns.size());
	if (_pawns.size() >= id && id > 0)
	{
        ylog("创建棋子%d,uid为%d",id, uid);
		auto* origin = _pawns.at(static_cast<size_t>(id) - 1);
		auto* pawn = Pawn::create(origin, uid);
		return pawn;
	}
	return nullptr;
}

void PawnMgr::release(Pawn* pawn)
{
	pawn->release();
	delete pawn;
}
