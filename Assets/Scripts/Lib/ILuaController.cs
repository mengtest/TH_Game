using XLua;

namespace Lib
{
    /**
     * <summary>
     * 实际上controller在服务端
     * </summary>
     */
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ILuaController
    {
        //通知某项属性被修改了
        void Notify(string name, object property);

        //属性被修改
        void NotifyAll(object property);
        
        string GetMvcName();
        
        void SetMvcName(string name);
    }
}