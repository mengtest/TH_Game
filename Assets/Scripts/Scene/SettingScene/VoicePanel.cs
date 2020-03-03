using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Scene.SettingScene
{
    [CSharpCallLua]
    [LuaCallCSharp]
    public delegate void UnityAction1(float f);
    [CSharpCallLua]
    [LuaCallCSharp]
    public delegate void UnityAction2(bool b);
    
    [LuaCallCSharp]
    public class VoicePanel : MonoBehaviour
    {
        public Text voice;
        public Slider slider;
        public Toggle checker;
        private Color _originColor;

        private void Awake()
        {
            _originColor = slider.fillRect.GetComponent<Image>().color;
            checker.onValueChanged.AddListener(CheckerChanged);
            slider.onValueChanged.AddListener(SliderChanged);
        }

        public void AddCheckerChangeEvent(UnityAction<bool> act)
        {
            checker.onValueChanged.AddListener(act);
        }
        
        public void AddSliderChangeEvent(UnityAction<float> act)
        {
            slider.onValueChanged.AddListener(act);
        }

        private void CheckerChanged(bool value)
        {
            slider.fillRect.GetComponent<Image>().color = value ? _originColor : Color.grey;
        }

        private void SliderChanged(float value)
        {
            voice.text = ((int) value).ToString();
        }
    }
}