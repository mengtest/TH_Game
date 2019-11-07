using System;
using Callbacks;
using UnityEngine;

namespace LuaFramework
{
    //这里的泛型主要是用于获取lua绑定时能够做出类型转换
    public interface ILuaSupporter
    {
        string GetWord();

        void SetWord(string word);

        string GetFuncName();
    }
    
    //好像是因为这里有泛型，所以导致了无法在editor中显示
    [Serializable]
    public class LuaSupporter : ILuaSupporter
    {
        //在editor中输入的函数名
        [Tooltip("点击这个按钮之后调用的函数名,函数需要在Functions中注册")] 
        [SerializeField]
        protected string _clickFunction = "";
        
        [Tooltip("是否自动注册当前组件对应名称的回调函数,如果clickFunction字段为空,那么会根据当前对象的名称去加载回调函数,会自动添加Callback")]
        [SerializeField]
        protected bool _autoRegisterCallback = true;

        //真正去调用的函数名
        protected string _funcName;

        public bool AutoRegister()
        {
            return _autoRegisterCallback;
        }

        public void AutoRegister(bool register)
        {
            _autoRegisterCallback = register;
        }

        public string GetWord()
        {
            return _clickFunction;
        }

        public void SetWord(string word)
        {
            _clickFunction = word;
        }

        public string GetFuncName()
        {
            return _funcName;
        }

        public void RegisterCallback()
        {
            if (AutoRegister())
            {
                //这个地方可以使用dynamic实现，个人觉得这种实现不是很好
                dynamic obj = this;
                //且这个字符串为空的话，那么会直接取得当前节点的name
                if (string.IsNullOrEmpty(GetWord()))
                {
                    try
                    {
                        _funcName = obj.name + "Callback";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                this.Register();
            }
        }
    }
}