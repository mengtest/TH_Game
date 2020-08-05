#pragma once

#include "BuffMachine.h"
#include "Pawn.h"

class Player;
class Pawn;

//buff的接口，可能会出现通过脚本创建新的buff的情况


//缺少的功能，当某个属性被修改的时候，需要将对应的消息传递给client
class IBuff
{
protected:
	BuffMachine* _machine = nullptr;

	//挂载了这个buff的棋子
	Pawn* _owner;

	//这个buff的来源
	Pawn* _source;

	IBuff(BuffMachine* machine, Pawn* source)
		: _machine(machine)
		, _owner(nullptr)
		, _source(source)
	{
	}

public:
	//这里需要暴露所有属性的get与set函数
	virtual ~IBuff() = default;

	BuffMachine* getMachine()
	{
		return _machine;
	}

	//这里是获取各种属性的api
	virtual int id() = 0;

	virtual int unique_id() = 0;

	virtual int maxTime() = 0;

	virtual int restTime() = 0;

	virtual int targetId() = 0;

	virtual int sourcePawn() = 0;

	virtual int damage() = 0;

	virtual int damageType() = 0;

	virtual int maxOverlay() = 0;

	virtual int overlay() = 0;

	virtual int baseType() = 0;

	virtual int primaryOverlay() = 0;

//	//挂载buff的时候调用这个函数
//	void addToPawn(Pawn * pawn)
//    {
//	    _owner = pawn;
//    }

	// //开始挂载buff的时候调用
	// virtual void beginTrans() = 0;
	//
	// //挂载成功之后提交
	// virtual void commit() = 0;
	//
	// //挂载失败之后回滚的操作
	// virtual void rollback() = 0;


	/**
	 * \brief 拷贝一个当前的buff，并返回新的实例对象
	 * 因为uid赋值之后无法修改，所以clone的时候需要提供新的uid
	 * \param machine 
	 * \param unique_id
	 * \param source buff的来源，这里主要是用于复制脚本中创建的buff
	 * \return 
	 */
	virtual IBuff* clone(BuffMachine* machine, int unique_id, Pawn* source) = 0;

	//buff重置到最初的状态
	virtual void reset() = 0;

	//释放这个buff的内存
	virtual void release() = 0;

	//获取当前buff所在的棋子对象
	Pawn* getOwner()
	{
		return _owner;
	}

	//source不会为空
	Pawn* getSource()
	{
		return _source;
	}

	//当前buff发生叠加
	//重置倒计时以及，叠加层数的修改等等
	virtual void callOverlay()
	{
	    
	}

	//测试是否能够添加目标buff
	//例如，当前棋子身上有魔法免疫，则无法再次添加任何新的buff
	virtual bool test(IBuff* buff) = 0;

	//onDestroy前触发，在onDestroy后会调用destroy
	virtual void onDestroy(Pawn* source, Pawn* target) = 0;

	//附加到棋子身上时触发
	//在create的时候调用这个函数，但是并不一定会走onCreate的逻辑
	virtual void onCreate(Pawn* source, Pawn* target) = 0;

	//每回合开始时触发(buff执行阶段触发)
	virtual void onInvoke(Pawn* source, Pawn* target) = 0;

	//buff被驱散时触发
	virtual void onDispose(Pawn* source, Pawn* target) = 0;

	BuffD* toDisplay()
	{
		return _machine->toDisplay(this);
	}

	/**
	 * \brief 有新的buff添加到当前buff所在的棋子身上时触发
	 * \param source buff的来源
	 * \param target buff的目标
	 * \param buff buff本身
	 * \param type 1表示创建时触发，2表示执行时触发，3表示销毁时触发
	 * \return 返回false表示交互失败，需要回滚
	 */
	virtual bool onInteractive(Pawn* source, Pawn* target, IBuff* buff, int type) = 0;

	//buff创建时
	//在create的时候回去设置owner，所以不需要额外的api去设置owner
	virtual void create(Pawn* target)
	{
		_owner = target;
		onCreate(_source, _owner);
	}

	//buff销毁时(倒计时结束)
    //onDestroy不会销毁这个buff
	virtual void destroy()
	{
		onDestroy(_source, _owner);
		//destroy之后销毁自己
		// release();
		getOwner()->unmount(this);
	}

	//buff每次执行时
	virtual void invoke()
	{
		onInvoke(_source, _owner);
	}

	//buff被驱散时
	//buff被驱散应该是传入驱散这个buff的棋子
	virtual void dispose()
	{
		onDispose(_source, _owner);
		//该buff被驱散之后也会销毁自己
		// release();
		getOwner()->unmount(this);
	}

	friend class BuffMachine;
};

//释放当前对象的内存
class IRelease
{
public:
	virtual ~IRelease()
	{
		
	}

	virtual void free()
	{
		
	}
};