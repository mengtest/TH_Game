using XLua;

namespace Lib
{
    /// <summary>
    /// 实际上controller在服务端
    /// </summary>
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ILuaController
    {
        /// <summary>
        /// 通知某项属性被修改了
        /// </summary>
        /// <param name="name"></param>
        /// <param name="property"></param>
        void Notify(string name, object property);

        /// <summary>
        /// 属性被修改
        /// </summary>
        /// <param name="property"></param>
        void NotifyAll(object property);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetMvcName();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        void SetMvcName(string name);
    }
}