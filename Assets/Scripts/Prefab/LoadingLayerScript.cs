using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Prefab
{
    public class LoadingLayerScript : MonoBehaviour
    {
        private Text _text;
        private string _t;
        private int _count = 0;
        
        private void Start()
        {
            _text = GetComponentInChildren<Text>();
            _t = _text.text;

            Invoke(nameof(Timer), 0.5f);
        }

        private void Timer()
        {
            switch (_count % 4)
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

            _count++;
            Invoke(nameof(Timer), 0.5f);
        }
    }
}