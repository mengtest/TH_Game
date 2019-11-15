using UnityEngine;
using UnityEngine.SceneManagement;
using Resources = UnityEngine.Resources;

//各类按钮的回调函数
namespace Callbacks
{
//    [LuaCallCSharp]
    public class Callbacks : MonoBehaviour
    {
    //开始场景中的开始游戏按钮
    //        public void StartSceneStartGameButtonCallback()
    //        {
    //            NavigateTo(1);
    //        }

    //开始场景中的设置按钮的回调
    //        public void StartSceneSettingButtonCallback()
    //        {
    //            NavigateTo("SettingScene");
    //        }

    //开始场景中的退出按钮的回调
    //        public void StartSceneExitButtonCallback()
    //        {
    //            var dialog = new ModelDialog();
    //            dialog.SetOkText("Ok");
    //            dialog.SetCancelText("Cancel");
    //            dialog.SetText("Dialog_ExitGame");
    //            dialog.OkBtnCallback += ExitDialogOkButtonCallback;
    //            dialog.CancelBtnCallback += ExitDialogCancelButtonCallback;
    //            dialog.ShowDialog();
    //        }

    //设置场景中的确认按钮的回调
    //        public void SettingSceneConfirmButtonCallback()
    //        {
    //            NavigateTo(0);
    //        }

    //设置场景中的取消按钮的回调
    //        public void SettingSceneCancelButtonCallback()
    //        {
    //
    //        }

    //        public void StorySceneReturnButton()
    //        {
    //            Return();
    //        }

    //开始场景中的重置按钮的回调
    //        public void SettingSceneResetButtonCallback()
    //        {
    //
    //        }

    //退出游戏对话框的确认按钮的回调
    //        private static void ExitDialogOkButtonCallback()
    //        {
    //            Application.Quit(0);
    //        }

    //退出游戏对话框的取消按钮的回调
    //        private static void ExitDialogCancelButtonCallback()
    //        {
    //
    //        }

    //        public void SendMsg()
    //        {
    //            NetHelper.Instance.Login("123123123", "2333333");
    //        }

//        public void AlertLoginDialog()
//        {
//            var go = Instantiate(Resources.Load<GameObject>("Prefab/LoginDialog2"));
//            foreach (var child in SceneManager.GetActiveScene().GetRootGameObjects())
//            {
//                if (child.name == "Canvas")
//                {
//                    go.transform.SetParent(child.transform);
//                }
//            }
//        }
    }
}