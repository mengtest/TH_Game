using UnityEngine;
using XLua;

namespace LuaFramework
{

    [System.Serializable]
    public class LuaClass
    {
        [SerializeField]
        private string _filePath;
        [SerializeField]
        private Global.Injection[] _injections;
        [SerializeField] 
        private string _name;
        [SerializeField] 
        private bool _mappingSlef = true;
        
        private LuaTable _tb;

        protected virtual void Ref(MonoBehaviour self)
        {
            //如果路径为空，则不会注册该对象
            if (string.IsNullOrEmpty(_filePath) || string.IsNullOrEmpty(_name))
            {
                return;
            }
            
            if (!_mappingSlef)
            {
                self = null;
            }
            
            _tb = LuaEngine.Instance.LoadFile(_filePath, _name, self, _injections);
        }
        
        protected virtual void Ref(GameObject self)
        {
            //如果路径为空，则不会注册该对象
            if (string.IsNullOrEmpty(_filePath) || string.IsNullOrEmpty(_name))
            {
                return;
            }
            
            if (!_mappingSlef)
            {
                self = null;
            }
            
            _tb = LuaEngine.Instance.LoadFile(_filePath, _name, self, _injections);
        }

        public T Get<T>(string funName)
        {
            return _tb.Get<T>(funName);
        }
        
        public void Get<T>(string funName, out T value)
        {
            _tb.Get(funName, out value);
        }
    }
}