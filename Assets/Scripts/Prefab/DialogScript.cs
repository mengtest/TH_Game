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
            set
            {
                var text = _okBtn.GetComponentInChildren<Text>();
                if (value?.Length > 0)
                {
                    text.text = value;
                }
            }
        }

        public string CancelText
        {
            get => _cancelBtn.GetComponentInChildren<Text>().text;
            set
            {
                var text = _cancelBtn.GetComponentInChildren<Text>();
                if (value?.Length > 0)
                {
                    text.text = value;
                }
            }
        }

        private void CancelCallback()
        {
            CancelButtonCallback?.Invoke();
            Destroy(gameObject);
        }

        private void OkCallback()
        {
            OkButtonCallback?.Invoke();
            Destroy(gameObject);
        }
        
        void Start()
        {
            _okBtn.onClick.AddListener(OkCallback);
            _cancelBtn.onClick.AddListener(CancelCallback);
        }
    }
}