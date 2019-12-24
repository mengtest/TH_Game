using System;
using System.Collections.Generic;
using UnityEngine;
using Util.pool;
using XLua;
using Object = UnityEngine.Object;

namespace Util
{
    namespace pool
    {
        [LuaCallCSharp]
        public interface IPool
        {
            GameObject GetItem();
            void AddItem(GameObject item);
            int Count();
            GameObject Create();
            void Destroy(GameObject go);
            void Clear();
        }

        [LuaCallCSharp]
        public class DefaultPool : IPool
        {
            private Queue<GameObject> _gos;

            public DefaultPool()
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
                return go;
            }

            public void AddItem(GameObject item)
            {
                if (item != null)
                {
                    item.SetActive((false));
                    _gos.Enqueue(item);
                }
            }

            public int Count()
            {
                return _gos.Count;
            }

            public virtual GameObject Create()
            {
                var go = new GameObject();
                go.SetActive(true);
                go.transform.position = Vector3.zero;
                return go;
            }

            public virtual void Destroy(GameObject go)
            {
                Object.Destroy(go);
            }

            public void Clear()
            {
                while (_gos.Count != 0)
                {
                    Destroy(_gos.Dequeue());
                }
            }
        }
        
        [LuaCallCSharp]
        public class GameObjectPool : IPool
        {
            private Queue<GameObject> _gos;
            [LuaCallCSharp]
            [CSharpCallLua]
            public delegate GameObject Operator1(GameObject go);
            [LuaCallCSharp]
            [CSharpCallLua]
            public delegate GameObject Operator();
            private event Operator Creator;
            private event Operator1 Deleter;
            private event Operator1 Getter;
            private event Operator1 Setter;
            
            public static IPool CreatePool(Operator @operator, Operator1 deleter, Operator1 getter = null,Operator1 setter = null)
            {
                var pool = new GameObjectPool
                {
                    Creator = @operator, 
                    Deleter = deleter, 
                    Getter = getter, 
                    Setter = setter
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
                return Getter?.Invoke(go);
            }

            public void AddItem(GameObject item)
            {
                _gos.Enqueue(Setter == null ? item : Setter(item));
            }

            public int Count()
            {
                return _gos.Count;
            }

            public virtual GameObject Create()
            {
                return Creator?.Invoke();
            }

            public virtual void Destroy(GameObject go)
            {
                if (Deleter != null)
                {
                    Deleter(go);
                }
                else
                {
                    Object.Destroy(go);
                }
            }

            public void Clear()
            {
                while (_gos.Count != 0)
                {
                    Destroy(_gos.Dequeue());
                }
            }
        }
    }

    [LuaCallCSharp]
    public class Pool
    {
        // 一般对象就使用一个队列来模拟一个对象池
        private static Dictionary<string, Queue<object>> _pools;
        private static Dictionary<string, IPool> _gameObjectPools;

        private Pool()
        {
            _pools = new Dictionary<string, Queue<object>>();
            _gameObjectPools = new Dictionary<string, IPool>();
        }

        public static void AddPool(string sign, IPool pool)
        {
            if (_gameObjectPools.ContainsKey(sign))
            {
                var p = _gameObjectPools[sign];
                p.Clear();
                _gameObjectPools[sign] = pool;
            }
        }

        //获取到sign对应的对象，如果没有返回null
        public static T GetItem<T>(string sign) where T : class
        {
            if (_pools.ContainsKey(sign))
            {
                return _pools[sign].Count > 0
                    ? _pools[sign].Dequeue() as T
                    : default;
            }
            return default;
        }

        //获取sign对应的对象，如果没有，则使用fuction创建对应的对象
        public static T GetItemByFunc<T>(string sign, Func<T> function) where T : class
        {
            if (_pools.ContainsKey(sign))
            {
                if (_pools[sign].Count > 0)
                {
                    return _pools[sign].Dequeue() as T;
                }
                else
                {
                    return function();
                }
            }
            else
            {
                _pools.Add(sign, new Queue<object>());
                return function.Invoke();
            }
        }

        //获取sign对应的对象，如果没有，则调用构造函数创建，必须为具有无参的构造函数
        public static T GetItemByConstructor<T>(string sign) where T : class, new()
        {
            if (_pools.ContainsKey(sign))
            {
                if (_pools[sign].Count > 0)
                {
                    return _pools[sign].Dequeue() as T;
                }
                else
                {
                    return new T();
                }
            }
            else
            {
                _pools.Add(sign, new Queue<object>());
                return new T();
            }
        }

        public static void ClearSign(string sign)
        {
            if (_pools.ContainsKey(sign))
            {
                _pools[sign].Clear();
                _pools.Remove(sign);
            }
        }

        public static void Store(string sign, object value)
        {
            if (_pools.ContainsKey(sign))
            {
                _pools[sign].Enqueue(value);
            }
            else
            {
                var pool = new Queue<object>();
                pool.Enqueue(value);
                _pools.Add(sign, pool);
            }
        }

        public static void ClearAll()
        {
            //清理所有的池子
        }

        public static GameObject GetItem(string sign)
        {
            if (_gameObjectPools.ContainsKey(sign))
            {
                return _gameObjectPools[sign].GetItem();
            }
            else
            {
                _gameObjectPools.Add(sign, new DefaultPool());
            }
            return null;
        }

        public static GameObject GetItemByFunc(string sign, Func<GameObject> function)
        {
            GameObject item = null;
            if (_gameObjectPools.ContainsKey(sign))
            {
                item = _gameObjectPools[sign].GetItem();
            }
            else
            {
                _gameObjectPools.Add(sign, new DefaultPool());
            }
            return item == null ? function() : item;
        }
        
        public static void Init()
        {
            _pools = new Dictionary<string, Queue<object>>();
            _gameObjectPools = new Dictionary<string, IPool>();
        }
    }
}