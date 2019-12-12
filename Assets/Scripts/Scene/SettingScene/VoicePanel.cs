using UnityEngine;
using UnityEngine.UI;
using XLua;

//namespace UnityEngine.Events
//{
//    [CSharpCallLua]
//    public delegate void UnityAction<float>(T0 arg0);
//}


namespace Scene.SettingScene
{
    [CSharpCallLua]
    public delegate void UnityAction1(float f);
    [CSharpCallLua]
    public delegate void UnityAction2(bool b);
    
    [LuaCallCSharp]
    [CSharpCallLua]
    public class VoicePanel : MonoBehaviour
    {
        public Text voice;
        public Slider slider;
        public Toggle checker;

        private void Awake()
        {
//            slider.onValueChanged.AddListener();
//            checker.onValueChanged.AddListener();
//            UnityAction<int>;
        }
    }
}