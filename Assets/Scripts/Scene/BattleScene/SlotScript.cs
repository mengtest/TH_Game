﻿using UnityEngine;

namespace BattleScene
{
    //战斗板中个每个槽位
    public class SlotScript : MonoBehaviour
    {
        [Tooltip("当前卡槽是否被禁用")]
        [SerializeField]
        private bool _disable = false;

//        private CardView _card = null;

        public bool IsDisable()
        {
            return _disable;
        }

//        public bool IsOccurred()
//        {
//            return _card != null;
//        }
//
//        public bool GetCard()
//        {
//            return _card;
//        }
//
//        public bool AddCard(CardView view)
//        {
//            //如果当前的槽位不为空的话，则无法添加卡片
//            if (_card != null && !_disable)
//            {
//                view.transform.SetParent(this.transform);
//                _card = view;
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//
//        public CardView RemoveCard()
//        {
//            if (!_disable && _card != null)
//            {
//                var temp = _card;
//                _card = null;
//                return temp;
//            }
//            else
//            {
//                return null;
//            }
//        }
    }
}