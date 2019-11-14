using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XLua;
using Object = UnityEngine.Object;

namespace Pool
{
    [LuaCallCSharp]
    public class ObjectPool : IPool
    {
        private Queue<GameObject> _objects;
        private int _maxSize;

        public ObjectPool(int maxSize)
        {
            _maxSize = maxSize;
            _objects = new Queue<GameObject>(_maxSize);
        }
        
        public object Create(Object p)
        {
            if (_objects.Count == _maxSize)
            {
                return null;
            }
            
            var ins = (GameObject) Object.Instantiate(p);
            if (ins == null)
            {
                return null;
            }
            _objects.Enqueue(ins);
            ins.SetActive(true);
            return ins;
        }

        public object Create()
        {
            return null;
        }

        public bool Store(object value)
        {
            if (_objects.Count == _maxSize)
            {
                return false;
            }

            if (_objects.Contains((GameObject)value))
            {
                return false;
            }
            
            var ins = (GameObject) value;
            if (ins == null)
            {
                return false;
            }
            _objects.Enqueue(ins);
            ins.SetActive(true);
            return true;
        }

        public void Destory(object value)
        {
            var ins = (GameObject) value;
            if (ins == null)
            {
                throw new Exception("无效的对象");
            }
            else
            {
                ins.SetActive(false);
            }
        }

        public object Get()
        {
            foreach (var go in _objects)
            {
                if (!go.activeSelf)
                {
                    return go;
                }
            }
            return null;
        }

        public object GetUnique()
        {
            int index = 0;
            foreach (var go in _objects)
            {
                if (!go.activeSelf)
                {
                    break;
                }
                index++;
            }

            if (index >= _objects.Count)
            {
                return null;
            }

            for (int i = 0; i < index; i++)
            {
                _objects.Enqueue(_objects.Dequeue());
            }

            return _objects.Dequeue();
        }

        public int Size()
        {
            return _maxSize;
        }

        public int AutoResize()
        {
            var workCount = GetWorkCount();
            if (workCount / (float)_maxSize > 0.8)
            {
                var newAry = new GameObject[(int) (_maxSize * 1.5)];
                _objects.CopyTo(newAry, 0);
                _objects.Clear();
                foreach (var o in newAry)
                {
                    _objects.Enqueue(o);
                }
            }
            return _objects.Count;
        }

        private int GetWorkCount()
        {
            int index = 0;
            foreach (var go in _objects)
            {
                if (go.activeSelf)
                {
                    index++;
                }
            }
            return index;
        }
        
        public bool Expand(int size)
        {
            return false;
//            throw new NotImplementedException();
        }
    }
}