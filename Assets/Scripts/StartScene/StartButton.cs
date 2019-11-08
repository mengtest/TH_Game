using Global;
using UnityEngine;
using UnityEngine.UI;

namespace StartScene
{
    public class StartButton : MonoBehaviour
    {
        //跳转到正式开始游戏的第一个场景
        //实际使用的时候会用到loading场景，所以使用我们自己封装的跳转
        public void NavigateToMainScene()
        {
            Navigator.NavigateTo("MainScene");
        }
        
        public void AlertLoginDialog()
        {
            
        }
    }
}
