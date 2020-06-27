using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Scene.CombatScene
{
    public class CombatScenePanelScript : MonoBehaviour
    {
        [SerializeField]
        private List<CombatPanelSlotScript> slots;

        private void Awake()
        {
            //由panel为卡槽分配名称，所以从panel中获取目标卡槽的下标
            var index = 0;
            foreach (Transform child in transform)
            {
                child.name = $"slot{index}";
                slots[index] = child.GetComponent<CombatPanelSlotScript>();
                index++;
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
            var match = Regex.Match(slot.name, "[0-9]");
            if (match.Length != 0)
            {
                return Int32.Parse(match.Value);    
            }
            else
            {
                throw new Exception($"{slot.name}不是合法的卡槽");
            }
        }
    }
}