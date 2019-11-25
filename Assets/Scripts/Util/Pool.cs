using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Util
{
    namespace pool
    {
        interface IObjectHolder
        {
            GameObject Get();
            void Add(GameObject go);
            int Count();
        }

        public class GameObjectPool
        {
            class ObjectHolder: IObjectHolder
            {
                private readonly Queue<GameObject> _gos = new Queue<GameObject>();
                
                public GameObject Get()
                {
                    if (_gos.Count > 0)
                    {
                        return _gos.Dequeue();
                    }
                    return null;
                }

                public void Add(GameObject go)
                {
                    _gos.Enqueue(go);
                }

                public int Count()
                {
                    return _gos.Count;
                }
            }
            
            private IObjectHolder _gos;
            private int _max;
            public string Name { get; set; }

            public GameObjectPool(string name, int max)
            {
                _gos = new ObjectHolder();
                _max = max;
                Name = name;
            }
            
            public virtual GameObject CreateObject()
            {
                return null;
            }

            public GameObject GetItem()
            {
                if (_gos.Count() > 0)
                {
                    return _gos.Get();
                }
                return null;
            }

            public bool Store(GameObject go)
            {
                if (_gos.Count() > _max)
                {
                    throw new Exception($"对象池{Name}存储的对象超过上限");
                }
                
                if (_gos.Count() == _max)
                {
                    return false;
                }
                else
                {
                    _gos.Add(go);
                    return true;
                }
            }

            public virtual void Destory(GameObject go)
            {
                Object.Destroy(go);
            }
        }    
    }
    
    public class Pool
    {
        private static Pool _instance;

        // 一般对象就使用一个队列来模拟一个对象池
        private Dictionary<string, Queue<object>> _pools;

        private Pool()
        {
            _pools = new Dictionary<string, Queue<object>>();
        }

        //获取到sign对应的对象，如果没有返回null
        public static T GetItem<T>(string sign) where T : class
        {
            if (_instance._pools.ContainsKey(sign))
            {
                return _instance._pools[sign].Count > 0 
                    ? _instance._pools[sign].Dequeue() as T 
                    : default;
            }
            return default;
        }

        //获取sign对应的对象，如果没有，则使用fuction创建对应的对象
        public static T GetItemByFunc<T>(string sign, Func<T> function) where T: class
        {
            if (_instance._pools.ContainsKey(sign))
            {
                if (_instance._pools[sign].Count > 0 )
                {
                    return _instance._pools[sign].Dequeue() as T;
                }
                else
                {
                    return function();
                }
            }
            else
            {
                _instance._pools.Add(sign, new Queue<object>());
                return function.Invoke();
            }
        }
        
        //获取sign对应的对象，如果没有，则调用构造函数创建，必须为具有无参的构造函数
        public static T GetItemByConstructor<T>(string sign) where T : class, new()
        {
            if (_instance._pools.ContainsKey(sign))
            {
                if (_instance._pools[sign].Count > 0 )
                {
                    return _instance._pools[sign].Dequeue() as T;
                }
                else
                {
                    return new T();
                }
            }
            else
            {
                _instance._pools.Add(sign, new Queue<object>());
                return new T();
            }
        }

        public static void ClearSign(string sign)
        {
            if (_instance._pools.ContainsKey(sign))
            {
                _instance._pools.Remove(sign);
            }
        }

        public static void Store(string sign, object value)
        {
            if (_instance._pools.ContainsKey(sign))
            {
                _instance._pools[sign].Enqueue(value);
            }
            else
            {
                var pool = new Queue<object>();
                pool.Enqueue(value);
                _instance._pools.Add(sign, pool);
            }
        }

        public static void ClearAll()
        {
            //清理所有的池子
        }

        public static void Init()
        {
            if (_instance == null)
            {
                _instance = new Pool();
            }
        }
    }
    
}