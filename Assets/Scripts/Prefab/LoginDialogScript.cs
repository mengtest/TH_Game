using System;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

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
            LuaEnv env = new LuaEnv();
            var table = env.NewTable();
            var meta = env.NewTable();
            meta.Set("__index", env.Global);
            table.SetMetaTable(meta);
            table.Set("nameInput", _name);
            table.Set("pwdInput", _pwd);
            meta.Dispose();
            table.Set("self", this);
            env.DoString(
                Resources.Load<TextAsset>("LuaScript/UIS/LoginDialog.lua").text,
                "LuaScript/LoginDialog.lua",
                table);
            
            UnityAction confirmBtnCallback = null;
            UnityAction cancelBtnCallback = null;
            
            table.Get("ConfirmButton", out confirmBtnCallback);
            table.Get("CancelButton", out cancelBtnCallback);
            
            _confirm.onClick.AddListener(confirmBtnCallback);
            _cancel.onClick.AddListener(cancelBtnCallback);
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