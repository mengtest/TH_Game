﻿using DG.Tweening;
using LuaFramework;
using UnityEngine;
using UnityEngine.Events;
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
            _pwd.contentType = InputField.ContentType.Password;
            
            var kv = new Global.Injection[]
            {
                new Global.Injection() {Name = "nameInput", Value = _name},
                new Global.Injection() {Name = "pwdInput", Value = _pwd},
            };
            
            var table = LuaEngine.Instance.LoadFile("LuaScript/UIS/LoginDialog.lua", "LoginDialog", this, kv);

            table.Get("ConfirmButton", out UnityAction confirmBtnCallback);
            table.Get("CancelButton", out UnityAction cancelBtnCallback);

            
//            this.transform.DOScale()
//            this.do
//            var que = DOTween.Sequence();
//            que.Append(DOTween.)
//            GetComponent<Text>().transform.DOScale()
//            cancelBtnCallback += () =>
//            {
//                var go = GameObject.Instantiate(Resources.Load<GameObject>("Prefab/Continue"));
//                go.transform.localPosition = Vector3.zero;
//            };
            
            _confirm.onClick.AddListener(confirmBtnCallback);
            _cancel.onClick.AddListener(cancelBtnCallback);

//            this.GetComponent<RectTransform>().rect.Set(0, 0, 500, 200);

//            this.gameObject.AddComponent<Text>().font = new Font("Arial");


//            transform.DOMove(new Vector3(200, 200, 200), 5);

//            Global.GetCurCanvas(this).GetComponent<CanvasGroup>().DOFade()
        }

//        public void RegCallback(Action<bool> callback)
//        {
//            
//        }

//        private void ConfirmBtnCallback()
//        {
//            string username = _name.text;
//            string userpwd = _pwd.text;
//
//            //发送请求到服务器，验证用户名密码等是否正确
//
//            //如果正确，连接到数据大厅并进入开始界面
//
//            //如果不正确，提示相关的错误信息
//        }
//        
//        private void CancelBtnCallback()
//        {
//            //弹出对话框，询问是否退出游戏
//        }
    }
}