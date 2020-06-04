﻿using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Util
{
    /// <summary>
    /// 专门用于管理GameObject的对象池
    /// </summary>
    [LuaCallCSharp]
    public static class Pool
    {
        private static Dictionary<string, Queue<GameObject>> _pool = new Dictionary<string, Queue<GameObject>>();

        public delegate GameObject CreateFun();

        static GameObject Get(string name)
        {
            if(!_pool.ContainsKey(name))
            {
                var pool = new Queue<GameObject>();
                _pool.Add(name, pool);
                return new GameObject();
            }
            else
            {
                var pool = _pool[name];
                if(pool.Count == 0)
                {
                    return new GameObject();
                }
                else
                {
                    return pool.Dequeue();
                }
            }
        }

        static void Store(string name,GameObject go)
        {
            go.SetActive(false);
            go.transform.SetParent(null);
            if(!_pool.ContainsKey(name))
            {
                var pool = new Queue<GameObject>();
                pool.Enqueue(go);
                _pool.Add(name, pool);
            }
            else
            {
                var pool = _pool[name];
                pool.Enqueue(go);
            }
        }

        static GameObject GetByCreateFun(string name, CreateFun func)
        {
            if(!_pool.ContainsKey(name))
            {
                var pool = new Queue<GameObject>();
                _pool.Add(name, pool);
                return func();
            }
            else
            {
                var pool = _pool[name];
                if(pool.Count == 0)
                {
                    return func();
                }
                else
                {
                    return pool.Dequeue();
                }
            }
        }

        static void Clear(string name)
        {
            if(_pool.ContainsKey(name))
            {
                var pool = _pool[name];
                while(pool.Count != 0)
                {
                    GameObject.Destroy(pool.Dequeue());
                }
                _pool.Remove(name);
            }
        }

        static void ClearAll()
        {
            foreach (var item in _pool)
            {
                var pool = item.Value;
                while(pool.Count != 0) 
                {
                    GameObject.Destroy(pool.Dequeue());
                }
            }
            _pool.Clear();
        }
    }
}