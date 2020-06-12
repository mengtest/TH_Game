using UnityEngine;
using UnityEngine.EventSystems;

///最低的层，如果点击到空白地方就会触发这里的点击事件
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
        Global.Log("333333333333333");
        Lib.Listener.Instance.Event("space_layer_click_up");
    }
}