using UnityEngine;

namespace Mvc2
{
    //提供cs接口，在lua侧实现这个接口中所有的函数
    //view里面绑定了一个游戏对象（获取mono），在触发事件的时候在这里对这个view做更新
    [XLua.LuaCallCSharp]
    [XLua.CSharpCallLua]
    public interface IMvcView
    {
        //绑定GameObject，要求调用BindXXX之后不能再次绑定
        void BindGameObject(GameObject go);

        //绑定Mono
        void BindMono(MonoBehaviour mb);

        //是否已经调用过BindXXX函数
        bool Bind();

        //获取当前view绑定的对象
        MonoBehaviour GetBindGameObject();

        //获取当前对象的mvc名称
        string GetMvcName();

        //获取与当前view关联的模型
        IMvcModel GetModel();

        //发送一个事件
        void HandelEvent(string name,object data);

        //注册所有当前view感兴趣的事件
        void RegisterAll();

        bool Contain(string name);
    }
}