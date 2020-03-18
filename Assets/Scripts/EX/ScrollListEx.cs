﻿using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Util;

namespace EX
{
    public class ScrollListEx : ScrollRect
    {
        public delegate void AddGameObjectCallback(GameObject obj, int index);

        [Serializable]
        public enum ListType
        {
            Horiz,
            Vert,
            Grid,
        }

        public float speed = 20;
        public ListType type = ListType.Vert;

        [Tooltip("竖直布局下失效，每个元素之间的间隔")]
        public float paddingWidth;
        [Tooltip("水平布局下失效，每个元素之间的间隔")]
        public float paddingHeight;

        [Tooltip("网格布局中每个元素的样例，或者底图")]
        public Transform cell;

        [Tooltip("cell的大小是否一致")]
        public bool regular = true;

        [Tooltip("显示的数据的长度")]
        public int dataLength;

        private IPrimitive _impl;

        protected override void Awake()
        {
            if (cell == null)
            {
                throw new Exception("cell控件不能为空");
            }
            
            base.Awake();

            switch (type)
            {
                case ListType.Horiz:
                    // _impl = new HorizScroll(this);
                    break;
                case ListType.Vert:
                    _impl = new VertScroll(this, dataLength);
                    break;
                case ListType.Grid:
                    // _impl = new GridScroll(this);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            cell.gameObject.SetActive(false);
            _impl.addGameObjectEvent += (o, index) =>
            {
                o.GetComponent<Text>().color = new Color(index / 20.0F, index / 20.0F, index / 20.0F);
            };
        }

        //重新计算当前的content的大小
        private void ReDraw()
        {
            
        }

        //需要创建新的cell的时候调用
        private GameObject CreateCell()
        {
            return Instantiate(cell.gameObject);
        }

        public override void OnScroll(PointerEventData data)
        {
            Debug.Log(data.scrollDelta.y);
            _impl.OnRender(ref data);
            base.OnScroll(data);
            Debug.Log(data.scrollDelta.y);
        }

        public override void OnDrag(PointerEventData eventData)
        {
            Debug.Log(eventData.delta.y);
            _impl.OnRender(ref eventData);
            Debug.Log(eventData.delta.y);
            base.OnDrag(eventData);
        }

        //由该接口的实例化对象持有布局组件
        public interface IPrimitive
        {
            void ReDraw();

            //滚动界面时触发
            void OnRender(ref PointerEventData data);

            bool CanScrollTop();

            bool CanScrollBottom();

            bool CanScrollLeft();

            bool CanScrollRight();

            /**
            * <summary>
            *  滚动到下标为index的元素的地方
            * </summary>  
            */
            void ScrollTo(int index);

            void ReDraw(GameObject child);

            /**
            * <summary>
            * 添加了新的物体，或者物体的下表被修改时触发
            * </summary>  
            */
            event AddGameObjectCallback addGameObjectEvent;

            /**
            * <summary>
            * 物体的数量
            * </summary>  
            */
            int GetDataLength();

            void AddData(int index = 1);
        }

        [Serializable]
        private class VertScroll: IPrimitive
        {
            //持有这个对象的类的引用
            private ScrollListEx _holder;
            //当前视图的布局方式
            // private VerticalLayoutGroup _vert;
            //content的矩形
            private RectTransform _rect;
            //添加物体的事件
            public event AddGameObjectCallback addGameObjectEvent;

            public int GetDataLength()
            {
                return _dataLength;
            }

            /**
             * <summary>
             * 增加要显示的数据的量
             * </summary>
             */
            public void AddData(int index = 1)
            {
                if (index < 0)
                {
                    throw new Exception("数据增加的量，必须大于0");
                }
                else if (index == 0)
                {
                    
                }
                else if (index > 0)
                {
                    _dataLength += index;
                    _scrollBottom = true;
                }
            }

            private int _dataLength;

            private int _maxChildCount;

            private bool _scrollTop = true;
            private bool _scrollBottom = true;

            private int _firstId;
            private int _lastId;

            public VertScroll(ScrollListEx holder, int sourceLength)
            {
                _holder = holder;
                _rect = holder.content;
                //最大子物体的数量，为可视范围的高度除以cell的高度与paddingHeight之和，这里会额外添加两个物体，以解决部分bug
                _maxChildCount = (int)(_holder.viewport.rect.height / (_holder.cell.GetComponent<RectTransform>().rect.height + _holder.paddingHeight)) + 2;
                addGameObjectEvent = AddGameObject;
                for (int i = 0; i < _holder.content.childCount; i++)
                {
                    var obj = _holder.content.GetChild(i);
                    obj.name = i.ToString();
                    addGameObjectEvent?.Invoke(obj.gameObject, i);
                }
                _dataLength = sourceLength;
                _firstId = 0;
                _lastId = _holder.content.childCount - 1;
            }

            public void OnRender(ref PointerEventData data)
            {
                //向下滚动
                if ((data.scrollDelta.y < 0 || data.delta.y < 0)  && !CanScrollBottom())
                {
                    data.scrollDelta = Vector2.zero;
                    data.delta = Vector2.zero;
                }
                
                //向上滚动
                if ((data.scrollDelta.y > 0 || data.delta.y > 0) && !CanScrollTop())
                {
                    data.scrollDelta = Vector2.zero;
                    data.delta = Vector2.zero;
                }

                if (data.scrollDelta.y < 0 || data.delta.y < 0)
                {
                    ScrollDown();
                }
                else if (data.scrollDelta.y > 0 || data.delta.y > 0)
                {
                    ScrollUp();
                }
            }

            public bool CanScrollTop()
            {
                return _scrollTop;
            }

            public bool CanScrollBottom()
            {
                return _scrollBottom;
            }

            public bool CanScrollLeft()
            {
                return false;
            }

            public bool CanScrollRight()
            {
                return false;
            }

            private void OnRender(Vector2 data)
            {
                //向下滚动
                if ((data.y < 0)  && !CanScrollBottom())
                {
                    data = Vector2.zero;
                }
                
                //向上滚动
                if ((data.y > 0 || data.y > 0) && !CanScrollTop())
                {
                    data = Vector2.zero;
                }

                if (data.y < 0)
                {
                    ScrollDown();
                }
                else if (data.y > 0)
                {
                    ScrollUp();
                }
            }

            /**
             * <summary>
             * 将下标为index的cell设置为第一个显示的物体
             * </summary>
             */
            public void ScrollTo(int index)
            {
                if ( index >= _dataLength )
                {
                    index = _dataLength;
                }

                if(index < 0)
                {
                    index = 0;
                }
                
                //再滚动到对应的位置
                // _holder.content.DOMove(new Vector3(0, _holder.content.position.y - 100), 1);
            }

            //滚动的时候，不断的调用这个函数，去检测当前队列当中的第一个物体是否可见
            //物体的可见性可以通过检测第一个物体以及当前视口的矩形是否相交来判断
            public void ScrollDown()
            {
                _scrollTop = true;
                //如果当前最大的id与当前的数据长度相等，那么就不再执行这里的操作
                //此时不再执行下滚的操作
                if(_lastId == _dataLength - 1)
                {
                    //如果最后一个节点已经完全显示在视口当中，则不再允许下滚的操作
                    if (_holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>().IsInRect(_holder.viewport))
                    {
                        _scrollBottom = false;    
                    }
                    return;
                }

                //向上滚动时调用的回调
                if (_holder.content.childCount == 0)
                {
                    return;
                }
                var firstObj = _holder.content.GetChild(0).GetComponent<RectTransform>();
                var lastObj = _holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>();
                if (!firstObj.IsOverlap(_holder.viewport))
                {
                    _lastId++;
                    firstObj.name = _lastId.ToString();
                    _firstId++;
                    firstObj.localPosition = new Vector3(firstObj.localPosition.x,
                        _holder.content.GetChild(_holder.content.childCount - 1).localPosition.y -
                        _holder.paddingHeight - firstObj.rect.height / 2 - lastObj.rect.height / 2);
                    firstObj.SetAsLastSibling();
                    // AddGameObject(firstObj.gameObject, _lastId);
                    addGameObjectEvent?.Invoke(firstObj.gameObject, _lastId);
                }
            }
            
            public void ScrollUp()
            {
                _scrollBottom = true;
                //如果当前最小的id为0，那么就不再执行这里的操作
                //并且此时无法执行上滚的操作
                if(_firstId == 0)
                {
                    //如果最后一个节点已经完全显示在视口当中，则不再允许下滚的操作
                    if (_holder.content.GetChild(0).GetComponent<RectTransform>().IsInRect(_holder.viewport))
                    {
                        _scrollTop = false;
                    }
                    return;
                }

                //向下滚动时调用的回调
                if (_holder.content.childCount == 0)
                {
                    return;
                }
                var lastObj = _holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>();
                var firstObj = _holder.content.GetChild(0).GetComponent<RectTransform>();
                if (!lastObj.IsOverlap(_holder.viewport))
                {
                    _firstId--;
                    lastObj.name = _firstId.ToString();
                    _lastId--;
                    lastObj.localPosition = new Vector3(lastObj.localPosition.x,
                        _holder.content.GetChild(0).localPosition.y +
                        _holder.paddingHeight + lastObj.rect.height / 2 + firstObj.rect.height / 2);
                    lastObj.SetAsFirstSibling();
                    addGameObjectEvent?.Invoke(lastObj.gameObject, _firstId);
                }
            }

            //实际上现在的api根本用不上redraw
            //不知道是否是添加新节点导致的重绘
            public void ReDraw()
            {
                //重绘主要的操作就是修改scrollRect的content的大小
                float height = 0;
                foreach (RectTransform item in _holder.content.transform)
                {
                    height += item.rect.height;
                }
                height += (_holder.content.childCount - 1) * _holder.paddingHeight;
                _holder.content.sizeDelta = new Vector2(_rect.rect.width, height);
            }

            //添加一个新的节点导致的重绘
            public void ReDraw(GameObject child)
            {
                //重绘主要的操作就是修改scrollRect的content的大小
                _holder.content.sizeDelta = new Vector2(_rect.rect.width, _rect.rect.height + child.GetComponent<RectTransform>().rect.height + _holder.paddingHeight);
            }

            private void AddGameObject(GameObject obj, int index)
            {
                //发起这样的一个事件
                Lib.Listener.Instance.Event("scroll_add_gameobject", _holder, obj, index);
            }
        }

        // [Serializable]
        // private class HorizScroll: IPrimitive
        // {
        //     private HorizontalLayoutGroup _horiz;
        //     private ScrollListEx _holder;
        //     public HorizScroll(ScrollListEx holder)
        //     {
        //         _holder = holder;
        //         _horiz = _holder.content.gameObject.AddComponent<HorizontalLayoutGroup>();
        //     }

        //     public void ReDraw()
        //     {

        //     }

        //     public void OnRender(PointerEventData data)
        //     {
        //         throw new NotImplementedException();
        //     }
        // }

        // [Serializable]
        // private class GridScroll: IPrimitive
        // {
        //     private ScrollListEx _holder;
        //     private GridLayoutGroup _grid;

        //     public GridScroll(ScrollListEx holder)
        //     {
        //         _holder = holder;
        //         _grid = _holder.content.gameObject.AddComponent<GridLayoutGroup>();
        //     }

        //     public void ReDraw()
        //     {
                
        //     }

        //     public void OnRender(PointerEventData data)
        //     {
        //         throw new NotImplementedException();
        //     }

        //     public Component GetLayout()
        //     {
        //         return _grid;
        //     }
        // }
    }
}