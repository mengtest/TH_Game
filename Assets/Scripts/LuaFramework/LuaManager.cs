using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
//        [SerializeField]
//        public Global.Inject5[] regFunctions;

        [SerializeField]
        private string file;

        
        
        private void Awake()
        {
            
            
            
//            foreach (var f in regFunctions)
//            {
//                var root = "";
//                if (f.tableName.Length != 0)
//                {
//                    root = f.tableName + ".";
//                }
//
//                root = $"{root}{f.funcName}";
//                Functions.Register(root);
//
//                //获取到这个目标属性的值
//                var value = f.script.GetType().GetProperty(f.propertyName)?.GetValue(f.script);
//                //添加事件
//                var method = value?.GetType().GetMethod("AddListener");
////                MethodInvoke(f.paraNum, method, value, root);
//            }
        }
    }
}