using System;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

namespace LuaFramework
{
    class CsCallLuaSink : IMessageSink
    {
        public CsCallLuaSink(IMessageSink msg)
        {
            NextSink = msg;
        }
        
        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            Debug.Log("触发了一个异步代理");
            return null;
        }

        public IMessage SyncProcessMessage(IMessage msg)
        {
            PreProgress(msg);
            var ret = NextSink.SyncProcessMessage(msg);
            PostProgress(msg, ret);
            return ret;
        }
        
        //如果调用有返回值的，会插入到调用函数前面
        private void PreProgress(IMessage msg)
        {
            
        }

        //如果调用没有返回值的，会插入到调用函数后面
        private void PostProgress(IMessage msg, IMessage retMsg)
        {
            
        }

        public IMessageSink NextSink { get; }
    }
    
    class CsCallLuaProperty : IContextProperty,IContributeObjectSink
    {
        public CsCallLuaProperty()
        {
            Name = "CsCallLuaProperty";
        }
        
        public void Freeze(Context newContext)
        {
            
        }

        public bool IsNewContextOK(Context newCtx)
        {
            //这个地方不是判断上下文环境是否正确的吗？为什么返回false会报错？
            return true;
        }

        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
        {
            return new CsCallLuaSink(nextSink);
        }
        
        public string Name { get; }
    }
    
    [AttributeUsage(AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = true
    )]
    public class CsCallLuaAttribute : ContextAttribute
    {
        //需要映射的文件路径
        public CsCallLuaAttribute(string filePath) : base("MyCsCallLuaContext")
        {
            Path = filePath;
        }

        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
            ctorMsg.ContextProperties.Add(new CsCallLuaProperty());
        }

        public string Path { get; set; }
    }
}