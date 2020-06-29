using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mvc2
{
    [XLua.LuaCallCSharp]
    public static class Mvc
    {        
        //名字 -- model(保存的是实例对象)
        public static Dictionary<string, IMvcModel> Models = new Dictionary<string, IMvcModel>();
        //名字 -- view(保存的是实例对象)
        public static Dictionary<string, IMvcView> Views = new Dictionary<string, IMvcView>();
        //事件名字 -- 类型 (保存的是类)
        public static Dictionary<string, IMvcController> ComandMap = new Dictionary<string, IMvcController>();
        
        //注册view,注意这里的view其实是由 继承于View的子类上溯而来(下同)
        public static void RegisterView(IMvcView view)
        {
            //防止view的重复注册
            if(Views.ContainsKey(view.GetMvcName()))
            {
                Views.Remove(view.GetMvcName());
            }
            view.RegisterAll();//调用视图方法,注册视图关心事件,存放在关心事件列表中
            Views[view.GetMvcName()] = view;
        }
        //注册model
        public static void RegisterModel(IMvcModel model)
        {
            Models[model.GetMvcName()] = model;
        }
        //注册controller 将一个事件执行器放入字典，以eventName为键,Type类型是类,就是放入一个需要被实例化的类,使用的时候必须要实例化再使用
        public static void RegisterController(string eventName,IMvcController controller)
        {
            ComandMap[eventName] = controller;
        }
    
        //获取model,T是外部传进来的模型脚本,该脚本必须继承自Model
        public static IMvcModel GetModel()
        {
            foreach(var m in Models.Values)
            {
                return m;
            }
            return null;
        }
    
        //获取view
        public static IMvcView GetView()
        {
            foreach (var v in Views.Values)
            {
                return v;
            }
            return null;
        }
    
        //发送事件(对于外部调用者来说该方法是发送事件，对于内部方法来说是不同的控制器和视图处理事件),命名上不要求和我一致，只要见名知意即可.
        public static void SendEvent(string eventName,object data)
        {
            //在这里可发现一个事件对应一个Controller处理,具体事件继承于抽象事件，一个具体事件的诞生首先要进行继承于Controller 重写Execute 注册入CommandMap字典三步骤
            //controller 执行,eventName是事件名称,若在控制器字典内存在该事件名称，则肯定会有一个控制器去处理该事件
            if(ComandMap.ContainsKey(eventName))
            {
                //t脚本类是继承于Controller类的,不然下面无法转换为Controller
                IMvcController t = ComandMap[eventName];
                //执行被t所重写的Execute方法,data是传入的数据(object类型)
                t.Execute(data);
            }
            //view处理
            //遍历所有视图,注意:一个视图允许有多个事件，而且一个事件可能会在不同的视图触发，而事件的内容不确定（事件可理解为触发消息）
            foreach(var v in Views.Values)
            {
                //视图v的关心事件列表中存在该事件
                if(v.Contain(eventName))
                {
                    //让视图v执行该事件eventName,附带参数data
                    //HandleEvent方法是通过switch case的形式处理不同的事件
                    v.HandelEvent(eventName, data);
                }
            }
        }
    }
}