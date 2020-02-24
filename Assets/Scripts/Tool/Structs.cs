using UnityEngine;
using UnityEngine.Serialization;
using XLua;

partial class Global
{
    [System.Serializable]
    [LuaCallCSharp]
    public class Pair<TKey, TValue>
    {
        public TKey First;
        public TValue Second;

        public Pair(TKey key, TValue value)
        {
            First = key;
            Second = value;
        }

        public Pair()
        {
            
        }
    }

    [System.Serializable]
    public struct Injection
    {
        [FormerlySerializedAs("Name")] 
        public string name;
        [FormerlySerializedAs("Value")] 
        public MonoBehaviour value;
    }
    
    
    [System.Serializable]
    public struct Injection2
    {
        [Tooltip("要调用的函数名")]
        public string name;
        [Tooltip("self对象")]
        public GameObject go;
    }

    [System.Serializable]
    public class Inject5
    {
        [System.Serializable]
        public class Optional
        {
            [Tooltip("需要加载的文件名")]
            public string file;
            [Tooltip("此文件对应的表名")]
            public string name;
        }
        [Tooltip("表名,非必填参数")]
        public string tableName;
        [Tooltip("注入回调的脚本")]
        public MonoBehaviour script;
        [Tooltip("属性名,例如button中的onClick")]
        public string propertyName;
        [Tooltip("调用的函数名，必须完全一致")]
        public string funcName;
        [Tooltip("参数个数")]
        public uint paraNum = 0;
        [Tooltip("可选参数")]
        public Optional optional;
    }
}