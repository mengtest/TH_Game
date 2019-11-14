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

        public string MainText
        {
            get => _text.text;
            set => _text.text = value;
        }

        public string OkText
        {
            get => _okBtn.GetComponentInChildren<Text>().text;
            set => _okBtn.GetComponentInChildren<Text>().text = value;
        }

        public string CancelText
        {
            get => _cancelBtn.GetComponentInChildren<Text>().text;
            set => _cancelBtn.GetComponentInChildren<Text>().text = value;
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
