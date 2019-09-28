using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class DialogScript : MonoBehaviour
    {
        public delegate void ButtonCallback();

        public event ButtonCallback OkButtonCallback;
        public event ButtonCallback CancelButtonCallback;

        public Text _text;
        public Button _okBtn;
        public Button _cancelBtn;

        public void SetText(string text)
        {
            if (text == null)
            {
                text = "";
            }
            this._text.text = text;
        }

        public void SetOkText(string text)
        {
            if (text == null)
            {
                text = "";
            }
            this._okBtn.GetComponentInChildren<Text>().text = text;
        }

        public void SetCancelText(string text)
        {
            if (text == null)
            {
                text = "";
            }
            this._cancelBtn.GetComponentInChildren<Text>().text = text;
        }

        private void CancelCallback()
        {
            CancelButtonCallback?.Invoke();
            Destroy(gameObject.GetComponent<Transform>().gameObject);
        }

        private void OkCallback()
        {
            OkButtonCallback?.Invoke();
            Destroy(gameObject.GetComponent<Transform>().gameObject);
        }
        
        void Start()
        {
            _okBtn.onClick.AddListener(OkCallback);
            _cancelBtn.onClick.AddListener(CancelCallback);
        }
    }
}
