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
            var temp = _objects.ElementAt(0);
            //如果这个值正在被使用，则
            if (temp.Second)
            {
                
            }
            return temp.First;
        }

        public object GetUnique()
        {
            //这个对象的所有权不再归对象池所有
            return _objects.Dequeue().First;
        }
    }
}