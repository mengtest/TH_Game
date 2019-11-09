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

        public static Action<T> GetAction<T>(ILuaSupporter supporter/*,string name*/)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数
            var eng = LuaEngine.MainInstance;
            var f = eng.GetSubInstance("functions").Get().Global
                .GetInPath<Action<T>>($"Button.{supporter.GetWord()}Callback");
            if (f != null && !_actions.ContainsKey(supporter.GetWord()))
            {
                _actions.Add(supporter.GetWord(), f);
            }
            return f;
        }
        
        public static Action GetAction(ILuaSupporter supporter/*,string name*/)
        {
            //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
            //尝试着获取一个Button域下面的回调函数
            var eng = LuaEngine.MainInstance;
            var f = eng.GetSubInstance("functions").Get().Global
                .GetInPath<Action>($"Button.{supporter.GetWord()}Callback");
            if (f != null && !_actions.ContainsKey(supporter.GetWord()))
            {
                _actions.Add(supporter.GetWord(), f);
            }
            return f;
        }
    }
}