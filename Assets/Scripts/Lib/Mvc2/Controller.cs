using System.Collections.Generic;
namespace Mvc2
{
    public interface IMvcController
    {
        // private Dictionary<string, Global.Pair<IMvcModel, MvcView>> views = new Dictionary<string, Global.Pair<IMvcModel, MvcView>>();

        IMvcModel GetModel(string name);
        // {
            
        //     return null;
        // }

        MvcView GetView(string name);
        // {

        //     return null;
        // }

        void Bind(string name, IMvcModel model);
        // {
            
        // }

        void Bind(string name, MvcView view);
        // {
            
        // }
    }
}