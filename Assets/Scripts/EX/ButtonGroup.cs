using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace EX
{
//    [RequireComponent(typeof(VerticalLayoutGroup))]
    public class ButtonGroup : MonoBehaviour
    {
        [Tooltip("是否同时只有一个按钮有效")]
        [SerializeField]
        public bool _single = true;

        public IDictionary<Button, string> _buttons = new Dictionary<Button, string>();

        public void InsertButton(Button button, Action action)
        {
//            _buttons.Add(button, action);
        }

        private void Start()
        {
            if (_single)
            {

            }
        }
    }
}