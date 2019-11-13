using System;
using System.Collections.Generic;
using System.Linq;

namespace Pool
{
    public class BasePool<T> : IPool where T : class, new()
    {
        private Queue<Pair<T, bool>> _objects;
        private int _maxSize;

        public BasePool(int maxSize)
        {
            _maxSize = maxSize;
            _objects = new Queue<Pair<T, bool>>();
        }

        public object Create()
        {
            if (_objects.Count == _maxSize)
            {
                return null;
            }
            
            T t = new T();
            _objects.Enqueue(new Pair<T, bool>(t, false));
            return t;
        }

        public bool Store(object value)
        {
            if (value.GetType() != typeof(T))
            {
                throw new Exception("无效的类型");
            }

            if (_objects.Count == _maxSize)
            {
                return false;
            }

            _objects.Enqueue(new Pair<T, bool>((T) value, false));
            return true;
        }
        
        public void Destory(object value)
        {
            //使用权归还给对象池
            for (int i = 0; i < _objects.Count; i++)
            {
                if (_objects.ElementAt(i).First.GetHashCode() == value.GetHashCode())
                {
                    _objects.ElementAt(i).Second = false;
                }
            }
        }

        public object Get()
        {
            foreach (var pair in _objects)
            {
                if (!pair.Second)
                {
                    pair.Second = true;
                    return pair.First;
                }
            }
            return null;
        }

        public object GetUnique()
        {
            int index = 0;
            //找出第一个没有被使用的对象的下标
            foreach (var pair in _objects)
            {
                if (!pair.Second)
                {
                    break;
                }
                index++;
            }

            //如果下标越界，则返回空
            if (index >= _objects.Count)
            {
                return null;
            }
            
            //将目标对象前面的对象移动到队列尾部
            for (int i = 0; i < index; i++)
            {
                var value = _objects.Dequeue();
                _objects.Enqueue(value);
            }
                
            //返回目标对象
            return _objects.Dequeue().First;
        }
    }
}