using Lib;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Prefab
{
    /// <summary>
    /// 简化后的展示卡牌信息的脚本
    /// </summary>
    [LuaCallCSharp]
    public class CardDisplayScript2: LuaView, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        public object data;
        
        /// <summary>
        /// 
        /// </summary>
        [Tooltip("卡牌主要展示的内容，根据不同的卡牌而变化")]
        public Image content;

        /// <summary>
        /// 
        /// </summary>
        [Tooltip("卡牌的边框，根据卡牌的稀有度而变化")]
        public Image boarder;

        /// <summary>
        /// 
        /// </summary>
        [Tooltip("当前卡牌的数量文本")]
        public Text count;
        
        public static readonly string ClickEvent = "user_click_display_card2";

        private void Awake()
        {
            //点击卡牌的时候，在界面的右侧显示当前点击的卡牌的详细信息
            // LuaView.
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Listener.Instance.Event(ClickEvent, this);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}