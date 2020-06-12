using UnityEngine;
using UnityEngine.EventSystems;

namespace Prefab
{
    public class CombatSceneCardCanvasScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private bool _isHover = false;

        public void OnPointerEnter(PointerEventData eventData)
        {
            _isHover = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _isHover = false;
        }

        private void Awake() {
            
        }
    }
}