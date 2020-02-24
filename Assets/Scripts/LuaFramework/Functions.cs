// using System;
// using System.Collections.Generic;
// using UnityEngine;
// using XLua;
//
// namespace LuaFramework
// {
//     //通过lua读取到的所有方法，委托等
//     public static class Functions
//     {
//         private static Dictionary<string, object> _actions = new Dictionary<string, object>();
//
//         public static void Register(this ILuaSupporter supporter)
//         {
//             GetAction(supporter);
//         }
//
//         public static void Register(string name)
//         {
//             GetAction(name);
//         }
//
//         public static LuaFunction GetAction<T>(ILuaSupporter supporter)
//         {
//             //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
//             //尝试着获取一个Button域下面的回调函数
//
//             var eng = LuaEngine.Instance;
//             if (eng == null)
//             {
//                 return null;
//             }
//             var f = eng.GetTable("functions")
//                 .GetInPath<LuaFunction>($"Button.{supporter.GetFuncName()}");
//             if (f != null && !_actions.ContainsKey(supporter.GetFuncName()))
//             {
//                 _actions.Add(supporter.GetFuncName(), f);
//             }
//             return f;
//         }
//
//         public static LuaFunction GetAction<T>(string name)
//         {
//             //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
//             //尝试着获取一个Button域下面的回调函数
//
//             var eng = LuaEngine.Instance;
//             if (eng == null)
//             {
//                 return null;
//             }
//             var f = eng.GetTable("functions")
//                 .GetInPath<LuaFunction>(name);
//             if (f != null && !_actions.ContainsKey(name))
//             {
//                 _actions.Add(name, f);
//             }
//             return f;
//         }
//         
//         public static LuaFunction GetAction(string name)
//         {
//             //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
//             //尝试着获取一个Button域下面的回调函数
//             var eng = LuaEngine.Instance;
//             if (eng == null)
//             {
//                 return null;
//             }
//             var f = eng.GetTable("functions")
//                 .GetInPath<LuaFunction>(name);
//             if (f != null && !_actions.ContainsKey(name))
//             {
//                 _actions.Add(name, f);
//             }
//             return f;
//         }
//
//         public static LuaFunction GetAction(ILuaSupporter supporter)
//         {
//             //实际使用的时候应该是根据调用这个函数的对象的实际类型来获取到指定的域
//             //尝试着获取一个Button域下面的回调函数
//             var eng = LuaEngine.Instance;
//             if (eng == null)
//             {
//                 return null;
//             }
//             var f = eng.GetTable("functions")
//                 .GetInPath<LuaFunction>($"Button.{supporter.GetFuncName()}");
//             if (f != null && !_actions.ContainsKey(supporter.GetFuncName()))
//             {
//                 _actions.Add(supporter.GetFuncName(), f);
//             }
//             return f;
//         }
//     }
// }