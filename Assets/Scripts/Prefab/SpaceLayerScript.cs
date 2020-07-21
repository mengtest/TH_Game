using UnityEngine;
using UnityEngine.EventSystems;

public class SpaceLayerScript : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Lib.Listener.Instance.Event("space_layer_clicked");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Lib.Listener.Instance.Event("space_layer_click_down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // CppCore.testFunc();
        Lib.Listener.Instance.Event("space_layer_click_up");
    }
}