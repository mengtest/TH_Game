using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
        [SerializeField]
        public Global.Inject5[] regFunctions;

        private void Awake()
        {
            foreach (var f in regFunctions)
            {
                var root = "";
                if (f.tableName.Length != 0)
                {
                    root = f.tableName + ".";
                }

                root = $"{root}{f.funcName}";
                Functions.Register(root);

                //获取到这个目标属性的值
                var value = f.script.GetType().GetProperty(f.propertyName)?.GetValue(f.script);
                //添加事件
                var method = value?.GetType().GetMethod("AddListener");
                MethodInvoke(f.paraNum, method, value, root);
            }
        }
        
        private void MethodInvoke(uint paraNum, MethodInfo method, object value, string root)
        {
            switch (paraNum)
            {
                case 0:
                {
                    method.Invoke(value, new object[]
                        {
                            new UnityAction(() =>
                            {
                                Functions.GetAction(root).Call();
                            })
                        }
                    );
                    break;
                }
                case 1:
                {
//                    UnityAction<int> act;
//                    
//                    Type entityType = typeof(UnityAction<>);
//                    Assembly assy = Assembly.GetExecutingAssembly();
//                    var t = assy.GetType($"{assy.GetName().Name}.{entityType.Name}`1");
//                    var makeGenericType = t.MakeGenericType(method.GetParameters()[0].GetType());
//                    makeGenericType.GetConstructor(new []{Type.GetType("123")}).Invoke(new object[]{"123"});
//                    makeGenericType.
//                    Activator.CreateInstance(makeGenericType, (o) => { Functions.GetAction<float>(root); });
                    
                    method.Invoke(value, new object[]
                        {
                            
                        }
                    );
                    break;
                }
                case 2:
                {
//                    method.Invoke(value, new object[]
//                        {
//                            new UnityAction<object, object>((o1, o2) =>
//                            {
//                                Functions.GetAction<object, object>(root).Invoke();
//                            })
//                        }
//                    );
                    break;
                }
                case 3:
                {
//                    method.Invoke(value, new object[]
//                        {
//                            new UnityAction<object, object, object>((o1, o2, o3) =>
//                            {
//                                Functions.GetAction(root).Invoke();
//                            })
//                        }
//                    );
                    break;
                }
            }
        }
    }
}