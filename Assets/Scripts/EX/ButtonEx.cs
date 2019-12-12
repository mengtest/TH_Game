using LuaFramework;
using Manager;
using UnityEngine;
using UnityEngine.Events;
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
    public class ButtonEx : Button
    {
        [SerializeField] 
        private LuaSupporter _supporter;

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
        
        //attribute相关的内容可以参考这类文章
        //https://blog.csdn.net/niwalker/article/details/8872
        protected override void Start()
        {
            _supporter.RegisterCallback(this);

            base.Start();
            
            var localScale = transform.localScale;
            _scaleX = localScale.x;
            _scaleY = localScale.y;

            //如果自动注册为true
            
            var callback = new UnityAction(() =>
            {
                Sound.PlayEffect("Music/BtnClick");
                Functions.GetAction(this._supporter)?.Call();
            });
            onClick.AddListener(callback);
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
