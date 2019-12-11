using System;
using System.Collections.Generic;

namespace LuaFramework
{
    //通过lua读取到的所有方法，委托等
    public static class Functions
    {
        private static Dictionary<string, object> _actions = new Dictionary<string, object>();

        public static void Register(this ILuaSupporter supporter)
        {
            GetAction(supporter);
        }

        public static void Register(string name)
        {
            
        }

        public static Action<T> GetAction<T>(ILuaSupporter supporter)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数

            var eng = LuaEngine.Instance;
            if (eng == null)
            {
                return null;
            }
            var f = eng.GetTable("functions")
                .GetInPath<Action<T>>($"Button.{supporter.GetFuncName()}");
            if (f != null && !_actions.ContainsKey(supporter.GetFuncName()))
            {
                _actions.Add(supporter.GetFuncName(), f);
            }
            return f;
        }

        public static Action<T> GetAction<T>(string name)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数

            var eng = LuaEngine.Instance;
            if (eng == null)
            {
                return null;
            }
            var f = eng.GetTable("functions")
                .GetInPath<Action<T>>(name);
            if (f != null && !_actions.ContainsKey(name))
            {
                _actions.Add(name, f);
            }
            return f;
        }
        
        public static Action GetAction(string name)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数
            var eng = LuaEngine.Instance;
            if (eng == null)
            {
                return null;
            }
            var f = eng.GetTable("functions")
                .GetInPath<Action>(name);
            if (f != null && !_actions.ContainsKey(name))
            {
                _actions.Add(name, f);
            }
            return f;
        }

        public static Action GetAction(ILuaSupporter supporter)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数
            var eng = LuaEngine.Instance;
            if (eng == null)
            {
                return null;
            }
            var f = eng.GetTable("functions")
                .GetInPath<Action>($"Button.{supporter.GetFuncName()}");
            if (f != null && !_actions.ContainsKey(supporter.GetFuncName()))
            {
                _actions.Add(supporter.GetFuncName(), f);
            }
            return f;
        }
    }
}