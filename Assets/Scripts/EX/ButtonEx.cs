using Manager;
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
    public class ButtonEx : Button
    {
//    public delegate void PointerEventCallback(PointerEventData eventData);
//
//    public event PointerEventCallback onPointerEnter;
//    public event PointerEventCallback onPointerExit;
//
//    //记录下当前的按钮的xy轴上的缩放
//    private float _scaleX;
//    private float _scaleY;
    
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
        
//        _scaleX = GetComponent<RectTransform>().localScale.x;
//        _scaleY = GetComponent<RectTransform>().localScale.y;
//        onPointerEnter = eventData =>
//        {
//            if (!interactable)
//            {
//                return;
//            }
//            
//            transform.localScale = new Vector3(_scaleX * 1.1f, _scaleY * 1.1f);
//            Sound.PlayEffect("Music/BtnClick");
//        };
//
//        onPointerExit = eventData =>
//        {
//            var rect = GetComponent<RectTransform>();
//            rect.localScale = new Vector3(_scaleX, _scaleY);
//        };
        
            onClick.AddListener(delegate
            {
                Sound.PlayEffect("Music/BtnClick");
            });
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            if (!interactable)
            {
                return;
            }

            //做缩放会出现bug，所以暂时注释掉
//        transform.localScale = new Vector3(_scaleX * 1.1f, _scaleY * 1.1f);
            Sound.PlayEffect("Music/BtnClick");

            base.OnPointerEnter(eventData);
        }

//    public override void OnPointerExit(PointerEventData eventData)
//    {
//        
//        base.OnPointerExit(eventData);
//    }
    }
}
