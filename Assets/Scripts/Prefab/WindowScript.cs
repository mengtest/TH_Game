using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Util;

namespace Prefab
{
    /// <summary>
    /// 弹出框,所有弹出框都需要挂载这个组件
    /// </summary>
    [RequireComponent(typeof(Image))]   //至少有一张背景图
    public class WindowScript : MonoBehaviour
    {
        /// <summary>
        /// 将带有这个组件的物体弹出到最上层
        /// </summary>
        public virtual void PopUp()
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            var scale = transform.DOBlendableScaleBy(new Vector3(2, 2, 2), 0.3f);
            var img = GetComponent<Image>();
            if (img == null)
            {
                img = gameObject.AddComponent<Image>();
            }
            var color = img.color;
            img.color = new Color(color.r, color.g, color.b, 0);
            var alpha = img.DOFade(1, 0.3f);
            scale.Play();
            alpha.Play();
            scale.onComplete += AddToUiLayer;
        }

        /// <summary>
        /// 将这个组件的物体显示出来
        /// </summary>
        public void Show()
        {
            //弹出框显示
            OnShow();
            UiManager.Instance.ShowWindow(this);
        }

        public virtual void OnShow()
        {

        }

        public virtual void OnHide()
        {
            //当前窗口隐藏完毕之后销毁这个对象
            Destroy(this.gameObject);
        }

        /// <summary>
        /// 将这个组件的物体隐藏
        /// </summary>
        public virtual void Hide()
        {
            
        }

        //将这个对象添加到ui层当中
        private void AddToUiLayer()
        {
            
        }

        //将当前对象移除
        private void RemoveSelf()
        {

        }
    }
}