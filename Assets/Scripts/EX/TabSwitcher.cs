using System;
using Lib;
using UnityEngine;
using UnityEngine.EventSystems;
// using KeyCode = Lib.KeyCode;

namespace Tool
{
    /// <summary>
    /// 添加这个脚本之后将会实现使用tab切换焦点组件的功能
    /// </summary>
    public class TabSwitcher: MonoBehaviour
    {
        [Tooltip("要切换的组件列表")]
        public GameObject[] components;

        private int _curIdx;
        
        private void Start()
        {
            //tabSwitcher组件会侦听键盘中的tab事件，
            //按下tab的时候会在components中不断地切换
            Listener.Instance.On(Listener.KEY_EVENT,  (o) =>
            {
                var e = EventSystem.current;
                var flag = false;
            
                if (e.currentSelectedGameObject == null)
                {
                    return;
                }
                
                for (int i = 0; i < components.Length; i++)
                {
                    if (components[i].GetHashCode() == e.currentSelectedGameObject.GetHashCode())
                    {
                        _curIdx = i;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    _curIdx = -1;
                }
            
                if (_curIdx < 0)
                {
                    return;
                }
            
                _curIdx++;
                if (_curIdx >= components.Length)
                {
                    _curIdx = 0;
                }
            
                e.SetSelectedGameObject(components[_curIdx]);
            }, this.gameObject, Lib.KeyCode.Tab);
        }
    }
}