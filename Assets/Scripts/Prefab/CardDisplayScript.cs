using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Prefab
{
    public class CardDisplayScript : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        [Tooltip("卡牌里面的角色")]
        [SerializeField]
        private Image card;

        [Tooltip("卡牌的外框")]
        [SerializeField]
        private Image border;

        [Tooltip("等级")]
        [SerializeField]
        private Text level;
        
        [Tooltip("星级")]
        [SerializeField]
        private Transform stars;

        [Tooltip("空的星星")]
        [SerializeField]
        private Image starEmpty;
        
        [Tooltip("填充的星星")]
        [SerializeField]
        private Image star;

        private void Awake()
        {
            
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("你点击了这个卡牌");
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            // throw new NotImplementedException();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            // throw new NotImplementedException();
        }
    }
}