using DG.Tweening;
using UnityEngine;
using static Global;

namespace Util
{
    //现在无法对后续通过代码添加的组件做本地化
    [AddComponentMenu("yuki/Localization")]
    public class Localization : MonoBehaviour
    {
        void Start()
        {
            Translator.Translate(this);
//            GetComponent<CanvasGroup>().DOFade(0, 2)
//            transform.DOMove(new Vector3(200, 200, 200), 5);
        }
    }
}