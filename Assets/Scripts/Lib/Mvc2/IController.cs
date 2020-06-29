using System;

namespace Mvc2
{
    [XLua.LuaCallCSharp]
    [XLua.CSharpCallLua]
    public interface IMvcController
    {
        //ִ���¼�
        void Execute(object data);
    
        IMvcView GetView();
    
        IMvcModel GetModel();

        //ע��ģ��
        void RegisterModel(IMvcModel model);
        //ע����ͼ
        void RegisterView(IMvcView view);

        //ע�������
        void RegisterController(string eventName,IMvcController controllerType);
    }
}