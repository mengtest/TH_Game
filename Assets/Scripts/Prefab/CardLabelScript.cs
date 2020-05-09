using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Prefab
{
    /// <summary>
    /// 选择卡组的时候，左侧的简要信息展示
    /// </summary>
    public class CardLabelScript: MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        /// <summary>
        /// 当前所显示的icon
        /// </summary>
        public Image icon;

        /// <summary>
        /// 当前所显示的名称
        /// </summary>
        public Text label;

        /// <summary>
        /// 当前显示的数量
        /// </summary>
        public Text count;

        private int _number;

        private string _cardName;

        private string _rareType;
        
        /// <summary>
        /// 卡牌的数量
        /// </summary>
        public int Number {
            set
            {
                if (count != null)
                {
                    _number = value;
                    count.text = $"x{_number}";
                }
            }
            get => _number;
        }

        /// <summary>
        /// 
        /// </summary>
        public string CardName
        {
            set
            {
                if (label != null)
                {
                    _cardName = value;
                    label.text =  $"【{_rareType}】{_cardName}";
                }
            }
            get => _cardName;
        }

        /// <summary>
        /// 
        /// </summary>
        public string RareType
        {
            set
            {
                if (label != null)
                {
                    _rareType = value;
                    label.text =  $"【{_rareType}】{_cardName}";
                }
            }
            get => _rareType;
        }

        /// <summary>
        /// 点击当前物体的事件
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerClick(PointerEventData eventData)
        {
            Lib.Listener.Instance.Event("user_click_card_list_item", this);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}