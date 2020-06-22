using System.Collections.Generic;
namespace Mvc2
{
    public interface IMvcController
    {
        // private Dictionary<string, Global.Pair<IMvcModel, MvcView>> views = new Dictionary<string, Global.Pair<IMvcModel, MvcView>>();

        public IMvcModel GetModel(string name);
        // {
            
        //     return null;
        // }

        public MvcView GetView(string name);
        // {

        //     return null;
        // }

        public void Bind(string name, IMvcModel model);
        // {
            
        // }

        public void Bind(string name, MvcView view);
        // {
            
        // }
    }
}