using System;
using System.ComponentModel;
using Callbacks;
using LuaFramework;
using Manager;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Functions = Callbacks.Functions;
using Image = UnityEngine.UI.Image;

namespace EX
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CanvasRenderer))]
    [AddComponentMenu("yuki/UI/ButtonEX")]
    public class ButtonEx : Button, ILuaSupporter
    {
        [SerializeField]
        private LuaSupporter _supporter;
        
//        public delegate void PointerEventCallback(PointerEventData eventData);
//        public event PointerEventCallback onPointerEnter;
//        public event PointerEventCallback onPointerExit;

        //记录下当前的按钮的xy轴上的缩放
        private float _scaleX;
        private float _scaleY;
    
        [ContextMenu("初始化")]
        public void InitButtonEx()
        {
            var color = new ColorBlock();
            var oriColor = colors;
            color.colorMultiplier = oriColor.colorMultiplier;
            color.disabledColor = oriColor.disabledColor;
            color.fadeDuration = oriColor.fadeDuration;
            color.highlightedColor = new Color(200, 200, 200);
            color.normalColor = oriColor.normalColor;
            color.pressedColor = new Color(150, 150, 150);
            color.selectedColor = oriColor.selectedColor;
            oriColor = color;
            colors = oriColor;
        }

        protected override void Awake()
        {
//            _supporter = new LuaSupporter();
        }

        //attribute相关的内容可以参考这类文章
        //https://blog.csdn.net/niwalker/article/details/8872
        protected override void Start()
        {
            base.Start();

            var localScale = transform.localScale;
            _scaleX = localScale.x;
            _scaleY = localScale.y;
            
//            onPointerEnter = eventData =>
//            {
//                if (!interactable)
//                {
//                    return;
//                }
//                
//                transform.localScale = new Vector3(_scaleX * 1.1f, _scaleY * 1.1f);
//                Sound.PlayEffect("Music/BtnClick");
//            };
//
//            onPointerExit = eventData =>
//            {
//                var rect = GetComponent<RectTransform>();
//                rect.localScale = new Vector3(_scaleX, _scaleY);
//            };

            //如果自动注册为true
            
            var callback = new Action(() =>
            {
                Sound.PlayEffect("Music/BtnClick");
            });
            callback +=  Functions.GetFunction(_supporter.GetWord());
            onClick.AddListener(delegate
            {
                callback.Invoke();
            });
        }

        //鼠标进入到按钮时，按钮放大
        public override void OnPointerEnter(PointerEventData eventData)
        {
            if (!interactable)
            {
                return;
            }

            //不知道之前的是什么bug
            transform.localScale = new Vector3(_scaleX * 1.1f, _scaleY * 1.1f);
            Sound.PlayEffect("Music/BtnClick");

            base.OnPointerEnter(eventData);
        }

        //鼠标移出按钮时，按钮回复原样
        public override void OnPointerExit(PointerEventData eventData)
        {
            transform.localScale = new Vector3(_scaleX , _scaleY);
            base.OnPointerExit(eventData);
        }

        public string GetWord()
        {
            return _supporter.GetWord();
        }

        public void SetWord(string word)
        {
            _supporter.SetWord(word);
        }

        public string GetFuncName()
        {
            return _supporter.GetFuncName();
        }

        public void RegisterCallback()
        {
            _supporter.RegisterCallback();
        }
    }
}
