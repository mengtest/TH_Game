using UnityEngine;

namespace Scene.CombatScene
{
    public class CombatScenePanelScript : MonoBehaviour
    {
        [SerializeField]
        private CombatPanelSlotScript[] slots;

        private void Awake()
        {
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
            if (index >= slots.Length || index < 0)
            {
                return null;
            }
            return slots[index];
        }
    }
}