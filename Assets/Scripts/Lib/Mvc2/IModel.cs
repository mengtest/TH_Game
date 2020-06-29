namespace Mvc2
{
    //存放数据，以及数据存储
    [XLua.LuaCallCSharp]
    [XLua.CSharpCallLua]
    public interface IMvcModel
    {
        object GetData();

        //这里所有的data全部都是lua里面的表，
        void SetData(object data);

        void Update(object data);

        string GetMvcName();

        void SendEvent(string name, object data);
    }
}