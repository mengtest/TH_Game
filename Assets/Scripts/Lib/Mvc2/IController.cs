using System;
using XLua;

namespace Mvc2
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface IMvcController
    {
        //执行事件
        void Execute(object data);
    
        IMvcView GetView();
    
        IMvcModel GetModel();

        //注册模型
        void RegisterModel(IMvcModel model);
        //注册视图
        void RegisterView(IMvcView view);

        //注册控制器
        void RegisterController(string eventName,IMvcController controllerType);
    }
}