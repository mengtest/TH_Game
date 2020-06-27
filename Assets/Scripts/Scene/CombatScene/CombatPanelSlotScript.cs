using System;
using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Scene.CombatScene
{
    //需要检测是否有
    public class CombatPanelSlotScript : MonoBehaviour/*, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler*/
    {
        [Tooltip("占有当前槽位的卡牌")]
        public CombatSceneCombatCardScript card;

        // private static CombatSceneCombatCardScript curCard;
        //
        // public static CombatSceneCombatCardScript GetCurCard()
        // {
        //     return curCard;
        // }

        /// <summary>
        /// 获取当前槽位的下标
        /// </summary>
        /// <returns></returns>
        public int GetCurSlotIndex()
        {
            return CombatScenePanelScript.GetIndex(this);
        }

        /// <summary>
        /// 删除当前槽位中的卡牌
        /// </summary>
        /// <returns></returns>
        public CombatSceneCombatCardScript Remove()
        {
            var c = card;
            c.transform.SetParent(null);
            card = null;
            return c;
        }

        /// <summary>
        /// 向当前槽位中添加卡牌
        /// </summary>
        /// <param name="newCard"></param>
        /// <returns></returns>
        public bool AddCard(CombatSceneCombatCardScript newCard)
        {
            if (card == null)
            {
                card = newCard;
                newCard.transform.SetParent(transform);
                newCard.transform.localPosition = Vector3.zero;
                newCard.transform.SetAsFirstSibling();
            }
            //如果当前槽位已经有卡牌了，直接返回false
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 当前槽位中是否有卡牌
        /// </summary>
        /// <returns></returns>
        public bool HasCard()
        {
            return card != null;
        }

        private void OnMouseEnter()
        {
            //设置当前选择的卡槽对象
            Debug.Log("Enter" + this.name);
            
            UserInputScript.GetCurUserInput().SetCurSlot(this);
        }

        private void OnMouseExit()
        { 
            //取消当前选择的卡槽对象
            Debug.Log( "Exit" + this.name);
            UserInputScript.GetCurUserInput().SetCurSlot(this);
        }

        private void OnMouseUp()
        {
            Global.Log($"当前选择的卡槽的下标是{UserInputScript.GetCurUserInput().GetCurSlotIndex()}");
        }

        // public void OnPointerClick(PointerEventData eventData)
        // {
        //     // throw new NotImplementedException();
        // }
        //
        // public void OnPointerDown(PointerEventData eventData)
        // {
        //     // throw new NotImplementedException();
        // }
        //
        // public void OnPointerUp(PointerEventData eventData)
        // {
        //     // throw new NotImplementedException();
        //     Global.Log($"当前选择的卡槽的下标是{UserInputScript.GetCurUserInput().GetCurSlotIndex()}");
        // }
        //
        // public void OnPointerEnter(PointerEventData eventData)
        // {
        //     // throw new NotImplementedException();
        //     UserInputScript.GetCurUserInput().SetCurSlot(this);
        // }
        //
        // public void OnPointerExit(PointerEventData eventData)
        // {
        //     // throw new NotImplementedException();
        //     UserInputScript.GetCurUserInput().ResetCurSlot();
        // }
    }
}