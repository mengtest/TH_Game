using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Util;
using KeyCode = Lib.KeyCode;

namespace Tool
{
    /// <summary>
    /// 添加这个脚本之后将会实现使用tab切换焦点组件的功能
    /// </summary>
    public class TabSwitcher: MonoBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        [Tooltip("要切换的组件列表")]
        public GameObject[] components;

        private int _curIdx;


        private void Start()
        {
            Listener.Instance.On("", KeyCode.Tab, null, () =>
            {
                var e = EventSystem.current;
                var flag = false;
                if (e.currentSelectedGameObject != null && e.currentSelectedGameObject.GetHashCode() == gameObject.GetHashCode())
                {
                    _curIdx = -1;
                }
                else
                {
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
                        _curIdx = -2;
                    }
                }

                if (_curIdx == -2)
                {
                    return;
                }

                _curIdx++;
                if (_curIdx >= components.Length)
                {
                    _curIdx = 0;
                }

                e.SetSelectedGameObject(components[_curIdx]);
            });
        }
    }
}