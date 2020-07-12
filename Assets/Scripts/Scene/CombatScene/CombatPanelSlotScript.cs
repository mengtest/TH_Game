using System;
using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Scene.CombatScene
{
    //需要拥有通过view获取到其中所包含的数据相关的api
    //可能需要可以获取
    [LuaCallCSharp]
    public class CombatPanelSlotScript : MonoBehaviour
    {
        [Tooltip("占有当前槽位的卡牌")]
        public CombatSceneCombatCardScript card;

        private bool _mouseDown;

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
            if (card == null) return null;
            var c = card;
            c.transform.SetParent(null);
            card = null;
            return c;
        }

        /// <summary>
        /// 向当前槽位中添加卡牌，只有当前玩家手中的卡牌才可以通过拖动事件放置在场地上
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

        public int GetPlayer()
        {
            return transform.parent.GetComponent<CombatScenePanelScript>().PlayerId;
        }

        private void OnMouseEnter()
        {
            //设置当前选择的卡槽对象
            UserInputScript.GetCurUserInput().SetCurSlot(this);
            
            Lib.Listener.Instance.Event("Mouse_In_Slot", this);
        }

        private void OnMouseExit()
        { 
            //取消当前选择的卡槽对象
            UserInputScript.GetCurUserInput().ResetCurSlot();
            
            Lib.Listener.Instance.Event("Mouse_Leave_Slot", this);
        }

        private void OnMouseUp()
        {
            //鼠标弹起的时候检测当前的槽位中是否存在卡牌，如果存在则不作任何响应
            //或者给出提示，当前卡槽已被占用的提示
            //如果当前的卡槽没有被占用，则将当前的卡牌放置在对应的位置上

            Lib.Listener.Instance.Event("Release_Slot", this);
            
//            var input = UserInputScript.GetCurUserInput();
//            var panel = input.GetPanel(input.GetCurSlotPlayerId());
//            if (panel != null)
//            {
//                var slot = panel.GetSlot(input.GetCurSlotIndex());
//                if (slot != null)
//                {
//                    if (slot.HasCard())
//                    {
//                        Global.MakeToast("当前卡槽已被占用!", Global.TOAST_LONG);
//                    }
//                    //要求当前槽位上有卡牌存在
//                    else if(this.HasCard())
//                    {
//                        slot.AddCard(this.Remove());
//                    }
//                    else
//                    {
//                        
//                    }
//                }
//                else
//                {
//                    throw new Exception("程序遇到了某些问题，尝试重启也许能解决这些问题");
//                }
//            }
        }
    }
}