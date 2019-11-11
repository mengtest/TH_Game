using static Global;
using Manager;
using UnityEngine;
using UnityEngine.UI;

namespace SettingScene
{
    //按钮的布局脚本
    public class ButtonLayout : MonoBehaviour
    {
        private void CancelButtonCallback()
        {
            Sound.PlayEffect("Music/BtnClick");
        }

        private void ResetButtonCallback()
        {
            Sound.PlayEffect("Music/BtnClick");
        }

        private void ApplyButtonCallback()
        {
            Sound.PlayEffect("Music/BtnClick");
            NavigateTo("StartScene");
        }

        //在start之前，awake之后调用
        private void OnEnable()
        {
            foreach (var button in GetComponentsInChildren<Button>())
            {
                if (button.name == "Reset")
                {
                    button.onClick.AddListener(CancelButtonCallback);
                }
                else if(button.name == "Cancel")
                {
                    button.onClick.AddListener(ResetButtonCallback);
                }
                else if(button.name == "Apply")
                {
                    button.onClick.AddListener(ApplyButtonCallback);
                }
            }
        }
        
    }
}