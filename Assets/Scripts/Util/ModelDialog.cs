using Prefab;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XLua;
using Object = UnityEngine.Object;

namespace Util
{
    [LuaCallCSharp]
    //模态对话框
    public class ModelDialog
    {
        public delegate void ButtonCallback();

        public event ButtonCallback OkBtnCallback;
        public event ButtonCallback CancelBtnCallback;

        //对话框所显示的主要的文本
        private string _mainText;
        //ok按钮显示的文本
        private string _okText;
        //cancel按钮显示的文本
        private string _cancelText;
        //对话框脚本
        private DialogScript _dialog;

        public ModelDialog()
        {
            
        }

        public ModelDialog(string text, string okText = null, string cancelText = null, 
            ButtonCallback okCallback = null,
            ButtonCallback cancelCallback = null)
        {
            _mainText = text;
            if (okText?.Length > 0)
            {
                _okText = okText;
            }
            if (cancelText?.Length > 0)
            {
                _cancelText = cancelText;
            }
            if (okCallback != null)
            {
                OkBtnCallback += okCallback;
            }
            if (cancelCallback != null)
            {
                CancelBtnCallback += cancelCallback;
            }
        }

        public void SetText(string text)
        {
            _mainText = text;
        }

        public void SetOkText(string text)
        {
            _okText = text;
        }

        public void SetCancelText(string text)
        {
            _cancelText = text;
        }

        private void DisableAllCanvas()
        {
            //当创建这个窗口的时候，屏蔽掉之前的所有的UI的事件
            foreach (var child in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                foreach (var go in child.GetComponentsInChildren<GraphicRaycaster>())
                {
                    go.enabled = false;
                }
            }
        }

        private void RecoverAllCanvas()
        {
            //在点击按钮之后将所有的GraphicRaycaster设置为true
            //但是原来的状态并不一定是true
            //如果使用集合全部存入，也有被删除的可能，所以就直接设置成true
            foreach (var child in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                foreach (var go in child.GetComponentsInChildren<GraphicRaycaster>())
                {
                    go.enabled = true;
                }
            }
        }

        public void ShowDialog()
        {
            DisableAllCanvas();

            //创建canvas
            var layer = new GameObject("ModelDialogLayer");
            var canvas = layer.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            layer.AddComponent<CanvasScaler>();
            layer.AddComponent<GraphicRaycaster>();

            //通过这个API向Scene中添加对象
            SceneManager.MoveGameObjectToScene(canvas.gameObject, SceneManager.GetActiveScene());

            //dialog的创建与加载
            var gameObj = Util.Loader.Load("Prefab/Dialog");
            var obj = (GameObject) Object.Instantiate(gameObj);
            obj.GetComponent<RectTransform>().SetParent(canvas.GetComponent<Transform>());
            obj.GetComponent<RectTransform>().localPosition = new Vector3(0, 0);
            _dialog = obj.GetComponent<DialogScript>();
            _dialog.MainText = _mainText;
            _dialog.OkText = _okText;
            _dialog.CancelText = _cancelText;
            _dialog.CancelButtonCallback += () =>
            {
                RecoverAllCanvas();

                CancelBtnCallback?.Invoke();
                Object.Destroy(layer);
            };

            _dialog.OkButtonCallback += () =>
            {
                RecoverAllCanvas();
                OkBtnCallback?.Invoke();
                Object.Destroy(layer);
            };
        }
    }
}