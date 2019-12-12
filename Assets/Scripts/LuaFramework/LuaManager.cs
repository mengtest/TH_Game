using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
        [SerializeField]
        private string file;

        [Tooltip("")]
        [SerializeField]
        private Global.Injection2[] injections;

        private void Awake()
        {
            var table = LuaEngine.Instance.LoadFile(file, file);

            foreach (var injection in injections)
            {
                table.Get(injection.name, out Action<GameObject> go);
                go.Invoke(injection.go);
            }

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