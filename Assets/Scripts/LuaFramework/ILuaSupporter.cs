using System;
using Callbacks;
using UnityEngine;

namespace LuaFramework
{
    public enum ComponentType
    {
        Button,
    }

    public interface ILuaSupporter<T> where T : MonoBehaviour
    {
        ComponentType GetEnumType();

        void SetType(ComponentType type);

        string GetWord();

        void SetWord(string word);

        string GetFuncName();
    }
    
    
    [Serializable]
    public class LuaSupporter<T> : ILuaSupporter<T> where T : MonoBehaviour
    {
        [Tooltip("点击这个按钮之后调用的函数名,函数需要在Functions中注册")] 
        [SerializeField]
        protected string _clickFunction = "";
        
        [Tooltip("是否自动注册当前组件对应名称的回调函数,如果clickFunction字段为空,那么会根据当前对象的名称去加载回调函数,会自动添加Callback")]
        [SerializeField]
        protected bool _autoRegisterCallback = true;

        [Tooltip("当前回调事件的类型")]
        [SerializeField]
        protected ComponentType _type = ComponentType.Button;

        protected string _funcName;

        public bool AutoRegister()
        {
            return _autoRegisterCallback;
        }

        public void AutoRegister(bool register)
        {
            _autoRegisterCallback = register;
        }

        public ComponentType GetEnumType()
        {
            return _type;
        }

        public void SetType(ComponentType type)
        {
            _type = type;
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
                var be = this as T;
                if (be == null)
                {
                    throw new Exception("错误的类型转换");
                }
                //且这个字符串为空的话，那么会直接取得当前节点的name
                if (string.IsNullOrEmpty(GetWord()))
                {
                    _funcName = be.name + "Callback";
                }
                
                this.Register();
            }
        }
    }
}