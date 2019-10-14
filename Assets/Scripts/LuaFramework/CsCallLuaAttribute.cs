using System;
using System.Runtime.InteropServices;

namespace LuaFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CsCallLuaAttribute : Attribute
    {
        public CsCallLuaAttribute(string filePath)
        {
            Path = filePath;
        }

        public string Path { get; set; }
    }
}