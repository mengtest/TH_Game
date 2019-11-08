using System;

namespace LuaFramework
{
    //通过lua读取到的所有方法，委托等
    public class Functions
    {
//        public delegate void Funcs(string arg);
//        public delegate void Funci(int arg);
//        public delegate void Funcb(bool arg);
//        public delegate void Func();

        public Action<T> GetAction<T>(string name)
        {
            return null;
        }
    }
}