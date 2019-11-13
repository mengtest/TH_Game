using System;
using System.Collections.Generic;

namespace Pool
{
    public class BasePool<T> : IPool where T : class, new()
    {
        private Queue<KeyValuePair<int, T>> _objects;
        private int _maxSize;

        public BasePool(int maxSize)
        {
            _maxSize = maxSize;
            _objects = new Queue<KeyValuePair<int, T>>();
        }

        public object Create()
        {
            return Create(-1);
        }

        //使用对象池创建一个对象，如果对象池已满，则返回空
        public object Create(int key)
        {
            if (_objects.Count == _maxSize)
            {
                return null;
            }
            
            T t = new T();
            Add(key, t);
            return t;
        }

        public bool Store(int key, object value)
        {
            if (value.GetType() != typeof(T))
            {
                throw new Exception("无效的类型");
            }

            if (_objects.Count == _maxSize)
            {
                return false;
            }

            Add(key, value);
            return true;
        }

        public bool Store(object value)
        {
            return Store(-1, value);
        }

        public void Destory(int key, bool release = false)
        {
            
        }

        public void Destory(bool release = false)
        {
//            throw new NotImplementedException();
        }

        public object Get(int key)
        {
//            throw new NotImplementedException();
            return null;
        }

        public void Get()
        {
//            throw new NotImplementedException();
        }

        //类型正确，切保证一定会能够入队成功的时候直接调用这个
        private void Add(int key, object value)
        {
            _objects.Enqueue(new KeyValuePair<int, T>(key, (T) value));
        }
        
        public void Store(int key, T value)
        {
            
        }
    }
}