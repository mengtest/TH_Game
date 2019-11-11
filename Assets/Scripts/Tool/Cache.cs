using System;
using System.Collections.Generic;

partial class Global
{
    public static class Cache
    {
        private static Dictionary<string, object> _cache = new Dictionary<string, object>();


        public static T GetStorage<T>(string key)
        {
            if (_cache.ContainsKey(key))
            {
                var value = (T) _cache[key];
                //因为只当做缓存，所以取出之后就立马从列表中删除
                _cache.Remove(key);
                return value;
            }
            else
            {
                throw new Exception("无效的键");
            }
        }

        public static object AddStorage(string key)
        {
            if (_cache.ContainsKey(key))
            {
                var value = _cache[key];
                //因为只当做缓存，所以取出之后就立马从列表中删除
                _cache.Remove(key);
                return value;
            }
            else
            {
                return null;
            }
        }

        public static void AddStorage(string key, object value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
            else
            {
                _cache.Add(key, value);
            }
        }

        public static void AddStorage(string[] keys, object[] values)
        {
//            if (_cache.ContainsKey(key))
//            {
//                _cache[key] = value;
//            }
//            else
//            {
//                _cache.Add(key, value);
//            }

            if (keys.Length != values.Length)
            {
                throw new Exception("批量添加缓存时键值的数量必须相等");
            }

            int index = 0;
            foreach (var key in keys)
            {
                if (_cache.ContainsKey(key))
                {
                    _cache[key] = values[index];
                }
                else
                {
                    _cache.Add(key, values[index]);
                }

                index++;
            }
        }

        public static object[] GetStorage(string[] keys)
        {
            object[] values = new object[keys.Length];

            int index = 0;
            foreach (var key in keys)
            {
                if (_cache.ContainsKey(key))
                {
                    values[index] = _cache[key];
                    //因为只当做缓存，所以取出之后就立马从列表中删除
                    _cache.Remove(key);
                }
                else
                {
                    values[index] = null;
                }
                index++;
            }
            return values;
        }

        public static void Clear()
        {
            _cache.Clear();
        }

        public static void Clear(string key)
        {
            if (_cache.ContainsKey(key))
            {
                _cache.Remove(key);
            }
        }
    }
}