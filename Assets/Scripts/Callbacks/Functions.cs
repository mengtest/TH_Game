using System;
using System.Collections.Generic;
using Global;

namespace Callbacks
{
    public static class Functions
    {
        public enum CallbackType
        {
            BUTTON,
        }

        public static void Init()
        {
            AddFunction("NavigateToMainScene", () => { Navigator.NavigateTo("MainScene"); });
        }

        public static void LoadScript()
        {
            
        }

        public static void ClearScriptFunction()
        {
            
        }

        //获取到一个被注册的函数，并且获取之后删除掉对应的引用
        public static Action GetFunctionOnce(string funName)
        {
            if (_callbacks.ContainsKey(funName))
            {
                var callback = _callbacks[funName];
                _callbacks.Remove(funName);
                return callback;
            }
            return null;
        }

        public static Action GetFunction(string funName)
        {
            if (_callbacks.ContainsKey(funName))
            {
                return _callbacks[funName];
            }
            return null;
        }

        //注册一个函数
        public static bool AddFunction(string funName, Action callback)
        {
            if (_callbacks.ContainsKey(funName))
            {
//                throw new Exception("无法重复添加同名的函数");
                return false;
            }
            else
            {
                _callbacks.Add(funName, callback);
                return true;
            }
        }

        //修改键为funName的回调函数
        public static void ModifyFunction(string funName, Action callback)
        {
            if (_callbacks.ContainsKey(funName))
            {
                _callbacks[funName] = callback;
            }
            else
            {
                _callbacks.Add(funName, callback);
            }
        }

        private static Dictionary<string, Action> _callbacks = new Dictionary<string, Action>();
    }
}