using System;
using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class TabViewScript : MonoBehaviour
    {
        [SerializeField]
        private Button[] _tabs;

        [SerializeField] 
        private int _curView = 0;

        [SerializeField] 
        private RectTransform[] _views;

        private int _curIndex = 0;
        
        private void Awake()
        {
            _curIndex = _curView;
            if (_tabs.Length < 2 || _views.Length < 2)
            {
                throw new Exception("tab与view的长度必须大于等于1");
            }

            if (_tabs.Length != _views.Length)
            {
                throw new Exception("tab与view的长度必须相等");
            }
            
            for (int i = 0; i < _tabs.Length; i++)
            {
                var index = i;
                _tabs[i].onClick.AddListener(() =>
                {
                    ChangeTab(index);
                });
            }
        }

        private void Start()
        {
            _tabs[_curIndex].enabled = false;
            _tabs[_curIndex].interactable = false;
            _views[_curIndex].gameObject.SetActive(true);
            
            //tab的长度必定大于1
            for (int i = 1; i < _tabs.Length; i++)
            {
                _views[i].gameObject.SetActive(false);
                _views[i].localPosition = _views[0].localPosition;
            }
        }

        private void ChangeTab(int index)
        {
            //激活之前点击(被禁用)的tab
            _tabs[_curIndex].enabled = true;
            _tabs[_curIndex].interactable = true;
            _views[_curIndex].gameObject.SetActive(false);
            _curIndex = index;
            
            //禁用点击的tab
            _tabs[_curIndex].enabled = false;
            _tabs[_curIndex].interactable = false;
            _views[_curIndex].gameObject.SetActive(true);
        }
    }
}