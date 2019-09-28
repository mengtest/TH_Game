using System;
using Prefab;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Util
{
    public class ModelDialog
    {
        public delegate void ButtonCallback();

        public event ButtonCallback OkBtnCallback;
        public event ButtonCallback CancelBtnCallback;

        private string _mainText;
        private string _okText;
        private string _cancelText;
        private DialogScript _dialog;

        public ModelDialog()
        {

        }

        public ModelDialog(string text, string okText = null, string cancelText = null, ButtonCallback okCallback = null,
            ButtonCallback cancelCallback = null)
        {
            _mainText = text;
            if (okText?.Length > 0)
            {
                _okText = okText;
            }
            if (cancelText?.Length > 0)
            {
                _cancelText = okText;
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

        public void ShowDialog()
        {
            //当创建这个窗口的时候，屏蔽掉之前的所有的UI的事件
            foreach (var objs in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                if (objs.GetComponent<Canvas>() != null)
                {
                    objs.GetComponent<GraphicRaycaster>().enabled = false;
                }
            }

            //创建canvas
            var layer= new GameObject("ModelDialogLayer");
            var canvas = layer.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            layer.AddComponent<CanvasScaler>();
            layer.AddComponent<GraphicRaycaster>();

            //通过这个API向Scene中添加对象
            SceneManager.MoveGameObjectToScene(canvas.gameObject, SceneManager.GetActiveScene());

            //dialog的创建与加载
            var gameObj = Resources.Load("Prefab/Dialog");
            var obj = (GameObject) Object.Instantiate(gameObj);
            obj.GetComponent<RectTransform>().SetParent(canvas.GetComponent<Transform>());
            obj.GetComponent<RectTransform>().localPosition = new Vector3(0, 0);
            _dialog = obj.GetComponent<DialogScript>();
            _dialog.SetText(_mainText);
            _dialog.SetOkText(_okText);
            _dialog.SetCancelText(_cancelText);
            _dialog.CancelButtonCallback += () =>
            {
                //在点击按钮之后将所有的GraphicRaycaster设置为true
                //但是原来的状态并不一定是true
                //如果使用集合全部存入，也有被删除的可能，所以就直接设置成true
                foreach (var objs in SceneManager.GetActiveScene().GetRootGameObjects())
                {
                    if (objs.GetComponent<Canvas>() != null)
                    {
                        objs.GetComponent<GraphicRaycaster>().enabled = true;
                    }
                }

                CancelBtnCallback?.Invoke();
                Object.Destroy(layer);
            };

            _dialog.OkButtonCallback += () =>
            {
                foreach (var objs in SceneManager.GetActiveScene().GetRootGameObjects())
                {
                    if (objs.GetComponent<Canvas>() != null)
                    {
                        objs.GetComponent<GraphicRaycaster>().enabled = true;
                    }
                }

                OkBtnCallback?.Invoke();
                Object.Destroy(layer);
            };
        }
    }
}