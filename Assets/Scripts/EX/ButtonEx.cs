using Callbacks;
using LuaEngine;
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
//    [CustomEditor(typeof(ButtonEx),true)]
    public class ButtonEx : Button, ILuaSupporter
    {
        [Tooltip("点击这个按钮之后调用的函数名,函数需要在Functions中注册")] 
        [SerializeField]
        private string _clickFunction = "";
        
        [Tooltip("是否自动注册当前组件对应名称的回调函数,如果clickFunction字段为空,那么会根据当前对象的名称去加载回调函数,会自动添加Callback")]
        [SerializeField]
        private bool _autoRegisterCallback = true;

        [Tooltip("当前回调事件的类型")]
        [SerializeField]
        private ComponentType _type = ComponentType.Button;
        
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
            RegisterCallback();

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

        private void RegisterCallback()
        {
            if (_autoRegisterCallback)
            {
                //且这个字符串为空的话，那么会直接取得当前节点的name
                if (string.IsNullOrEmpty(_clickFunction))
                {
                    _clickFunction = gameObject.name + "Callback";
                }

                this.Register();
                
                onClick.AddListener(() =>
                {
//                    Functions.GetFunction(funName)?.Invoke();
                });
            }
        }

        public ComponentType GetEnumType()
        {
            return _type;
        }

        public void SetType(ComponentType type)
        {
            _type = type;
        }

        public string GetWord()
        {
            return _clickFunction;
        }

        public void SetWord(string word)
        {
            _clickFunction = word;
        }
    }
}
