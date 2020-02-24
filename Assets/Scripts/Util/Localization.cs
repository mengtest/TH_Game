using UnityEngine;
using static Global;

namespace Util
{
    /**
     * 本地化组件
     * 目前还没有解决的问题有
     * 现在无法对后续通过代码添加的组件做本地化
     * 现在还只是单纯的
     */
    [AddComponentMenu("yuki/Localization")]
    public class Localization : MonoBehaviour
    {
        void Awake()
        {
            Translator.Translate(this);
        }
    }
}