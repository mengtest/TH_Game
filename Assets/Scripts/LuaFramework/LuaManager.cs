using System;
using UnityEngine;
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
                try
                {
                    file = Util.Loader.Load<TextAsset>("LuaScript/scenes/" + Global.Scene.name + ".lua");
                }
                catch (Exception e)
                {
                    Debug.Log(e.Message);
                    Debug.Log("添加LuaManager之后必须设置脚本文件或者存在与场景同名的脚本");
                    throw;
                }
            }
            
            var table = LuaEngine.Instance.LoadString(file.text, SceneManager.GetActiveScene().name);
            table.Get<Action<LuaManager>>("init")?.Invoke(this);

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

            #region MyRegion
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
            #endregion
        }
    }
}