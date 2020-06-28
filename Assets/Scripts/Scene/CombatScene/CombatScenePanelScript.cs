using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using XLua;

namespace Scene.CombatScene
{
    [LuaCallCSharp]
    public class CombatScenePanelScript : MonoBehaviour
    {
        [SerializeField]
        private List<CombatPanelSlotScript> slots;

        [Tooltip("当前Panel所属的玩家id，这个字段在跳转到战斗场景的时候就需要初始化" +
                 "0表示没有初始化，或者错误；正数表示正常值，负数表示机器人")]
        [SerializeField]
        private int playerId;

        public int PlayerId => playerId;

        private void Awake()
        {
            //由panel为卡槽分配名称，所以从panel中获取目标卡槽的下标
            var index = 0;
            foreach (Transform child in transform)
            {
                child.name = $"Slot{index}";
                slots[index] = child.GetComponent<CombatPanelSlotScript>();
                index++;
            }
        }

        private void Start()
        {
            //如果playerId未初始化，则抛出异常
            if (playerId == 0)
            {
                throw new Exception($"{name}没有初始化playerId");
            }
        }

        public CombatPanelSlotScript GetSlot(int index)
        {
            if (index >= slots.Count || index < 0)
            {
                return null;
            }
            return slots[index];
        }

        public static int GetIndex(CombatPanelSlotScript slot)
        {
            var match = Regex.Match(slot.name, "[0-9]+");
            if (match.Length != 0)
            {
                return Int32.Parse(match.Value);
            }
            else
            {
                throw new Exception($"{slot.name}不是合法的卡槽");
            }
        }

        public CombatScenePanelScript GetSlot(int uid, int index)
        {
            return null;
        }
    }
}