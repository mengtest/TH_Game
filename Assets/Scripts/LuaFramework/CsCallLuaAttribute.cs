using System;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace LuaFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CsCallLuaAttribute : ContextAttribute
    {
        public CsCallLuaAttribute(string filePath) : base("CsCallLuaProxy")
        {
            Path = filePath;
        }

        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
            ctorMsg.ContextProperties.Add(1);
        }

        public string Path { get; set; }
    }
}