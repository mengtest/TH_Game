using Callbacks;
using Manager;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

namespace EX
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CanvasRenderer))]
    [AddComponentMenu("yuki/UI/ButtonEX")]
//    [CustomEditor(typeof(ButtonEx),true)]
    public class ButtonEx : Button
    {
        [Tooltip("点击这个按钮之后调用的函数名,函数需要在Functions中注册")] 
        [SerializeField]
        private string _clickFunction = null;

        [Tooltip("当前回调事件的类型")]
        [SerializeField]
        private Callbacks.Functions.CallbackType _type = Functions.CallbackType.BUTTON;

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
            color.colorMultiplier = colors.colorMultiplier;
            color.disabledColor = colors.disabledColor;
            color.fadeDuration = colors.fadeDuration;
            color.highlightedColor = new Color(200, 200, 200);
            color.normalColor = colors.normalColor;
            color.pressedColor = new Color(150, 150, 150);
            color.selectedColor = colors.selectedColor;
        }
    
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
        
            onClick.AddListener(delegate
            {
                Sound.PlayEffect("Music/BtnClick");
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
    }
}
