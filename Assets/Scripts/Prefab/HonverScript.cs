using UnityEngine;
using UnityEngine.EventSystems;

namespace Prefab
{
    /**
     * 当鼠标悬浮在当前组件上时，显示该组件的一段描述
     */
    public class HonverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Tooltip("鼠标悬浮的时候展示的物体")]
        public GameObject honver;

        private GameObject _display;
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            if (honver != null)
            {
                _display = Instantiate(honver, Global.GetCurCanvas().transform);
                if (_display.GetComponent<RectTransform>())
                {
                    
                }
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {

        }
    }
}