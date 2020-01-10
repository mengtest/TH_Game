using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EX;
using UnityEngine;
using XLua;
using Object = UnityEngine.Object;

namespace Manager
{
    [LuaCallCSharp]
    public static class Animation
    {
        private static LinkedList<Global.Pair<int, AnimationEx>>
            _list = new LinkedList<Global.Pair<int, AnimationEx>>();

        private const int BASE = 100;

        private static void RemoveChild(int id)
        {
            foreach (Global.Pair<int,AnimationEx> pair in _list)
            {
                if (pair.First == id)
                {
                    _list.Remove(pair);
                }
            }
        }
        
        
        public static GameObject Play(string[] paths, float interval, out int id, int loop = 1, float delay = 0, Action callback = null)
        {
            var obj = new GameObject("animation");
            var ani = obj.AddComponent<AnimationEx>();
            ani.LoadImages(paths);
            var index = GetId();
            id = index;
            if (callback != null)
            {
                callback += () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            else
            {
                callback = () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            ani.Play(delay, interval, loop, callback);
            _list.Append(new Global.Pair<int, AnimationEx>(id, ani));
            return obj;
        }

        private static int GetId()
        {
            if (_list.Count == 0)
            {
                return BASE;
            }
            return _list.Last.Value.First + 1;
        }
        
        public static GameObject Play(string path, float interval,int start, int end, out int id, int loop = 1, float delay = 0, Action callback = null)
        {
            if (path[path.Length - 1] != '/')
            {
                throw new Exception("无效的路径");
            }
            
            var obj = new GameObject("animation");
            var ani = obj.AddComponent<AnimationEx>();

            string[] paths = new String[end - start + 1];

            for (int count = 0, i = start; i <= end; i++)
            {
                paths[count] = $"{path}{i}";
                count++;
            }
            
            ani.LoadImages(paths);
            var index = GetId();
            id = index;
            if (callback != null)
            {
                callback += () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            else
            {
                callback = () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            ani.Play(delay, interval, loop, callback);
            
            _list.AddLast(new Global.Pair<int, AnimationEx>(id, ani));
            return obj;
        }
        
        public static GameObject Play(string path, float interval, out int id, int loop = 1, float delay = 0, Action callback = null)
        {
            if (path[path.Length - 1] != '/')
            {
                throw new Exception("无效的路径");
            }
            
            var obj = new GameObject("animation");
            var ani = obj.AddComponent<AnimationEx>();

            ani.LoadImages(path);
            var index = GetId();
            id = index;
            if (callback != null)
            {
                callback += () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            else
            {
                callback = () =>
                {
                    Object.Destroy(obj);
                    RemoveChild(index);
                };
            }
            ani.Play(delay, interval, loop, callback);
            
            _list.AddLast(new Global.Pair<int, AnimationEx>(id, ani));
            return obj;
        }

        public static void PauseTo(int id, int index = -1)
        {
            foreach (Global.Pair<int,AnimationEx> pair in _list)
            {
                if (pair.First == id)
                {
                    pair.Second.Pause(index);
                    return;
                }
            }
        }

        public static void Stop(int id)
        {
            foreach (Global.Pair<int,AnimationEx> pair in _list)
            {
                if (pair.First == id)
                {
                    Global.Log(Thread.CurrentThread.ManagedThreadId.ToString());
                    pair.Second.Stop(true);
                    _list.Remove(pair);
                    return;
                }
            }
        }

        public static void Continue(int id)
        {
            foreach (Global.Pair<int,AnimationEx> pair in _list)
            {
                if (pair.First == id)
                {
                    pair.Second.Continue();
                    return;
                }
            }
        }
    }
}