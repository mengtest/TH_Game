//using System;
//using System.Runtime.Remoting.Activation;
//using System.Runtime.Remoting.Contexts;
//using System.Runtime.Remoting.Messaging;
//using UnityEngine;
//
//namespace LuaFramework
//{
//    public enum MappingMethod
//    {
//        Include,
//        Exclude,
//        All,
//    }
//    
//    struct InfoStruct
//    {
//        public string Path;
//        public MappingMethod Method;
//        public string[] Methods;
//    }
//    
//    class CsCallLuaSink : IMessageSink
//    {
//        public CsCallLuaSink(IMessageSink msg, InfoStruct info)
//        {
//            NextSink = msg;
//            _info = info;
//        }
//        
//        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
//        {
//            Debug.Log("触发了一个异步代理");
//            return null;
//        }
//
//        public IMessage SyncProcessMessage(IMessage msg)
//        {
//            PreProgress(msg);
//            var ret = NextSink.SyncProcessMessage(msg);
//            PostProgress(msg, ret);
//            return ret;
//        }
//        
//        private void PreProgress(IMessage msg)
//        {
//            
//        }
//
//        //如果调用没有返回值的，会插入到调用函数后面
//        private void PostProgress(IMessage msg, IMessage retMsg)
//        {
//            IMethodCallMessage call = msg as IMethodCallMessage;
//            
//        }
//        
//        public IMessageSink NextSink { get; }
//
//        private InfoStruct _info;
//    }
//
//    class CsCallLuaSinkExclude : IMessageSink
//    {
//        public CsCallLuaSinkExclude(IMessageSink msg, InfoStruct info)
//        {
//            NextSink = msg;
//            _info = info;
//        }
//        
//        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
//        {
//            return null;
//        }
//
//        public IMessage SyncProcessMessage(IMessage msg)
//        {
//            throw new NotImplementedException();
//        }
//
//        public IMessageSink NextSink { get; }
//
//        private InfoStruct _info;
//    }
//    
//    class CsCallLuaProperty : IContextProperty,IContributeObjectSink
//    {
//        public CsCallLuaProperty(InfoStruct info)
//        {
//            Name = "CsCallLuaProperty";
//            _info = info;
//        }
//        
//        public void Freeze(Context newContext)
//        {
//            
//        }
//
//        public bool IsNewContextOK(Context newCtx)
//        {
//            //这个地方不是判断上下文环境是否正确的吗？为什么返回false会报错？
//            return true;
//        }
//
//        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
//        {
//            if (_info.Method == MappingMethod.Exclude)
//            {
//                return new CsCallLuaSinkExclude(nextSink, _info);
//            }
//            return new CsCallLuaSink(nextSink, _info);
//        }
//        
//        public string Name { get; }
//
//        private InfoStruct _info;
//    }
//    
//    [AttributeUsage(AttributeTargets.Class)]
//    public class CsCallLuaAttribute : ContextAttribute
//    {
//        //需要映射的文件路径
//        //映射的方式，   是包含所给list，不包含所给list，或者全部包含
//        public CsCallLuaAttribute(string filePath, MappingMethod method = MappingMethod.All, string[] list = null) 
//            : base("MyCsCallLuaContext")
//        {
//            _info = new InfoStruct {
//                Path = filePath,
//                Method = method,
//                Methods = list
//            };
//        }
//
//        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
//        {
//            //文件不存在，直接返回
//            //这里有一个问题，如果直接返回的话， 在使用反射的时候回报错
////            if (!File.Exists(_info.Path))
////            {
////                return;
////            }
//
//            //感觉需要通过配置文件去配置根目录
//            string root = "";
//            var txt = Resources.Load<TextAsset>(root + _info.Path);
//
//            //映射方法为空，直接返回
//            if ((_info.Methods == null || _info.Methods.Length == 0) && _info.Method == MappingMethod.Include)
//            {
//                return;
//            }
//            
//            ctorMsg.ContextProperties.Add(new CsCallLuaProperty(_info));
//        }
//
//        private InfoStruct _info;
//    }
//}