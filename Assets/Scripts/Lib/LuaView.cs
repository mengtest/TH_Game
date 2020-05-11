using UnityEngine;
using XLua;

namespace Lib
{
    /// <summary>
    /// 处理一个事件
    /// </summary>
    /// <param name="value"></param>
    [LuaCallCSharp]
    [CSharpCallLua]
    public delegate void MvcHandle(LuaView view,object value);

    /**
     * <summary>
     *这个其实就是MonoBehavior
     * </summary>
     */
    public class LuaView: MonoBehaviour
    {
        private string _mvcName;
        private event MvcHandle _handle;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetMvcName()
        {
            return _mvcName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mvcName"></param>
        public void SetMvcName(string mvcName)
        {
            _mvcName = mvcName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public virtual void HandleEvent(object value)
        {
            _handle?.Invoke(this, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        public void RegisterHandle(MvcHandle handle)
        {
            _handle = handle;
        }
    }
}