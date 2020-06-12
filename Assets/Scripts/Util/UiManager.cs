using System.Collections.Generic;
using System.Linq;
using Prefab;
using UnityEngine;

namespace Util
{
    /// <summary>
    /// 
    /// </summary>
    public class UiManager
    {
        private static UiManager _instance;
        
        /// <summary>
        /// 初始化ui管理器，其实没什么卵用
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

        public void SetCurHoverObject(GameObject obj)
        {
            
        }

        public GameObject GetCurHoverObject()
        {
            return null;
        }

        public void ShowWindow(GameObject go)
        {
            //如果该游戏对象没有窗口组件，则没有任何操作
            var window = go.GetComponent<WindowScript>();
            if (window != null)
            {
                //队列中的第一个窗口就是正在显示的窗口，如果没有窗口则表示当前没有正在显示的窗口
                //如果当前没有正在显示窗口，那么就直接显示
                if (_windows.Count == 0)
                {
                    window.PopUp();
                }
                //无论怎么样都需要将窗口添加到队列中
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

        //隐藏窗口时的调用
        public void CloseWindow(WindowScript win)
        {
            //如果当前的
            if (_windows.Count > 0 && _windows.ElementAt(0) == win)
            {
                //关闭当前第一个窗口，
                //如果当前的队列当中存在窗口则弹出
                var window = _windows.Dequeue();
                window.Hide();
                if (_windows.Count > 0)
                {
                    window = _windows.Dequeue();
                    if(window != null)
                    {
                        window.PopUp();
                    }
                }
            }
            else
            {
                win.Hide();
            }
        }

        //隐藏窗口时的调用
        public void CloseWindow(GameObject go)
        {
            var win = go.GetComponent<WindowScript>();
            //如果当前的
            if (_windows.Count > 0 && _windows.ElementAt(0) == win)
            {
                //关闭当前第一个窗口，
                //如果当前的队列当中存在窗口则弹出
                var window = _windows.Dequeue();
                window.Hide();
                if (_windows.Count > 0)
                {
                    window = _windows.Dequeue();
                    if(window != null)
                    {
                        window.PopUp();
                    }
                }
            }
            else
            {
                win.Hide();
            }
        }
    }
}