using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EX
{
    //对ScrollView的功能做出一些扩展
    public class ScrollViewEx : ScrollRect
    {
        private HorizontalLayoutGroup _layout;

        //为什么这里的字段在editor中显示不出来？
        [Tooltip("每个元素的宽度")]
        [SerializeField]
        private float elementWidth = 300;

        private int _index;

        private int _speed = 50;

        protected override void Awake()
        {
            base.Awake();
            _layout = GetComponentInChildren<HorizontalLayoutGroup>();
        }

        protected override void Start()
        {
            base.Start();
            
            CalculateRect();
            
            //将当前的大小修正到与画布相同
            var rect = GetComponentInParent<Canvas>().GetComponent<RectTransform>().rect;
            content.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.height);
            transform.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.height);
        }

        public override void OnScroll(PointerEventData data)
        {
            //交换xy的值，来达到滚动滚轮，横向滚动的效果
            data.scrollDelta = new Vector2(data.scrollDelta.y * _speed, data.scrollDelta.x);
            base.OnScroll(data);
        }

        //添加一个子节点
        public void AddChild(Transform child)
        {
            child.SetParent(content);
            _index++;
            CalculateRect();
        }

        public int Count()
        {
            return _index;
        }

        public void AddChildren(Transform[] children)
        {
            foreach (var child in children)
            {
                child.SetParent(content);
                _index++;
            }
        }

        //重新计算content区域的大小
        private void CalculateRect()
        {
            var rect = content.rect;
            var newRect = new Rect(rect);
            newRect.width = _layout.padding.left + _layout.padding.right;
            //反复添加子节点的宽度
            foreach (var chapter in this.GetComponentsInChildren<ChapterScript>())
            {
                newRect.width += chapter.GetComponent<RectTransform>().rect.width + _layout.spacing;
            }
            content.sizeDelta = new Vector2(newRect.width, newRect.height);
        }
    }
}