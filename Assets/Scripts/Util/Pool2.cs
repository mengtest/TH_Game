using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Util
{
    /// <summary>
    /// 专门用于管理GameObject的对象池
    /// </summary>
    [LuaCallCSharp]
    public static class Pool2
    {
        /// <summary>
        /// 创建一个对象的回调函数
        /// </summary>
        [CSharpCallLua]
        public delegate GameObject CreateFun();

        //所有的池子
        private static Dictionary<string ,Queue<GameObject>> _pools = new Dictionary<string, Queue<GameObject>>();
        //单个池子中的元素的最大数量
        // private static int _max = 100;

        /// <summary>
        /// 从某个池子中获取一个对象，如果没有可获取的对象，则返回空
        /// </summary>
        /// <param name="signal"></param>
        /// <returns></returns>
        public static GameObject Get(string signal)
        {
            if (_pools.ContainsKey(signal))
            {
                var pool = _pools[signal];
                if (pool.Count > 0)
                {
                    var obj = pool.Dequeue();
                    obj.SetActive(true);
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// 从池子中获取一个对象，如果没有可获取的对象，则创建一个对象
        /// </summary>
        /// <param name="signal"></param>
        /// <returns></returns>
        public static GameObject GetOrCreate(string signal)
        {
            if (_pools.ContainsKey(signal))
            {
                var pool = _pools[signal];
                if (pool.Count > 0)
                {
                    var obj = pool.Dequeue();
                    obj.SetActive(true);
                    return obj;
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

        /// <summary>
        /// 从池子中获取一个对象，如果没有可获取的对象，则使用给定的函数创建一个对象返回
        /// </summary>
        /// <param name="signal"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static GameObject GetOrCreateByFunc(string signal, CreateFun func)
        {
            if (_pools.ContainsKey(signal))
            {
                var pool = _pools[signal];
                if (pool.Count > 0)
                {
                    var obj = pool.Dequeue();
                    obj.SetActive(true);
                    return obj;
                }
                else
                {
                    return func();
                }
            }
            else
            {
                _pools.Add(signal, new Queue<GameObject>());
                return func();
            }
        }

        /// <summary>
        /// 向池子中存储一个对象
        /// </summary>
        /// <param name="signal"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int Store(string signal, GameObject obj)
        {
            Queue<GameObject> pool = null;
            //从场景中移除
            obj.transform.SetParent(null);
            obj.SetActive(false);
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