using Global;
using UnityEngine;

namespace StartScene
{
    public class SettingButton : MonoBehaviour
    {
        public void NavigateToSettingScene()
        {
            Navigator.NavigateTo("SettingScene");
        }
    }
}
