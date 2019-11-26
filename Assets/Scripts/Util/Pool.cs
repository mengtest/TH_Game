using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using Util.pool;
using Object = UnityEngine.Object;

namespace Util
{
    namespace pool
    {
        public interface IPool
        {
            GameObject GetItem();
            void AddItem(GameObject item);
            int Count();
            GameObject Create();
            void Destroy(GameObject go);
//            IPool(Func<GameObject> creator, Action<GameObject> deleter);
        }
        
        public class GameObjectPool : IPool
        {
            private Queue<GameObject> _gos;
            public delegate GameObject Operator(GameObject go);
            public delegate GameObject Creator();
            private event Creator creator;
            private event Operator deleter;
            private event Operator getter;
            private event Operator setter;
            
            public static IPool CreatePool(Creator creator, Operator deleter, Operator getter = null,Operator setter = null)
            {
                var pool = new GameObjectPool
                {
                    creator = creator, 
                    deleter = deleter, 
                    getter = getter, 
                    setter = setter
                };
                return pool;
            }
            
            public GameObjectPool()
            {
                _gos = new Queue<GameObject>();
            }

            public GameObject GetItem()
            {
                GameObject go = null;
                if (_gos.Count > 0)
                {
                    go = _gos.Dequeue();
                }
                return getter?.Invoke(go);
            }

            public void AddItem(GameObject item)
            {
                _gos.Enqueue(setter == null ? item : setter(item));
            }

            public int Count()
            {
                return _gos.Count;
            }

            public virtual GameObject Create()
            {
                return creator?.Invoke();
            }

            public virtual void Destroy(GameObject go)
            {
                if (deleter != null)
                {
                    deleter(go);
                }
                else
                {
                    Object.Destroy(go);
                }
            }
        }
    }

    public class Pool
    {
        private static Pool _instance;

        // 一般对象就使用一个队列来模拟一个对象池
        private Dictionary<string, Queue<object>> _pools;
        private Dictionary<string, GameObjectPool> _gameObjectPools;

        private Pool()
        {
            _pools = new Dictionary<string, Queue<object>>();
            _gameObjectPools = new Dictionary<string, GameObjectPool>();
        }

        public static void AddPool(string sign, GameObjectPool pool)
        {
            if (_instance._gameObjectPools.ContainsKey(sign))
            {
                var p = _instance._gameObjectPools[sign];
                GameObject go = p.GetItem();
                for (; go != null ;)
                {
                    p.Destroy(go);
                    go = p.GetItem();
                }
                _instance._gameObjectPools[sign] = pool;
            }
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
        public static T GetItemByFunc<T>(string sign, Func<T> function) where T : class
        {
            if (_instance._pools.ContainsKey(sign))
            {
                if (_instance._pools[sign].Count > 0)
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
                if (_instance._pools[sign].Count > 0)
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

        public static GameObject GetItem(string sign)
        {
            if (_instance._gameObjectPools.ContainsKey(sign))
            {
                return _instance._gameObjectPools[sign].GetItem();
            }
            return null;
        }

        public static GameObject GetItemByFunc(string sign, Func<GameObject> function)
        {
            GameObject item = null;
            if (_instance._gameObjectPools.ContainsKey(sign))
            {
                item = _instance._gameObjectPools[sign].GetItem();
            }
            else
            {
                _instance._gameObjectPools.Add(sign, new GameObjectPool());
            }
            return item == null ? function() : item;
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