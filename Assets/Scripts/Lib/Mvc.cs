using System;
using System.Collections.Generic;

namespace Lib
{
    /// <summary>
    /// 迷你型的mvc
    /// </summary>
    public static class Mvc
    {
        private static Dictionary<string, ILuaData> _models = new Dictionary<string, ILuaData>();
        private static Dictionary<string, ILuaController> _controllers = new Dictionary<string, ILuaController>();
        private static Dictionary<string, LuaView> _views = new Dictionary<string, LuaView>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="view"></param>
        /// <exception cref="Exception"></exception>
        public static void RegisterView(string name, LuaView view)
        {
            if (_views.ContainsKey(name))
            {
                throw new Exception("重复的键");
            }
            else
            {
                view.SetMvcName(name);
                _views.Add(name, view);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public static void RegisterModel(string name, ILuaData data)
        {
            if (_models.ContainsKey(name))
            {
                throw new Exception("重复的键");
            }
            else
            {
                data.SetMvcName(name);
                _models.Add(name, data);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="controller"></param>
        /// <exception cref="Exception"></exception>
        public static void RegisterController(string name, ILuaController controller)
        {
            if (_controllers.ContainsKey(name))
            {
                throw new Exception("重复的键");
            }
            else
            {
                controller.SetMvcName(name);
                _controllers.Add(name, controller);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="view"></param>
        /// <param name="ctrl"></param>
        public static void Register(string name,ILuaData model, LuaView view, ILuaController ctrl)
        {
            RegisterView(name, view);
            RegisterModel(name, model);
            RegisterController(name, ctrl);
        }

        /// <summary>
        /// 取消注册
        /// </summary>
        /// <param name="name"></param>
        public static void Unregister(string name)
        {
            UnregisterView(name);
            UnregisterModel(name);
            UnregisterController(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ILuaController UnregisterController(string name)
        {
            var controller = _controllers[name];
            _controllers.Remove(name);
            return controller;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ILuaData UnregisterModel(string name)
        {
            var model = _models[name];
            _models.Remove(name);
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static LuaView UnregisterView(string name)
        {
            var view = _views[name];
            _views.Remove(name);
            return view;
        }

        /// <summary>
        /// 通知一个视图，属性产生了变化
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void Notify(string name, object value)
        {
            if (_views.ContainsKey(name))
            {
                _views[name].HandleEvent(value);
            }
        }
    }
}