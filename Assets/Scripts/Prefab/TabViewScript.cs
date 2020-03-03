using System;
using UnityEngine;

namespace Prefab
{
    public class TabViewScript : MonoBehaviour
    {
        [SerializeField] 
        private int curView = 0;
        
        [SerializeField]
        public Global.TabViewPair[] tabViews;
        
        private int _curIndex = 0;
        
        private void Awake()
        {
            _curIndex = curView;
            if (tabViews.Length < 2)
            {
                throw new Exception("必须要有多个才能组成TabView");
            }

            for (int i = 0; i < tabViews.Length; i++)
            {
                var index = i;
                tabViews[i].tab.onClick.AddListener(() =>
                {
                    ChangeTab(index);
                });
            }
        }

        public RectTransform[] GetViews()
        {
            var list = new RectTransform[tabViews.Length];
            int index = 0;
            foreach (var tabView in tabViews)
            {
                list[index] = tabView.view;
                index++;
            }
            return list;
        }

        private void Start()
        {
            tabViews[_curIndex].tab.enabled = false;
            tabViews[_curIndex].tab.interactable = false;
            tabViews[_curIndex].view.gameObject.SetActive(true);
            
            //tab的长度必定大于1
            for (int i = 1; i < tabViews.Length; i++)
            {
                tabViews[i].view.gameObject.SetActive(false);
                tabViews[i].view.localPosition = tabViews[0].view.localPosition;
            }
        }

        private void ChangeTab(int index)
        {
            //激活之前点击(被禁用)的tab
            tabViews[_curIndex].tab.enabled = true;
            tabViews[_curIndex].tab.interactable = true;
            tabViews[_curIndex].view.gameObject.SetActive(false);
            _curIndex = index;
            
            //禁用点击的tab
            tabViews[_curIndex].tab.enabled = false;
            tabViews[_curIndex].tab.interactable = false;
            tabViews[_curIndex].view.gameObject.SetActive(true);
        }
    }
}