using System;
using LuaFramework;

namespace Callbacks
{
    partial class Functions
    {
        public static void Register(this ILuaSupporter supporter)
        {
            var func = GetTable("Button").Get<Action>(supporter.GetFuncName());
            Register(supporter.GetFuncName(), func);
        }
    }
}