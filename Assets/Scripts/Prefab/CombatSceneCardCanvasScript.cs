using UnityEngine;
using UnityEngine.EventSystems;

namespace Prefab
{
    public class CombatSceneCardCanvasScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {

        public CombatSceneCombatCardScript pawnScript;
        
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

        public void OnPointerClick(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
            Global.Log(this.pawnScript.name);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }
    }
}