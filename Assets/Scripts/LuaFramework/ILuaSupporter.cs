using System;
using UnityEngine;
using UnityEngine.Serialization;

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
//        [FormerlySerializedAs("_clickFunction")]
        [FormerlySerializedAs("_functionName")]
        [Tooltip("点击这个按钮之后调用的函数名,函数需要在Functions中注册")] 
        [SerializeField]
        protected string functionName = "";
        
//        [FormerlySerializedAs("_autoRegisterCallback")]
        [FormerlySerializedAs("_autoRegister")]
        [Tooltip("是否自动注册当前组件对应名称的回调函数,如果clickFunction字段为空,那么会根据当前对象的名称去加载回调函数,会自动添加Callback")]
        [SerializeField]
        protected bool autoRegister = true;

        protected string _callname = "";

        public bool AutoRegister()
        {
            return autoRegister;
        }

        public void AutoRegister(bool register)
        {
            autoRegister = register;
        }

        public string GetWord()
        {
            return functionName;
        }

        public void SetWord(string word)
        {
            functionName = word;
        }

        public string GetFuncName()
        {
            return _callname;
        }

        public void RegisterCallback(MonoBehaviour self)
        {
            if (AutoRegister())
            {
                if (string.IsNullOrEmpty(GetWord()))
                {
                    _callname = self.name + "Callback";
                }
                else
                {
                    _callname = functionName + "Callback";
                }
                this.Register();
            }
        }
    }
}