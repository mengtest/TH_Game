using UnityEngine;
using UnityEngine.EventSystems;

public class SpaceLayerScript : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Global.Log("111111111111111");
        Lib.Listener.Instance.Event("space_layer_clicked");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Global.Log("222222222222222");
        Lib.Listener.Instance.Event("space_layer_click_down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // CppCore.testFunc();
        Global.Log("333333333333333");
        Lib.Listener.Instance.Event("space_layer_click_up");
    }
}