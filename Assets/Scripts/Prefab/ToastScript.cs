using System;
using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class ToastScript : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        
        public void Make(string text, float time)
        {
            this._text.text = text;
            Invoke(nameof(Hide), time);
        }

        private void Hide()
        {
            DestroyImmediate(gameObject);    
        }
    }
}