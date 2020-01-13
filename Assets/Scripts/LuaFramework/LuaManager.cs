using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("全局mgr可以不用设置这个项，全局mgr会自动加载对应场景的init方法，非全局mgr则会加载这个mgr的名称所对应的lua文件")]
        private TextAsset file;

        [Tooltip("自动调用的函数")]
        [SerializeField]
        private Global.Injection2[] functions;

        [Tooltip("C#端传递给lua端的参数")]
        [SerializeField]
        private Global.Injection[] injections;
        
        [SerializeField]
        [Tooltip("是否是局部mgr，局部mgr主要应用于预制资源")]
        private bool local = true;

        private void Awake()
        {
            var path = "";
            //即使是全局mgr，也只是说可以不用设置file属性，mgr会自动去加载一个lua文件，并执行其中的init方法
            //也可以手动设置file字段，这时也会去执行init方法
            if (file == null)
            {
                if (!local)
                {
                    path = Global.Scene.name + "/init.lua";
                }
                else
                {
                    path = Global.Scene.name + "/" + gameObject.name + ".lua";
                }

                try
                {
                    file = Util.Loader.Load<TextAsset>("LuaScript/modules/" + path);
                }
                catch (Exception e)
                {
                    Debug.Log("file字段为空，且无法自动加载");
                    throw;
                }
            }

            var table = LuaEngine.Instance.LoadString(file.text, path, injections);
            table.Get<Action<LuaManager>>("init")?.Invoke(this);
            
            foreach (var injection in functions)
            {
                if (injection.name.Length == 0 && injection.go == null)
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