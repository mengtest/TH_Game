#include "Buff.h"
#include "Pawn.h"
#include "Logger.h"
#include "Agent.h"
#include "fmt/format.h"

Buff::Buff(BuffMachine* machine, Pawn* source)
	: IBuff(machine, source)
{
    ylog("new buff origin id");
	_data = nullptr;
}

Buff::Buff()
	: IBuff(nullptr, nullptr)
{
	_data = nullptr;
}

const BuffS* Buff::data()
{
	return _data;
}

IBuff* Buff::clone(BuffMachine* machine, int unique_id, Pawn* source)
{
	//默认的buff暂时不提供clone方法
    //TODO
	return nullptr;
}

void Buff::reset()
{
	//reset的时候需要发送消更新界面吗？
    //TODO
	_data->overlay = _data->primaryOverlay;
	_data->restTime = _data->maxTime;
}

void Buff::release()
{
	_machine->release(this);
}

int Buff::id()
{
	return _data->id;
}

int Buff::unique_id()
{
	return _data->unique_id;
}

int Buff::maxTime()
{
	return _data->maxTime;
}

int Buff::restTime()
{
	return _data->restTime;
}

int Buff::targetId()
{
	return _data->targetId;
}

int Buff::sourcePawn()
{
	return _data->sourcePawn;
}

int Buff::damage()
{
	return _data->damage;
}

int Buff::damageType()
{
	return _data->damageType;
}

int Buff::maxOverlay()
{
	return _data->maxOverlay;
}

int Buff::overlay()
{
	return _data->overlay;
}

int Buff::baseType()
{
	return _data->baseType;
}

bool Buff::test(IBuff* buff)
{
	//测试当前目标buff是否能够添加到含有当前buff的棋子上
	//这个东西应该是根据某个配置文件来

	return true;
}

//所有的buff对棋子产生影响的均为正值就是增加，负值就是减少
//只有damage字段表示hp减少，heal表示hp增加
void Buff::onDestroy(Pawn* source, Pawn* target)
{
	auto* buff = this->_data;
	//物伤
	if (buff->baseType == 1)
	{
		target->opAtk(-buff->value);
	}
	//法伤
	else if (buff->baseType == 2)
	{
		target->opMatk(-buff->value);
	}
	//物防
	else if (buff->baseType == 3)
	{
		//所有的damage数值都有正负数的说法，比如如果是hp正数表示回血，负数表示伤害
		//对于其他的数值来说，正数表示增加负数表示减少
		//直接加就完事了，如果有其他处理再说
		// target->minus(yGlobal.PawnDef, buff.);

		// TODO 属性该如何去计算
		target->opDef(-buff->value);
	}
	//魔防
	else if (buff->baseType == 4)
	{
        // TODO 属性该如何去计算
		target->opMdef(-buff->value);
	}
	// //生命回复
	// else if (buff->baseType == 5)
	// {
	// 	// target->minus(yGlobal.PawnHp, buff->value);
 //        // TODO
	// }
	// //魔法
	// else if (buff->baseType == 6)
	// {
	// 	// target->minus(yGlobal.PawnMp, buff->value);
 //        // TODO
	// }
	// //无敌
	// else if (buff->baseType == 7)
	// {
	// 	//拥有这个buff期间不受到任何伤害
	// 	
	// }
	// //沉默
	// else if (buff->baseType == 8)
	// {
	// 	//拥有这个buff期间不能使用技能
	// }
	// //缴械
	// else if (buff->baseType == 9)
	// {
	// 	//拥有这个buff期间不能攻击
	// }
	// //挑衅
	// else if (buff->baseType == 10)
	// {
	// 	//意义不明，等想好以后再做
	// }
	//死亡宣告
	else if (buff->baseType == 11)
	{
		//buff结束的时候拥有这个buff的棋子直接死亡
		//死亡宣告的优先级为100
		target->dead(80);
	}
	//斩杀 棋子当前声明值低于一定值，直接秒杀,拥有最高优先级
	// else if (buff->baseType == 12)
	// {
	// 	// if (target->data()->hp <= buff->damage)
	// 	// {
	// 	// 	target->dead(PRIORITY_TOP);
	// 	// }
 //        // TODO
	// }
}

//添加buff时触发
void Buff::onCreate(Pawn* source, Pawn* target)
{
	auto* buff = this->_data;
	//物伤
	if (buff->baseType == 1)
	{
		// 增加buff时的初始伤害在skill中计算，而不是这里计算
		
		// target->hit(source, buff->damage, buff->damageType);
        // TODO
		// target->opAtk(buff->value);
	}
	//法伤
	else if (buff->baseType == 2)
	{
        // TODO
		// target->opMatk(buff->value);
	}
	//物防
	else if (buff->baseType == 3)
	{
		//所有的damage数值都有正负数的说法，比如如果是hp正数表示回血，负数表示伤害
		//对于其他的数值来说，正数表示增加负数表示减少
		//直接加就完事了，如果有其他处理再说
		target->opDef(buff->value);
	}
	//魔防
	else if (buff->baseType == 4)
	{
		target->opMdef(buff->value);
	}
	//生命回复
	else if (buff->baseType == 5)
	{
		target->opHp(buff->value);
	}
	//魔法
	else if (buff->baseType == 6)
	{
		target->opMp(buff->value);
	}
	// //无敌
	// else if (buff->baseType == 7)
	// {
	// 	//拥有这个buff期间不受到任何伤害，不会受到任何debuff的影响
	// 	
	// }
	// //沉默
	// else if (buff->baseType == 8)
	// {
	// 	//拥有这个buff期间不能使用技能
	// }
	// //缴械
	// else if (buff->baseType == 9)
	// {
	// 	//拥有这个buff期间不能攻击
	// }
	// //挑衅
	// else if (buff->baseType == 10)
	// {
	// 	//意义不明，等想好以后再做
	// }
	//死亡宣告
	// else if (buff->baseType == 11)
	// {
	// 	// 在buff结束时才生效
	// 	// buff结束的时候拥有这个buff的棋子直接死亡
	// 	// 死亡宣告的优先级为5
	// 	// target->dead(5);
 //
 //        // TODO
	// }
	// //斩杀 棋子当前声明值低于一定值，直接秒杀,拥有最高优先级
	// else if (buff->baseType == 12)
	// {
	// 	// if (target->data()->hp <= buff->damage)
	// 	// {
	// 	// 	target->dead(PRIORITY_TOP);
	// 	// }
 //
 //        // TODO
	// }
}

//拥有这个buff的棋子可以行动时触发
//buff添加到棋子上时，会立即调用create，但是不会立即调用invoke，只有在真正
void Buff::onInvoke(Pawn* source, Pawn* target)
{
    this->_data->restTime--;

    if (this->_data->restTime <= 0)
    {
        //buff的叠加次数归零、可以销毁这个buff了
        destroy();
        return;
    }

	auto* buff = this->_data;
	Damage damage{true, buff->damage, buff->damage, buff->damageType,buff->damageType,source, target};
	//物伤
	if (buff->baseType == 1)
	{
		target->hit(&damage);
	}
	//法伤
	else if (buff->baseType == 2)
	{
		target->hit(&damage);
	}
	//物防
	else if (buff->baseType == 3)
	{
		//所有的damage数值都有正负数的说法，比如如果是hp正数表示回血，负数表示伤害
		//对于其他的数值来说，正数表示增加负数表示减少
		//直接加就完事了，如果有其他处理再说
		// target->attrOp(Attr::def, buff->damage);
	}
	//魔防
	else if (buff->baseType == 4)
	{
		// target->attrOp(Attr::mdef, buff->damage);
	}
	//生命回复
	else if (buff->baseType == 5)
	{
		target->opHp(buff->value);
	}
	//魔法
	else if (buff->baseType == 6)
	{
		target->opMp(buff->value);
	}
	// //无敌
	// else if (buff->attachFunctionId == 7)
	// {
	// 	//拥有这个buff期间不受到任何伤害，不会受到任何debuff的影响
	// 	
	// }
	// //沉默
	// else if (buff->attachFunctionId == 8)
	// {
	// 	//拥有这个buff期间不能使用技能
	// }
	// //缴械
	// else if (buff->attachFunctionId == 9)
	// {
	// 	//拥有这个buff期间不能攻击
	// }
	// //挑衅
	// else if (buff->attachFunctionId == 10)
	// {
	// 	//意义不明，等想好以后再做
	// }
	//死亡宣告
	// else if (buff->attachFunctionId == 11)
	// {
	// 	//buff结束的时候拥有这个buff的棋子直接死亡
	// 	//死亡宣告的优先级为5
	// 	target->dead(5);
	// }
	// //斩杀 棋子当前声明值低于一定值，直接秒杀,拥有最高优先级
	// else if (buff->baseType == 12)
	// {
	// 	// if (target->data()->hp <= buff->damage)
	// 	// {
	// 	// 	target->dead(PRIORITY_TOP);
	// 	// }
	//
	// 	// TODO
	// }
}

//buff被驱散的时候触发
void Buff::onDispose(Pawn* source, Pawn* target)
{
    // TODO

}

bool Buff::onInteractive(Pawn* source, Pawn* target, IBuff* buff, int type)
{
    // TODO
	return true;
}

Buff::~Buff()
{
    if (_data != nullptr)
    {
        // ylog(u8"free buff id %d", this->_data->unique_id);
        delete _data;
        _data = nullptr;
    }
}

int Buff::primaryOverlay() {
    return _data->primaryOverlay;
}

void Buff::callOverlay() {
    _data->overlay += _data->primaryOverlay;
    if (_data->overlay > _data->maxOverlay)
    {
        _data->overlay = _data->maxOverlay;
    }
    AgentMgr::instance()->curAgent()->update(this, yGlobal.EventBuffAttrOverlay, _data->overlay);
}
