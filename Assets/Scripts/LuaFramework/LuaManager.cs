using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
        [SerializeField]
        private TextAsset file;

        [Tooltip("")]
        [SerializeField]
        private Global.Injection2[] injections;

        private void Awake()
        {
            if (file == null)
            {
                throw new Exception("");
            }
            
            var table = LuaEngine.Instance.LoadString(file.text, SceneManager.GetActiveScene().name);

            foreach (var injection in injections)
            {
                if (injection.name.Length ==0 && injection.go == null)
                {
                    continue;
                }
                
                var key = injection.name.Length == 0 ? injection.go.name : injection.name;

                table.Get(key, out Action<GameObject> func);
                func?.Invoke(injection.go);
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