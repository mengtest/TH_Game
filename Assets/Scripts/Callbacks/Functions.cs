using System;
using System.Collections.Generic;
using LuaFramework;
using UnityEngine;
using XLua;

namespace Callbacks
{
    public static partial class Functions
    {
        private static string EngineName = "Functions";
        private static Dictionary<string, Action> _callbacks = new Dictionary<string, Action>();

        public static void Init()
        {
            LuaEngineInit();
//            AddFunction("NavigateToMainScene", () => { Navigator.NavigateTo("MainScene"); });
        }

        private static LuaTable GetTable(string name)
        {
//            return LuaEngine.Instance().SubInstance(EngineName).Global.Get<LuaTable>(name);
            return null;
        }

        //lua引擎初始化
        private static void LuaEngineInit()
        {
            var script = Resources.Load<TextAsset>("LuaScript/Functions.lua");
//            var engine = LuaEngine.Instance().SubInstance(EngineName);
//            engine.DoString(script.text);
            
        }

        public static void Register(string name, Action callback)
        {
            _callbacks.Add(name, callback);
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
    }
}