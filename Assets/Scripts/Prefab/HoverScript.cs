using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Prefab
{
    /**
     * 当鼠标悬浮在当前组件上时，显示一个组件，譬如可以显示一个对该组件的描述性文本
     */
    public class HoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [FormerlySerializedAs("honver")]
        [Tooltip("鼠标悬浮的时候展示的物体")]
        public GameObject hover;

        private static GameObject _display;
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            if (hover != null)
            {
                _display = Instantiate(hover, Global.GetCurCanvas().transform);
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