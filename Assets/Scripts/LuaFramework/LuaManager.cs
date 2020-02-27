using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace LuaFramework
{
    //添加这个属性，在editor模式中也会保存修改
    // [ExecuteAlways]
    public class LuaManager : MonoBehaviour/*Selectable*//*UIBehaviour*/
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

        [Tooltip("已经绑定了的lua文件列表")]
        // [SerializeField]
        private List<string> bindList;

        [Tooltip("不需要绑定的列表")]
        // [SerializeField]
        private List<string> banedList;

        private delegate void UpdateFunction();

        private UpdateFunction _update;
        
        public List<string> BanedList
        {
            get => banedList;
            set => banedList = value;
        }
        public List<string> BindList
        {
            get => bindList;
            set => bindList = value;
        }
        public Global.Injection2[] Functions => functions;
        public Global.Injection[] Injections => injections;
        public bool Local => local;

        private void Awake()
        {
            Time.timeScale = 1;
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
                    //现在非局部mgr会去加载与mgr名相同的文件夹下面的init.lua文件
                    path = gameObject.name + "/init.lua";
                }
                
                file = Util.Loader.Load<TextAsset>("LuaScript/modules/" + path);
            }

            // LoadScripts();
            
            if (file == null || file.text?.Length == 0)
            {
                return;
            }

            var table = LuaEngine.Instance.LoadString(file.text, path, injections);
            table.Get<Action<LuaManager>>("init")?.Invoke(this);

            _update = table.Get<UpdateFunction>("update");
            // _update?.Invoke();
            
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

        /**
         * 如果是全局的mgr则加载当前场景文件下面所有全局lua文件(没有任何前缀的)
         * 如果是非全局mgr则加载当前场下面所有非全局lua文件(以前当组件的名称为前缀+.的)
         * eg. 全局lua文件： asd.lua.txt    非全局lua文件：mgr名.asd.lua.txt
         */
        private void LoadScripts()
        {
            string pre;
            if (!local)
            {
                pre = $"Assets/Resources/LuaScript/modules/{Global.Scene.name}";
            }
            else
            {
                pre = $"Assets/Resources/LuaScript/modules/{name}";
            }

            //遍历当前模块文件夹下面所有的lua文件
            foreach (var value in Directory.EnumerateFiles(pre))
            {
                var info = new FileInfo(value);
                //过滤掉所有结尾不是.txt的文件
                if (info.Extension != ".txt")
                {
                    continue;
                }
                
                var fileName = info.Name;
                var strings = fileName.Split('.');
                //如果是局部mgr且文件的前缀与mgr的名称不同时则话则直接跳过
                if ((Local && fileName.Substring(0, name.Length) != name) 
                    //如果是全局mgr且文件名根据.切割后长度不为3的话则直接跳过
                    || (!Local && strings.Length != 3))
                {
                    continue;
                }

                if (Local)
                {
                    //因为这里会取出的字符串其实是包含了当前obj的名称的
                    var s = fileName.Substring(name.Length + 1, fileName.Length - ".lua.txt".Length - name.Length);
                    var go = transform.Find(s);
                    if (go != null && !bindList.Contains(s))
                    {
                        bindList.Add(s);
                    }
                }
                else
                {
                    //否则的话，查找这个文件名对应的节点是否存在
                    //Debug.Log(fileName.Substring(0, fileName.Length - ".lua.txt".Length));
                    //Debug.Log(GameObject.Find(fileName.Substring(0, fileName.Length - ".lua.txt".Length)));
                    var s = fileName.Substring(0, fileName.Length - ".lua.txt".Length);
                    var go = GameObject.Find(fileName.Substring(0, fileName.Length - ".lua.txt".Length));
                    if (go != null && !bindList.Contains(s))
                    {
                        bindList.Add(s);
                    }
                }
            }
        }
        
        private void Update()
        {
            _update?.Invoke();
        }

        // private void FixedUpdate()
        // {
        //     Global.Log("123123123123");
        // }
    }
}