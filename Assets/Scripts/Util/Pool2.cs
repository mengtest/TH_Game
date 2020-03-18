using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Util
{
    //专门用于管理GameObject
    [LuaCallCSharp]
    public static class Pool2
    {
        //所有的池子
        private static Dictionary<string ,Queue<GameObject>> _pools = new Dictionary<string, Queue<GameObject>>();
        //单个池子中的元素的最大数量
        private static int _max = 100;

        public static GameObject Get(string signal)
        {
            if (_pools.ContainsKey(signal))
            {
                var pool = _pools[signal];
                if (pool.Count > 0)
                {
                    return pool.Dequeue();
                }
            }
            return null;
        }

        public static GameObject GetOrCreate(string signal)
        {
            if (_pools.ContainsKey(signal))
            {
                var pool = _pools[signal];
                if (pool.Count > 0)
                {
                    return pool.Dequeue();
                }
                else
                {
                    return new GameObject($"{signal}_pool_item");
                }
            }
            else
            {
                _pools.Add(signal, new Queue<GameObject>());
                return new GameObject($"{signal}_pool_item");
            }
        }

        public static int Store(string signal, GameObject obj)
        {
            Queue<GameObject> pool = null;
            if (_pools.ContainsKey(signal))
            {
                pool = _pools[signal];
                pool.Enqueue(obj);
            }
            else
            {
                pool = new Queue<GameObject>();
                pool.Enqueue(obj);
                _pools.Add(signal, pool);
            }
            return pool.Count;
        }
    }
}