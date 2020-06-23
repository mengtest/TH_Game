using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    /// <summary>
    /// 
    /// </summary>
    public class ToastScript: MonoBehaviour
    {
        [Tooltip("toast对应的文本")]
        public Text content;
        
        public RectTransform imageRect;

        [Tooltip("最大同时显示的toast数量")]
        public int maxNumber = 5;

        [Tooltip("最大宽度")]
        public int maxWidth = 500;

        [Tooltip("最大高度")]
        public int maxHeight = 300;

        //同时最多显示5个Toast
        //当前想要显示但是由于正在显示的toast已经满了而无法显示的toast队列
        private static Queue<Action> _toasts;

        // private static bool _canShow = true;

        private static Timer timer;

        //两个toast的显示间隔为0.3秒
        // private static long _lastTime = DateTime.Now.ToFileTime();

        public enum ToastType
        {
            Warning,                    //橘黄
            Error,                      //红色
            Info,                       //橙黄
            Debug,                      //蓝色
            Text,                       //白色
        }

        private string[] colors = {
            "",
            "",
            "",
            "",
            "#ffffff"
        };

        public void Make(string text, ToastType type, float sec)
        {
            content.text = $"<color='{colors[(int)type]}'>{text}</color>";
            Redraw();
            gameObject.SetActive(false);
            //将显示对应的toast的函数存起来，再等待调用
            _toasts.Enqueue(()=>{
                Show(sec);
            });
            //如果timer为空，则创建
            if(timer == null)
            {
                //如果
                timer = Timer.Register(0.5f, () => {
                    // Global.Log("123123123123");
                    if (_toasts.Count != 0)
                    {
                        _toasts.Dequeue().Invoke();
                    }
                    else
                    {
                        timer.Pause();
                    }
                }, null, true);
            }
            else if(timer.isPaused)
            {
                timer.Resume();
            }
        }

        private void Show(float sec)
        {
            gameObject.SetActive(true);
            // _canShow = false;
            var seq = DOTween.Sequence();
            var move = transform.DOLocalMove(new Vector3(0, transform.localPosition.y + 300, 0), sec).SetEase(Ease.Linear);
            seq.Append(move);
            seq.OnComplete(() =>
            {
                //如果队列中的action数量为0，则暂停这个timer
                if (_toasts.Count == 0)
                {
                    timer.Pause();
                }
                Destroy(gameObject);
            });
        }

        public void Make(string text, float sec)
        {
            Make(text, ToastType.Info, sec);
        }

        private void Awake()
        {
            if (imageRect == null)
            {
                imageRect = GetComponent<RectTransform>();
                content.alignment = TextAnchor.MiddleCenter;
            }

            if(_toasts == null)
            {
                _toasts = new Queue<Action>();
            }
            
            Redraw();
        }

        public void Redraw()
        {
            if (imageRect == null)
            {
                imageRect = GetComponent<RectTransform>();
            }
            
            Global.GetChineseEnglishNumber(content.text, out var c, out var e);
            
            var size = content.fontSize;
            var width = size * (c + e / 2 + 1);

            if (width > maxWidth)
            {
                width = maxWidth;
            }

            var textRect = content.GetComponent<RectTransform>();
            textRect.sizeDelta = new Vector2(width, maxHeight);
            var preferredHeight = content.preferredHeight;
            var height = preferredHeight > maxHeight ? maxHeight : preferredHeight;

            imageRect.sizeDelta = new Vector2(width + 30 * 2, height + 10 * 2);

            textRect.sizeDelta = new Vector2(width, height);
        }
    }
}