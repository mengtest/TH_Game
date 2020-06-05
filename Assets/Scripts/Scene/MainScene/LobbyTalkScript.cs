using UnityEngine;
using UnityEngine.UI;
using XLua;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.EventSystems;
using Button = UnityEngine.UI.Button;

namespace Scene.MainScene
{
    ///在聊天区域内显示的每条信息的具体内容
    struct LobbyMsg
    {
        //消息的发送者名称
        string name;
        //消息发送的时间
        string date;
        //消息的具体内容
        string msg;
    }

    [LuaCallCSharp]
    public class LobbyTalkScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Tooltip("滚动区控件")]
        [SerializeField]
        private ScrollRect scroll;

        [Tooltip("下拉显示频道的控件")]
        [SerializeField]
        private Dropdown channel;

        [Tooltip("输入区域控件")]
        [SerializeField]
        private InputField input;

        [Tooltip("发送消息控件")]
        [SerializeField]
        private Button send;

        //当前鼠标是否悬浮在这个组件上方
        private bool _isHonver = false;

        private Vector3 _originPosition;

        public float speed;

        [Tooltip("每个频道显示的消息上限")]
        public int maxLines;

        public float moveLength = 250;

        private bool _show = false;

        // private RectTransform _rect;
        // private float _width;
        // private float _height;

        //所有频道的消息
        private Queue<string>[] _messages;

        private readonly List<string> _channels = new List<string>{"系统", "世界", "工会", "队伍", "私聊"};
        
        public void AddMessage(int channelId, string msg)
        {
            //将消息添加到对应的队列中
            _messages[channelId].Enqueue(msg);
        }
        
        public void AddMessages(int channelId, string[] messages)
        {
            
        }

        private void Add(string message)
        {
            
        }

        private void Awake()
        {
            channel.ClearOptions();
            channel.AddOptions(_channels);
            _messages = new Queue<string>[_channels.Count];

            // _rect = GetComponent<RectTransform>();
            // _width = _rect.rect.width;
            // _height = _rect.rect.height;

            scroll.scrollSensitivity = speed;

            channel.onValueChanged.AddListener(ChannelChanged);
            send.onClick.AddListener(SendClick);

            _originPosition = new Vector3(transform.localPosition.x, transform.localPosition.y);

            ReDraw();
        }

        private void ReDraw()
        {
            float height = 0;
            foreach (RectTransform child in scroll.content.transform)
            {
                if (child != null)
                {
                    height += (child.rect.height + 10);
                }
            }

            scroll.content.sizeDelta = new Vector2(scroll.content.GetComponent<RectTransform>().rect.width, height);
        }


        private void HideComplete()
        {
            _show = false;
        }

        private void ShowComplete()
        {
            _show = true;   
        }

        private void ChannelChanged(int value)
        {
            Global.Log(_channels[value]);
        }

        private void SendClick()
        {
            // Global.Log("发送消息到" + _channels[channel.value] + "频道");
            //发送消息给对应的频道
            //如果这个频道是私聊频道，则会做出特殊处理
        }

        //聊天大厅将处于隐藏状态，只显示小部分的聊天内容
        public void Hide()
        {
            if (!_show)
            {
                return;
            }

            // var position = transform.position;
            transform.DOLocalMove(new Vector3(_originPosition.x, _originPosition.y), 0.3f)
                    .onComplete = HideComplete;
        }

        //显示完整的聊天大厅
        public void Show()
        {
            if (_show)
            {
                return;
            }
            // var position = transform.position;
            transform.DOLocalMove(new Vector3(_originPosition.x, _originPosition.y + moveLength), 0.3f)
                .onComplete = ShowComplete;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _isHonver = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _isHonver = false;
        }

        private void Update()
        {
            //点击聊天框后显示完整得聊天框，否则显示部分聊天框
            if (Input.GetMouseButtonDown(0))
            {
                if (_isHonver)
                {
                    Show();
                }
                else
                {
                    Hide();
                }
            }
        }
    }
}