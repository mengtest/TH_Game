using UnityEngine;
using XLua;

namespace Lib
{
    /**
     * <summary>
     *这个其实就是MonoBehavior
     * </summary>
     */
    public class LuaView: MonoBehaviour
    {
        private string _mvcName;
        private event MvcHandle _handle;
        
        [LuaCallCSharp]
        [CSharpCallLua]
        //处理单个事件
        public delegate void MvcHandle(object value);
        //处理多个事件
        // public delegate void MvcHandleAll(object value);

        public string GetMvcName()
        {
            return _mvcName;
        }

        public void SetMvcName(string mvcName)
        {
            _mvcName = mvcName;
        }

        public virtual void HandleEvent(object value)
        {
            _handle?.Invoke(value);
        }

        public void RegisterHandle(MvcHandle handle)
        {
            _handle = handle;
        }
    }
}