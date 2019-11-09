﻿using System.Collections.Generic;
using UnityEngine;

namespace BattleScene
{
    public class BattleBoard : MonoBehaviour
    {
//        [SerializeField]
//        private int _maxCards = 6;

        private int _cardCount;

        private List<SlotScript> _slots;
        
        //该棋盘时候还有剩余的位置
        public bool HasRest()
        {
//            return Count() == 0;
            return false;
        }
        
        //当前棋盘剩余的空位数
//        public int Count()
//        {
//            int rest = 0;
//            foreach (var slot in _slots)
//            {
//                if (!slot.IsOccurred() && !slot.IsDisable())
//                {
//                    rest++;
//                }
//            }
//            return rest;
//        }
//
//        //获取到一个空的槽
//        public SlotScript GetOneSpaceSlot()
//        {
//            foreach (var slot in _slots)
//            {
//                if (!slot.IsDisable() && !slot.IsOccurred())
//                {
//                    return slot;
//                }
//            }
//            return null;
//        }
//
//        public void AddCard(CardView card)
//        {
//            //将card添加为当前panel的子节点
//            //这里就包含了判断是否有多余的槽位的过程
//            var slot = GetOneSpaceSlot();
//            if (slot != null)
//            {
//                slot.AddCard(card);
//                //保持相同的旋转
//                card.transform.rotation = new Quaternion(0, 0, 0, 0);
//                _cardCount++;
//            }
//            else
//            {
//                //提示一段错误信息
//            }
//        }
//        
//        public void RemoveCard(CardView card)
//        {
//            foreach (var slot in _slots)
//            {
//                if (slot.GetCard().GetHashCode() == card.GetHashCode())
//                {
//                    slot.RemoveCard();
//                    break;
//                }
//            }
//        }
//
//        private void Start()
//        {
//            _slots = new List<SlotScript>();
//
//            foreach (var slot in GetComponentsInChildren<SlotScript>())
//            {
//                _slots.Add(slot);
//            }
//
//            foreach (var view in GetComponentsInChildren<CardView>())
//            {
//                view.transform.rotation = new Quaternion(0, 0, 0, 0);
//            }
//        }


    }
}