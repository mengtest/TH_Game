using System;
using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class LoginDialogScript : MonoBehaviour
    {
        [SerializeField]
        private Button _confirm;
        
        [SerializeField]
        private Button _cancel;
        
        [SerializeField]
        private InputField _name;
        
        [SerializeField]
        private InputField _pwd;
        
        private void Start()
        {
            _confirm.onClick.AddListener(ConfirmBtnCallback);
            
            _cancel.onClick.AddListener(CancelBtnCallback);
        }

        private void ConfirmBtnCallback()
        {
            string username = _name.text;
            string userpwd = _pwd.text;

            //发送请求到服务器，验证用户名密码等是否正确

            //如果正确，连接到数据大厅并进入开始界面

            //如果不正确，提示相关的错误信息
        }
        
        private void CancelBtnCallback()
        {
            //弹出对话框，询问是否退出游戏
        }
    }
}