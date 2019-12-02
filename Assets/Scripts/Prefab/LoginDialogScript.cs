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
        
//        [SerializeField]
//        private InputField _name;
        
        [SerializeField]
        private InputField _pwd;

        [SerializeField]
        private LuaClass _luaClass;
        
        private void Start()
        {
            _pwd.contentType = InputField.ContentType.Password;
            
//            var kv = new[]
//            {
//                new Global.Injection() {Name = "nameInput", Value = _name},
//                new Global.Injection() {Name = "pwdInput", Value = _pwd},
//            };
//            
//            var table = LuaEngine.Instance.LoadFile("LuaScript/UIS/LoginDialog.lua", "LoginDialog", this, kv);
//
//            table.Get("ConfirmButton", out UnityAction confirmBtnCallback);
//            table.Get("CancelButton", out UnityAction cancelBtnCallback);
            
            _luaClass.Ref(this);
            _luaClass.Get("ConfirmButton", out UnityAction confirmBtnCallback)
                .Get("CancelButton", out UnityAction cancelBtnCallback);

            _confirm.onClick.AddListener(confirmBtnCallback);
            _cancel.onClick.AddListener(cancelBtnCallback);
        }
    }
}