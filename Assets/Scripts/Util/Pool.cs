using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using Object = UnityEngine.Object;

namespace Util
{
    /// <summary>
    /// 专门用于管理GameObject的对象池
    /// </summary>
    [LuaCallCSharp]
    public static class Pool
    {
        private static Dictionary<string, Queue<GameObject>> _pool = new Dictionary<string, Queue<GameObject>>();
        private static GameObject _poolObj;

        public static void Init()
        {
            _poolObj = new GameObject("Pool");
            Object.DontDestroyOnLoad(_poolObj);
        }

        public delegate GameObject CreateFun();

        public static GameObject Get(string name)
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
                    //从poo中取出的对象是未激活状态的，需要调用激活函数去触发
                    return pool.Dequeue();
                }
            }
        }
        
        //设置池子的元素最大数量
        public static void SetMaxSize(string name, int size)
        {
            throw new NotImplementedException();
        }

        public static void Store(string name,GameObject go)
        {
            go.SetActive(false);
            go.transform.SetParent(null);
            if(!_pool.ContainsKey(name))
            {
                var pool = new Queue<GameObject>();
                var g = new GameObject(name);
                g.transform.SetParent(_poolObj.transform);
                pool.Enqueue(go);
                _pool.Add(name, pool);
                go.transform.SetParent(g.transform);
            }
            else
            {
                var pool = _pool[name];
                pool.Enqueue(go);
                go.transform.SetParent(_poolObj.transform.GetChildByName(name));
            }
            
        }

        public static GameObject GetByCreateFun(string name, CreateFun func)
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

        public static void Clear(string name)
        {
            if(_pool.ContainsKey(name))
            {
                var pool = _pool[name];
                while(pool.Count != 0)
                {
                    Object.Destroy(pool.Dequeue());
                }
                _pool.Remove(name);
            }
        }

        public static void ClearAll()
        {
            foreach (var item in _pool)
            {
                var pool = item.Value;
                while(pool.Count != 0) 
                {
                    Object.Destroy(pool.Dequeue());
                }
            }
            _pool.Clear();
        }
    }
}