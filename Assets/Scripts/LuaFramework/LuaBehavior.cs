using System;
using UnityEngine;
using XLua;

namespace LuaFramework
{
    /// <summary>
    /// 这个脚本的作用是加载指定的脚本
    /// </summary>
    public class LuaBehavior : MonoBehaviour, IDisposable
    {
        public TextAsset script;
        private LuaTable _table;
        // private LuaFunction _onAwake;
        private LuaFunction _onStart;
        private LuaFunction _onEnable;
        private LuaFunction _onDestroy;
        private LuaFunction _onUpdate;
        private LuaFunction _onFixUpdate;
        private LuaFunction _onDisable;

        private void Awake()
        {
            var table = LuaEngine.Instance.LoadString(
                script.text, name);
            var onAwake = table.Get<LuaFunction>("awake");
            _onStart = table.Get<LuaFunction>("start");
            _onEnable = table.Get<LuaFunction>("enable");
            _onDestroy = table.Get<LuaFunction>("destroy");
            _onUpdate = table.Get<LuaFunction>("update");
            _onFixUpdate = table.Get<LuaFunction>("fixedUpdate");
            _onDisable = table.Get<LuaFunction>("disable");
            table.Set("self", this);
            
            onAwake?.Call();
            onAwake?.Dispose();
        }

        private void Start()
        {
            _onStart?.Call();
        }

        private void Update()
        {
            _onUpdate?.Call();
        }

        private void OnEnable()
        {
            _onEnable?.Call();
        }

        private void OnDestroy()
        {
            _onDestroy?.Call();
        }

        private void OnDisable()
        {
            _onDisable?.Call();
        }

        private void FixedUpdate()
        {
            _onFixUpdate?.Call();
        }

        private void Free(ref LuaFunction fun)
        {
            if (fun != null)
            {
                fun.Dispose();
                fun = null;
            }   
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (_table != null)
            {
                LuaEngine.Instance.Release(name);
                _table = null;
            }
            
            Free(ref _onStart);
            Free(ref _onEnable);
            Free(ref _onDestroy);
            Free(ref _onUpdate);
            Free(ref _onFixUpdate);
            Free(ref _onDisable);
        }
    }
}