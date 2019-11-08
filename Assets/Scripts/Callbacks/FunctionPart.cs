using System;
using LuaFramework;

namespace Callbacks
{
    partial class Functions
    {
        //action表示1返回值
        public delegate TR Action1<out TR>();
        public delegate TR Action1_1<in TP, out TR>(TP p1);
        public delegate TR1 Action1_2<in TP, in TP2, out TR1>(TP p1,TP2 r2);
        public delegate TR Action1_3<in TP1, in TP2, in TP3, out TR>(TP1 p1, TP2 p2, TP3 p3);
        public delegate TR1 Action2<out TR1, TR2>(out TR2 r2);
        public delegate TR1 Action3<out TR1, TR2, TR3>(out TR2 r2, out TR3 r3);
        public delegate TR1 Action2_1<in TP, out TR1, TR2>(TP p1, out TR2 r2);
        public delegate TR1 Action2_2<in TP1, in TP2, out TR1, TR2>(TP1 tp1, TP2 tp2, out TR2 tr2);
        public delegate TR1 Action2_3<in TP1,in TP2,in TP3, out TR1, TR2>(TP1 tp1,TP2 tp2,TP3 tp3,out TR2 r2);
        public delegate TR1 Action3_1<in TP, out TR1, TR2, TR3>(TP p1, out TR2 r2);
        public delegate TR1 Action3_2<in TP1, in TP2, out TR1, TR2, TR3>(TP1 tp1, TP2 tp2, out TR2 tr2, out TR3 r3);
        public delegate TR1 Action3_3<in TP1, in TP2, in TP3, out TR1, TR2, TR3>(TP1 tp1, TP2 tp2, TP3 tp3, out TR2 r2,
            out TR3 r3);
        
        public static void Register(this ILuaSupporter supporter)
        {
            var func = GetTable("Button").Get<Action>(supporter.GetFuncName());
            Register(supporter.GetFuncName(), func);
        }

        public static void Register(string name)
        {
            
        }

        //_前面的表示返回值个数，后面的表示参数个数，目前最多支持到3参数3返回值
        public static void Register1(string name)
        {
            
        }
        
        public static void Register2(string name)
        {
            
        }
        
        public static void Register3(string name)
        {
            
        }
        
        public static void Register_1(string name)
        {
            
        }
        
        public static void Register_2(string name)
        {
            
        }
        
        public static void Register_3(string name)
        {
            
        }
        
        public static void Register1_1(string name)
        {
            
        }
        
        public static void Register1_2(string name)
        {
            
        }
        
        public static void Register1_3(string name)
        {
            
        }
        
        public static void Register2_1(string name)
        {
            
        }
        
        public static void Register2_2(string name)
        {
            
        }
        
        public static void Register2_3(string name)
        {
            
        }
        
        public static void Register3_1(string name)
        {
            
        }
        
        public static void Register3_2(string name)
        {
            
        }
        
        public static void Register3_3(string name)
        {
            
        }
    }
}