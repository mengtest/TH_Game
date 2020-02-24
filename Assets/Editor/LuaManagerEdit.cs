// using System.Collections.Generic;
// using System.IO;
// using LuaFramework;
// using UnityEditor;
// using UnityEngine;
// using UnityEngine.SceneManagement;
//
// namespace Editor
// {
//     [CustomEditor(typeof(LuaManager))]
//     public class LuaManagerEdit: UnityEditor.Editor
//     {
//         private bool _init;
//         private List<GameObject> _loadedObjects = new List<GameObject>();
//         private static bool _globalInit;
//         private List<string> _names = new List<string>();
//
//         private void OnDestroy()
//         {
//             EditorApplication.hierarchyChanged -= AutoBind;
//         }
//
//         public override void OnInspectorGUI()
//         {
//             base.OnInspectorGUI();
//             
//             if (_init)
//             {
//                 return;
//             }
//             _init = true;
//             EditorApplication.hierarchyChanged += AutoBind;
//
//             if (_globalInit)
//             {
//                 return;
//             }
//             _globalInit = true;
//             Selection.selectionChanged += SelectedChanged;
//         }
//
//         /**
//          * 每次重新选择对象的时候都会更新当前选择的对象的名称的集合
//          */
//         private void SelectedChanged()
//         {
//             _names.Clear();
//             
//             foreach (var value in Selection.objects)
//             {
//                 _names.Add(value.name);
//             }
//         }
//         
//         /**
//          * <summary>
//          * 自动为节点绑定lua文件。
//          * 这里所作的操作就是,对已经被绑定过的lua文件，在editor中修改其名称时自动修改对应的lua文件的名称。
//          * 包括有根据节点叶子名称变化修改文件名以及非叶子节点修改文件名
//          * </summary>
//          */
//         private static void AutoBind()
//         {
//             foreach (var obj in Selection.objects)
//             {
//                 Bind(obj as GameObject);
//             }
//         }
//
//         private static void Bind(GameObject o)
//         {
//             if (o == null)
//             {
//                 return;
//             }
//             
//             var mgr = o.GetComponent<LuaManager>();
//             string pre = null;
//             pre = !mgr.Local ? $"Assets/Resources/LuaScript/modules/{Global.Scene.name}" 
//                 : $"Assets/Resources/LuaScript/modules/{o.name}";
//             
//             //遍历当前模块文件夹下面所有的lua文件
//             foreach (var value in Directory.EnumerateFiles(pre))
//             {
//                 var info = new FileInfo(value);
//                 //过滤掉所有结尾不是.txt的文件
//                 if (info.Extension != ".txt")
//                 {
//                     continue;
//                 }
//                 
//                 var fileName = info.Name;
//                 //将文件名按.切割
//                 var strings = fileName.Split('.');
//
//                 //如果是局部mgr且文件的前缀与mgr的名称不同时则话则直接跳过
//                 if ((mgr.Local && strings[0] != o.name) 
//                     //如果是全局mgr且文件名根据.切割后长度不为3的话则直接跳过
//                     /*|| (!mgr.Local && strings.Length != 3)*/)
//                 {
//                     continue;
//                 }
//
//                 if (mgr.Local)
//                 {
//                     //否则的话，查找这个文件名对应的节点是否存在
//                     //var s = fileName.Substring(o.name.Length + 1, fileName.Length - ".lua.txt".Length - o.name.Length);
//
//                     //通过修改之前的名称与当前的名称做对比
//                     //如果名称被修改了，那么就修改对应的lua文件名
//                     //因为这里会取出的字符串其实是包含了当前obj的名称的
//                     var s = fileName.Substring(o.name.Length + 1,
//                         fileName.Length - ".lua.txt".Length - o.name.Length);
//                     // var s = fileName.Replace(o.name + ".", "")
//                     //     .Replace(".lua", "");
//                     var go = o.transform.Find(s);
//                     if (go != null)
//                     {
//                         //文件名所对应的对象存在，则将这个文件绑定到这个对象上面
//                         mgr.BindList.Add(s);
//                     }
//                 }
//                 else
//                 {
//                     //否则的话，查找这个文件名对应的节点是否存在
//                     //Debug.Log(fileName.Substring(0, fileName.Length - ".lua.txt".Length));
//                     //Debug.Log(GameObject.Find(fileName.Substring(0, fileName.Length - ".lua.txt".Length)));
//                     var s = fileName.Substring(0, 
//                         fileName.Length - ".lua.txt".Length);
//                     
//                     var go = GameObject.Find(s);
//                     
//                     if (go != null)
//                     {
//                         mgr.BindList.Add(s);
//                     }
//                 }
//             }
//         }
//     }
// }