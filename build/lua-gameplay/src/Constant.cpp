#include "Constant.h"
#include "Singleton.h"

Constant* Constant::_instance = nullptr;

const Constant& Constant::instance()
{
	if (_instance == nullptr)
	{
		_instance = new Constant;
        Singleton::instance()->store(_instance);
	}
	return *_instance;
}