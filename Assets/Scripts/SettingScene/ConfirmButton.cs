using Global;
using UnityEngine;

namespace SettingScene
{
    public class ConfirmButton : MonoBehaviour
    {
    
        public void ConfirmEvent()
        {
            //存储配置文件，并应用
        

            //返回到开始画面
            Navigator.NavigateTo(0);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
//    void Update()
//    {
//        
//    }
    }
}
