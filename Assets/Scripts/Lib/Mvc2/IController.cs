namespace Mvc2
{
    public interface IMvcController
    {
        IMvcModel GetModel(string name);
        
        IMvcView GetView(string name);

        void Bind(string name, IMvcModel model);

        void Bind(string name, IMvcView view);
    }
}