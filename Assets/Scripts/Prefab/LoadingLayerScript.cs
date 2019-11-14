using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class LoadingLayerScript : MonoBehaviour
    {
        private Text _text;
        private string _t;
        private int count = 0;
        
        private void Start()
        {
            _text = GetComponentInChildren<Text>();
            _t = _text.text;
            Invoke(nameof(Timer), 0.5f);
        }

        private void Timer()
        {
            switch (count % 4)
            {
                case 0:
                    _text.text = _t + ".";
                    break;
                case 1:
                    _text.text = _t + "..";
                    break;
                case 2:
                    _text.text = _t + "...";
                    break;
                case 3:
                    _text.text = _t;
                    break;
                default:
                    _text.text = _t;
                    break;
            }

            Invoke(nameof(Timer), 0.5f);
        }
    }
}