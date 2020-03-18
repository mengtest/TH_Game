using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lib
{
    public static class Mvc
    {
        private static Dictionary<string, ILuaData> _models = new Dictionary<string, ILuaData>();

        private static Dictionary<string, ILuaController> _controllers = new Dictionary<string, ILuaController>();
        
        private static Dictionary<string, LuaView> _views = new Dictionary<string, LuaView>();

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

        public static ILuaController UnregisterController(string name)
        {
            var controller = _controllers[name];
            _controllers.Remove(name);
            return controller;
        }
        
        public static ILuaData UnregisterModel(string name)
        {
            var model = _models[name];
            _models.Remove(name);
            return model;
        }

        public static LuaView UnregisterView(string name)
        {
            var view = _views[name];
            _views.Remove(name);
            return view;
        }

        public static void Notify(string name, object value)
        {
            if (_views.ContainsKey(name))
            {
                _views[name].HandleEvent(value);
            }
        }
    }
}