//using System;
//using System.Threading;
//using UnityEngine;
//using XLua;
//
//namespace LuaFramework
//{
//    public class LuaEngine : IDisposable
//    {
//        private static LuaEngine _engine;
//        private static Mutex _instanceMtx = new Mutex();
//        private LuaEnv _env;
//
//        public static LuaEngine Instance
//        {
//            get
//            {
//                if (_engine == null)
//                {
//                    _instanceMtx.WaitOne();
//                    if (_engine == null)
//                    {
//                        _engine = new LuaEngine();
//                    }
//                    _instanceMtx.ReleaseMutex();
//                }
//                return _engine;
//            }
//        }
//        
//        private LuaEngine()
//        {
//            _env = new LuaEnv();
//        }
//
//        public LuaEnv Get()
//        {
//            return _env;
//        }
//
//        public void LoadFile(string path)
//        {
//            _env.DoString(Resources.Load<TextAsset>(path).text);
//        }
//        
//        public void LoadFile(string path,string name)
//        {
//            
//        }
//
//        public void Dispose()
//        {
//            _env.Dispose();
//        }
//    }
//}