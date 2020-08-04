using System.Collections.Generic;
using System.Text;
using XLua;

namespace Core
{
    [LuaCallCSharp]
    public class DataCenter
    {
        private static DataCenter _instance;

        public static DataCenter Instance => _instance;

        [CSharpCallLua]
        [LuaCallCSharp]
        public delegate void Delegate(byte[] bytes);
        
        [CSharpCallLua]
        [LuaCallCSharp]
        public delegate void Delegate2(string str);
        
        private Dictionary<int, Delegate> _msgs;
        private Dictionary<int, Delegate2> _msgs2;
        
        /// <summary>
        /// 处理的是msg，也就是原始数据
        /// </summary>
        /// <param name="code">注册的消息的编号</param>
        /// <param name="msg">消息的内容</param>
        public void Receive(int code, byte[] msg)
        {
//            if (code == 400)
//            {
//                var res = LoginRes.Parser.ParseFrom(msg);
//                if (res.Res)
//                {
//                    Listener.Instance.Event(1, res.ToString(), null, null);
//                }
//            }

            //大于20000的消息号被认定为传输的是json字符串

            if (_instance._msgs2.ContainsKey(code))
            {
                if (code > 20000)
                {
                    var str = Encoding.UTF8.GetString(msg);
                    // Global.Log(Encoding.UTF8.GetString(msg));
                    Global.Log("--------------------------");
                    Global.Log(str.Length.ToString());
                    _instance._msgs2[code].Invoke(Encoding.UTF8.GetString(msg));
                }
                return;
            }
            

            if (_instance._msgs.ContainsKey(code))
            {
                _instance._msgs[code].Invoke(msg);
            }
        }
        
        /// <summary>
        /// 注册一个处理pb的消息
        /// </summary>
        /// <param name="code">消息号</param>
        /// <param name="callback">接收到对应的消息号是，执行的函数</param>
        public static void Reg(int code, Delegate callback)
        {
            if (!_instance._msgs.ContainsKey(code))
            {
                _instance._msgs.Add(code, callback);
            }
        }
        
        /// <summary>
        /// 注册一个处理json的消息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="callback"></param>
        public static void Reg2(int code, Delegate2 callback)
        {
            if (!_instance._msgs2.ContainsKey(code))
            {
                _instance._msgs2.Add(code, callback);
            }
        }
        
        private DataCenter()
        {
            
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            _instance = new DataCenter();
            _instance._msgs = new Dictionary<int, Delegate>();
            _instance._msgs2 = new Dictionary<int, Delegate2>();
        }

        public static void InitAll()
        {
            //只有在离线模式下才会使用这里的逻辑
            LuaApi.set_notice_action(NoticeFunction);
            LuaApi.set_update_action(UpdateFunction);
        }

        private static void NoticeFunction(string msg)
        {
            //这个事件要分发给lua吗？

        }

        private static void UpdateFunction(LuaApi.AttrStruct attr)
        {
            //这个与界面的更新息息相关，直接在cs端完成
            //实际上离线模式与在线模式对ui的处理应该是大同小异的
        }
    }
}