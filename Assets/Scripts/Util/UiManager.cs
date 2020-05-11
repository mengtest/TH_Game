using System.Collections.Generic;
using System.Linq;
using Prefab;
using UnityEngine;
using UnityEngine.XR.WSA;

namespace Util
{
    /// <summary>
    /// 
    /// </summary>
    public class UiManager
    {
        private static UiManager _instance;
        
        /// <summary>
        /// 
        /// </summary>
        public static void Init()
        {
            if ( _instance == null)
            {
                _instance = new UiManager();
            }
        }

        public static UiManager Instance
        {
            get
            {
                if ( _instance == null)
                {
                    _instance = new UiManager();
                }
                return _instance;
            }
        }
        private Queue<WindowScript> _windows = new Queue<WindowScript>();

        public void ShowWindow(GameObject go)
        {
            var window = go.GetComponent<WindowScript>();
            if (window != null)
            {
                //如果当前没有正在显示窗口，那么就直接显示
                if (_windows.Count == 0)
                {
                    window.PopUp();
                }
                _windows.Enqueue(window);
            }
        }
        
        public void ShowWindow(WindowScript window)
        {
            if (_windows.Count == 0)
            {
                window.PopUp();
            }
            _windows.Enqueue(window);
        }

        public void CloseWindow()
        {
            if (_windows.Count > 0)
            {
                //关闭当前第一个窗口，
                //如果当前的队列当中存在窗口则弹出
                var window = _windows.Dequeue();
                window.Hide();
                if (_windows.Count > 0)
                {
                    window = _windows.ElementAt(1);
                    window.PopUp();
                }
            }
        }
    }
}