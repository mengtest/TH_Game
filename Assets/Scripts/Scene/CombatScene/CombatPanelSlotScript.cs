using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Scene.CombatScene
{
    //需要检测是否有
    public class CombatPanelSlotScript : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEndDragHandler, IBeginDragHandler
    {
        [Tooltip("占有当前槽位的卡牌")]
        public CombatSceneCombatCardScript card;

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

        public void OnPointerClick(PointerEventData eventData)
        {
            Global.Log("123123123");
            // throw new System.NotImplementedException();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        public void OnDrag(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }
    }
}