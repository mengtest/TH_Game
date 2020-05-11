using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Util;
using XLua;

namespace EX
{
    /// <summary>
    /// 个人感觉，想把这个mono独立成一个额外的mono而不是继承于ScrollRect
    /// </summary>
    [LuaCallCSharp]
    public class ScrollListEx : ScrollRect
    {
        public static string SCROLL_ADD_EVENT = "scroll_add_gameobject";
        
        [CSharpCallLua]
        public delegate void AddGameObjectCallback(GameObject obj, int index);

        // [CSharpCallLua]
        public event AddGameObjectCallback scrollListAddObjectCallback;

        [Serializable]
        public enum ListType
        {
            Horiz,
            Vert,
            Grid,
        }

        // public float speed = 20;
        public ListType type = ListType.Vert;

        [Tooltip("竖直布局下失效，每个元素之间的间隔")]
        private float paddingWidth;

        [Tooltip("水平布局下失效，每个元素之间的间隔")]
        private float paddingHeight;

        [Tooltip("水平元素的个数")]
        // [Range(2, 10)]
        public int widthCount = 3;

        [Tooltip("网格布局中每个元素的样例，或者底图")]
        public Transform cell;

        // [Tooltip("cell的大小是否一致")]
        // public bool regular = true;

        [Tooltip("显示的数据的长度,只在启动时有效")]
        public int dataLength;

        private IPrimitive _impl;

        public void BindDataLength(uint length)
        {
            dataLength = (int) length;
            _impl.BindDataLength((int) length);
        }

        public void Refresh()
        {
            _impl.Refresh();
        }

        /// <summary>
        /// 刷新指定下标的物体
        /// </summary>
        /// <param name="index"></param>
        public void Refresh(int index)
        {
            _impl.Refresh(index);
        }

        protected override void Awake()
        {
            // this.
            if (cell == null)
            {
                throw new Exception("cell控件不能为空");
            }

            var grid = GetComponent<ScrollRect>().content.GetComponent<GridLayoutGroup>();
            var spacing = grid.spacing;
            paddingHeight = spacing.y;
            paddingWidth = spacing.x;
            var rect = cell.GetComponent<RectTransform>().rect;
            grid.cellSize = new Vector2(rect.width, rect.height);
            grid.constraintCount = widthCount;
            
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
                    _impl = new GridScroll(this, dataLength);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            onValueChanged.AddListener((data) =>
            {
                _impl.OnRender(data);
            });
            
            scrollListAddObjectCallback = AddGameObject;
        }

        private void AddGameObject(GameObject obj, int index)
        {
            
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

        [DoNotGen]
        //由该接口的实例化对象持有布局组件
        public interface IPrimitive
        {
            /// <summary>
            /// 重绘
            /// </summary>
            void ReDraw();
            
            /// <summary>
            /// 滚动界面时触发
            /// </summary>
            /// <param name="data"></param>
            void OnRender(ref PointerEventData data);
            
            /// <summary>
            /// 用于rect的位置被修改时，触发impl的滚动逻辑
            /// </summary>
            /// <param name="data"></param>
            void OnRender(Vector2 data);

            void Refresh(int index);

            /**
            * <summary>
            *  滚动到下标为index的元素的地方
            * </summary>  
            */
            void ScrollTo(int index);

            /// <summary>
            /// 单独添加一个物体，并激活
            /// </summary>
            /// <param name="child"></param>
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

            /// <summary>
            /// 修改整个scroll中的数据长度
            /// </summary>
            /// <param name="index"></param>
            void BindDataLength(int index = 1);

            /// <summary>
            /// 数据变更了或者长度变更了，重新刷新显示效果
            /// </summary>
            void Refresh();
        }

        
        [DoNotGen]
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
            public void BindDataLength(int index = 1)
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

            public void Refresh()
            {

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

            public void OnRender(Vector2 data)
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

            public void Refresh(int index)
            {
                
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
                // Lib.Listener.Instance.Event("scroll_add_gameobject", _holder, obj, index);
                _holder.scrollListAddObjectCallback?.Invoke(obj, index);
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


        //为了简化操作，每次移动后操作得物体都是width个
        [Serializable]
        [DoNotGen]
        private class GridScroll: IPrimitive
        {
            //持有这个对象的类的引用
            private ScrollListEx _holder;
            //content的矩形
            private RectTransform _rect;
            //添加物体的事件
            public event AddGameObjectCallback addGameObjectEvent;
            
            //数据的实际长度
            private int _dataLength;
            //长度是动态计算的,这个表示当前实际上展示的物体的长度
            private int _height;
            //这个表示当前所有物体的长度，会根据这个数值来修改content的大小
            private int _dataHeight;
            //宽度为初始化时指定，并且不可修改
            private int _dataWidth;
            //原始数据长度
            private int _originLength;

            private RectTransform _cellRect;
            
            private int _maxChildCount;
            // private bool _scrollTop = true;
            // private bool _scrollBottom = true;

            private int _firstId;
            private int _lastId;

            private Vector2 _prevData = new Vector2(1, 1);

            public int GetDataLength()
            {
                return _dataLength;
            }

            /**
             * <summary>
             * 增加要显示的数据的量
             * </summary>
             */
            public void BindDataLength(int index = 1)
            {
                if (index < 0)
                {
                    throw new Exception("数据长度必须大于等于0");
                    
                }
                else if (index == 0)
                {
                    //如果长度为0的话，表示当前没有任何内容
                    _dataLength = 0;
                    _originLength = 0;
                }
                else if (index > 0)
                {
                    if (index > _dataLength)
                    {
                        _originLength = index;
                        _dataLength = (index / _dataWidth + (index % _dataWidth == 0 ? 0 : 1)) * _dataWidth;
                    }
                    else if (index == _dataLength)
                    {
                        
                    }
                    else
                    {
                        _originLength = _dataLength;
                        _dataLength = (index / _dataWidth + (index % _dataWidth == 0 ? 0 : 1)) * _dataWidth;
                    }
                }
                //每次重新绑定数据长度都会刷新所有的数据
                Refresh();
                //每次重新绑定数据长度都会重新计算整个矩形区域的大小
                ReDraw();
            }

            public GridScroll(ScrollListEx holder, int sourceLength)
            {
                _holder = holder;
                _rect = holder.content;
                //最大子物体的数量，为可视范围的高度除以cell的高度与paddingHeight之和，这里会额外添加两个物体，以解决部分bug
                _maxChildCount = (int)(_holder.viewport.rect.height / (_holder.cell.GetComponent<RectTransform>().rect.height + _holder.paddingHeight)) + 2;
                _dataWidth = _holder.widthCount;
                _cellRect = _holder.cell.GetComponent<RectTransform>();
                
                addGameObjectEvent = AddGameObject;
                
                //将数据长度扩展为宽度的整数倍
                //如果重新渲染的物体的长度是被扩充的，那么则传递-1，表示无效的id
                _dataLength = sourceLength;
                _originLength = _dataLength;
                _dataLength = (_dataLength / _dataWidth + (_dataLength % _dataWidth == 0 ? 0 : 1)) * _dataWidth;
                
                var rect = holder.cell.GetComponent<RectTransform>().rect;
                int minCountY = (int) (_holder.viewport.rect.height / (rect.height + _holder.paddingHeight));
                var minCount = _dataWidth * (minCountY + 2);
                
                _firstId = 0;
                _lastId = minCount - 1;

                if (_holder.content.childCount != 0)
                {
                    //如果当前所有的元素都不足以滚动呢？
                    for (int i = 0; i < minCount; i++)
                    {
                        var go = _holder.content.GetChild(i);
                        go.gameObject.SetActive(true);
                        go.name = i.ToString();
                        if (i < _originLength)
                        {
                            addGameObjectEvent?.Invoke(go.gameObject, i);
                        }
                        else
                        {
                            go.gameObject.SetActive(false);
                        }
                    }
                    // _holder.content.GetComponent<GridLayoutGroup>().enabled = false;
                    // ReDraw();
                }
                else
                {
                    //如果当前所有的元素都不足以滚动呢？
                    for (int i = 0; i < minCount; i++)
                    {
                        var go = Instantiate(_holder.cell, _holder.content);
                        go.gameObject.SetActive(true);
                        go.name = i.ToString();
                        if (i < _originLength)
                        {
                            addGameObjectEvent?.Invoke(go.gameObject, i);                        
                        }
                        else
                        {
                            go.gameObject.SetActive(false);
                        }
                    }
                    _holder.content.GetComponent<GridLayoutGroup>().enabled = false;
                }
                _holder.content.GetComponent<GridLayoutGroup>().enabled = false;
                ReDraw();
            }

            /// <summary>
            /// 更新所有的子物体的显示与隐藏等
            /// </summary>
            private void RefreshChildren()
            {
                
            }

            /// <summary>
            /// 调用这个函数，会为每个对象刷新数据
            /// </summary>
            public void Refresh()
            {
                //这里还需要增加一个功能
                //如果根据当前的长度重新刷新
                var index = _firstId;
                foreach (Transform child in _holder.content)
                {
                    if (index < _dataLength)
                    {
                        child.gameObject.SetActive(true);
                        addGameObjectEvent?.Invoke(child.gameObject, index);
                        index++;    
                    }
                    else
                    {
                        child.gameObject.SetActive(false);   
                    }
                }
            }

            // /// <summary>
            // /// 数据的长度变化后调用这个函数刷新当前的子物体
            // /// </summary>
            // /// <param name="length"></param>
            // public void Refresh(int length)
            // {
            //     
            // }

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
                return true;
            }

            public bool CanScrollBottom()
            {
                return true;
            }

            public bool CanScrollLeft()
            {
                return false;
            }

            public bool CanScrollRight()
            {
                return false;
            }

            public void OnRender(Vector2 data)
            {
                //向下滚动
                // if ((data.y < 0)  && !CanScrollBottom())
                // {
                //     data = Vector2.zero;
                // }
                //
                // //向上滚动
                // if ((data.y > 0 || data.y > 0) && !CanScrollTop())
                // {
                //     data = Vector2.zero;
                // }

                if (_prevData == null)
                {
                    _prevData = data;
                }
                
                if (_prevData.y > data.y)
                {
                    ScrollDown();
                }
                else if (_prevData.y < data.y)
                {
                    ScrollUp(); 
                }

                _prevData = data;
            }

            public void Refresh(int index)
            {
                var name = index.ToString();
                var obj = _holder.content.GetChildByName(name);
                //如果查找不到对应id的控件，则说明这个控件没有显示，则不用任何操作，等在滚动时其自动刷新就好了
                if (obj != null)
                {
                    addGameObjectEvent?.Invoke(obj.gameObject, index);
                }
            }

            /**
             * <summary>
             * 将下标为index的cell设置为第一个显示的物体
             * 目前还不太好实现这个功能
             * </summary>
             */
            public void ScrollTo(int index)
            {
                throw new Exception("没有实现的函数");
                
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
                // _scrollTop = true;
                //如果当前最大的id与当前的数据长度相等，那么就不再执行这里的操作
                //此时不再执行下滚的操作
                if(_lastId == _dataLength - 1)
                {
                    //如果最后一个节点已经完全显示在视口当中，则不再允许下滚的操作
                    // if (_holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>().IsInRect(_holder.viewport))
                    // {
                    //     // _scrollBottom = false;    
                    // }
                    return;
                }

                //向上滚动时调用的回调
                if (_holder.content.childCount == 0)
                {
                    return;
                }
                var lastObj = _holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>();
                var firstObj = _holder.content.GetChild(0).GetComponent<RectTransform>();
                if (!firstObj.IsOverlap(_holder.viewport))
                {
                    for (int i = 0; i < _dataWidth; i++)
                    {
                        _lastId++;
                        firstObj.name = _lastId.ToString();
                        _firstId++;
                        firstObj.localPosition = new Vector3(firstObj.localPosition.x,
                            lastObj.localPosition.y -
                            _holder.paddingHeight - firstObj.rect.height / 2 - lastObj.rect.height / 2);
                        firstObj.SetAsLastSibling();
                        if (_lastId >= _originLength)
                        {
                            firstObj.gameObject.SetActive(false);
                        }
                        else
                        {
                            addGameObjectEvent?.Invoke(firstObj.gameObject, _lastId);    
                        }
                        firstObj = _holder.content.GetChild(0).GetComponent<RectTransform>();
                    }
                }
            }
            
            public void ScrollUp()
            {
                // _scrollBottom = true;
                //如果当前最小的id为0，那么就不再执行这里的操作
                //并且此时无法执行上滚的操作
                if(_firstId == 0)
                {
                    //如果最后一个节点已经完全显示在视口当中，则不再允许下滚的操作
                    // if (_holder.content.GetChild(0).GetComponent<RectTransform>().IsInRect(_holder.viewport))
                    // {
                    //     // _scrollTop = false;
                    // }
                    return;
                }

                //向下滚动时调用的回调
                if (_holder.content.childCount == 0)
                {
                    return;
                }
                
                var firstObj = _holder.content.GetChild(0).GetComponent<RectTransform>();
                var lastObj = _holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>();
                if (!lastObj.IsOverlap(_holder.viewport))
                {
                    for (int i = 0; i < _dataWidth; i++)
                    {
                        _firstId--;
                        lastObj.name = _firstId.ToString();
                        _lastId--;
                        lastObj.localPosition = new Vector3(lastObj.localPosition.x,
                            firstObj.localPosition.y +
                            _holder.paddingHeight + lastObj.rect.height / 2 + firstObj.rect.height / 2);
                        lastObj.SetAsFirstSibling();
                        lastObj.gameObject.SetActive(true);
                        addGameObjectEvent?.Invoke(lastObj.gameObject, _firstId);
                        lastObj = _holder.content.GetChild(_holder.content.childCount - 1).GetComponent<RectTransform>();
                    }
                }
            }

            //实际上现在的api根本用不上redraw
            //不知道是否是添加新节点导致的重绘
            public void ReDraw()
            {
                _dataHeight = _dataLength / _dataWidth;
                
                //重绘主要的操作就是修改scrollRect的content的大小
                // float height = 0;
                // foreach (RectTransform item in _holder.content.transform)
                // {
                //     height += item.rect.height;
                // }
                // var content1 = _holder.content;
                // height += (content1.childCount - 1) * _holder.paddingHeight;
                // content1.sizeDelta = new Vector2(_rect.rect.width, height);
                //需要增加一个表示当前数据转化后所能展示的对象的排数(_height)
                
                //这里有一个bug，这里获取到的宽度为240，而实际宽度为255，长度也是如此，所以在这里手动添加
                _holder.content.sizeDelta = new Vector2(_cellRect.sizeDelta.x * _dataWidth + _holder.paddingWidth * (_dataWidth - 1) + 10,
                    _cellRect.sizeDelta.y * _dataHeight + _holder.paddingHeight * (_dataHeight - 1));
            }

            //添加一个新的节点导致的重绘
            public void ReDraw(GameObject child)
            {
                //重绘主要的操作就是修改scrollRect的content的大小
                // _holder.content.sizeDelta = new Vector2(_rect.rect.width, _rect.rect.height + child.GetComponent<RectTransform>().rect.height + _holder.paddingHeight);
                
                _holder.content.sizeDelta = new Vector2(_rect.rect.width * _dataWidth + _holder.paddingWidth * (_dataWidth - 1) + 10,
                    _rect.rect.height * _dataHeight + _holder.paddingHeight * (_dataHeight - 1));
            }

            private void AddGameObject(GameObject obj, int index)
            {
                //发起这样的一个事件
                // Lib.Listener.Instance.Event("scroll_add_gameobject", _holder, obj, index);
                _holder.scrollListAddObjectCallback?.Invoke(obj, index);
            }
        }
    }
}