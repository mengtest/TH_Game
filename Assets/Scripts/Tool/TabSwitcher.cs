using System;
using UnityEngine;
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


        private void Start()
        {
//            Listener.Instance.On("tab", KeyCode.Tab, null, () =>
//            {
//                
//            });
        }
    }
}