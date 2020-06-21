using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Object = UnityEngine.Object;

// https://blog.csdn.net/yzx5452830/article/details/80280864
//这个是位图字体的参考文章
// https://blog.csdn.net/u014230923/article/details/51352284?utm_medium=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.nonecase&depth_1-utm_source=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.nonecase
//这个是拖拽效果的参考文章
// https://www.cnblogs.com/MrZivChu/p/hotupdate.html
// 资源热更新的文件下载参考文章
// https://zhuanlan.zhihu.com/p/66582899
// 帧同步
// https://blog.csdn.net/dingxiaowei2013/article/details/77814966
// 客户端资源下载
// https://zhuanlan.zhihu.com/p/78669458
// skynet


namespace Prefab
{
    public class CombatSceneCombatCardScript: MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEndDragHandler, IBeginDragHandler
    {
        //先想想所有的卡牌控件有哪些信息
        //hp
        //mp
        //def
        //主要是技能要如何表示出来

        //需要实现的功能有
        //  显示图片的更新
        //  属性的更新
        //  类型外框的更新
        //  点击自己或者敌方的棋子后可以显示其详细信息
        //  向前拖拽自己的棋子后可以对敌方的棋子(或玩家)发动攻击
        //  点击棋子后再详细信息中有当前棋子的技能(或者，直接将当前棋子所有的技能显示在棋子的底部)

        public static GameObject dragObject;

        [Tooltip("棋子的血量")]
        public Text hp;

        [Tooltip("棋子的魔法")]
        public Text mp;
        
        [Tooltip("棋子的攻击力")]
        public Text atk;

        //点击这里时需要展示这个卡牌的相信信息
        [Tooltip("卡牌的内容")]
        public Image content;

        [Tooltip("卡牌的外框")]
        public Image boarder;

        //长按这个技能展示这个技能的详细信息
        //点击每个技能时，如果是主动技能则根据这个技能的实际情况判断是否需要释放这个技能
        //如果不满足技能的使用条件，需要显示为灰色，同时点击这个技能使用时提示不满足条件无法使用
        [Tooltip("当前卡牌所拥有的所有技能")] 
        public Image[] skill;

        private Timer _timer;

        private void Awake() 
        {
            
        }

        private void Start() 
        {
            
        }

        private void OnMouseDown() {
            Global.Log("2333333");
        }

        //用户点击当前的卡牌0.5秒之后触发这个事件
        private void ShowDetail()
        {
            Global.Log("show detail");
        }

        //像按钮一样点击并弹起之后才会触发这个事件
        public void OnPointerClick(PointerEventData eventData)
        {
            Global.Log(name);
            _timer?.Cancel();
        }

        //点击到这个卡牌之后就会触发这个事件
        public void OnPointerDown(PointerEventData eventData)
        {
            //点击卡牌0.5秒之后显示这个卡牌的详细信息
            _timer = Timer.Register(0.5f, ShowDetail);
        }

        //点击到这个卡牌之后，再次弹起鼠标就会触发这个事件(不管是不是想点击按钮一样)
        public void OnPointerUp(PointerEventData eventData)
        {
            //弹起时关闭卡牌的详细信息的提示
            Global.Log("取消点击");
            _timer?.Cancel();
        }

        //点击后移动鼠标就会不停的触发这个事件
        public void OnDrag(PointerEventData eventData)
        {
            // transform.DOBlendableLocalMoveBy(eventData.delta, 0.1f);
            dragObject.transform.DOBlendableLocalMoveBy(eventData.delta, 0.1f);
            _timer?.Cancel();
        }

        //玩家的拖拽事件结束的时候触发这个事件
        public void OnEndDrag(PointerEventData eventData)
        {
            if (dragObject != null)
            {
                DestroyImmediate(dragObject);
                dragObject = null;
            }
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (dragObject != null)
            {
                DestroyImmediate(dragObject);
                dragObject = null;
            }
            //将这个对象放置到对象层中

            dragObject = Instantiate(gameObject, GameObject.FindGameObjectWithTag("ObjectLayer").transform, true);
            dragObject.name = "DragObject";
            dragObject.transform.DOBlendableLocalMoveBy(eventData.delta, 0.1f);
        }
    };
}