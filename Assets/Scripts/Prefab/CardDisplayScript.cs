using System;
using Lib;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Prefab
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public class CardDisplayScript : LuaView, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        public int cid;

        public object data;
        
        //这个是该类
        public static readonly string ClickEvent = "user_click_display_card";
        
        [Tooltip("卡牌里面的角色")]
        [SerializeField]
        public Image card;

        [Tooltip("卡牌的外框")]
        [SerializeField]
        public Image border;

        [Tooltip("等级")]
        [SerializeField]
        public Text level;
        
        [Tooltip("星级")]
        [SerializeField]
        public Transform stars;

        [Tooltip("空的星星")]
        [SerializeField]
        public Image starEmpty;
        
        [Tooltip("填充的星星")]
        [SerializeField]
        public Image star;
        
        public Action<object> clickEvent;

        public void OnPointerClick(PointerEventData eventData)
        {
            Listener.Instance.Event(ClickEvent, this);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            // var seq = DG.Tweening.DOTween.Sequence();
            // var r = this.transform.DORotate(new Vector3(), 1);
            // seq.Append(r);
            // seq.onComplete += () => { };
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}