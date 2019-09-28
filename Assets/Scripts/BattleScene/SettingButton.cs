using Global;
using UnityEngine;

namespace BattleScene
{
    public class SettingButton : MonoBehaviour
    {
//        public void NavigateToSettingScene()
//        {
//            Navigator.NavigateTo("SettingScene");
//        }
        
        private void OnMouseUpAsButton()
        {
            Debug.Log("打开设置面板");
        }
    }
}