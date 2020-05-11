using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Util;

namespace Prefab
{
    /// <summary>
    /// 弹出框，主要是为了解决多个弹出框可能会叠加的问题
    /// 管理部分ui
    /// </summary>
    public class WindowScript : MonoBehaviour
    {
        /// <summary>
        /// 将带有这个组件的物体弹出到最上层
        /// </summary>
        public virtual void PopUp()
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            var scale = transform.DOBlendableScaleBy(new Vector3(2, 2, 2), 0.5f);
            var img = GetComponent<Image>();
            if (img == null)
            {
                img = gameObject.AddComponent<Image>();
            }
            var color = img.color;
            img.color = new Color(color.r, color.g, color.b, 0);
            var alpha = img.DOFade(1, 0.5f);
            scale.Play();
            alpha.Play();
            scale.onComplete += AddToUiLayer;
        }

        /// <summary>
        /// 将这个组件的物体显示出来
        /// </summary>
        public virtual void Show()
        {
            UiManager.Instance.ShowWindow(this);   
        }

        private void Next()
        {
            
        }

        /// <summary>
        /// 将这个组件的物体隐藏
        /// </summary>
        public virtual void Hide()
        {
            
        }

        private void AddToUiLayer()
        {
            
        }
    }
}