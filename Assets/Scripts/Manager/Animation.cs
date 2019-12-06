using System;
using EX;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Manager
{
    public class Animation
    {
        
        
        public static void Play(string[] paths, float interval, int loop = 1, float delay = 0, Action callback = null)
        {
            var obj = new GameObject("animation");
            var ani = obj.AddComponent<AnimationEx>();
            ani.LoadImages(paths);
            if (callback != null)
            {
                callback += () =>
                {
                    Object.Destroy(obj);
                };
            }
            else
            {
                callback = () =>
                {
                    Object.Destroy(obj);
                };
            }
            ani.Play(delay, interval, loop, callback);
        }
    }
}