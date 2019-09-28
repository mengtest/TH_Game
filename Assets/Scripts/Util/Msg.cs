using System;
using System.Linq;
using Game.Entity.Card;
using Google.Protobuf;
using Newtonsoft.Json;

namespace Util
{
    public class Msg
    {
        //消息的类型id
        //以后会给出详细文档
        private int _id;
        //消息的具体信息，由protobuf序列化而来
        private string _msg;

        public Msg(int id, IMessage message)
        {
            _id = id;
            _msg = message.ToString();
        }

        private Msg()
        {
            
        }

        public int GetId()
        {
            return _id;
        }

        public string GetMsg()
        {
            return _msg;
        }

        public override string ToString()
        {
            //直接将这个对象转成id与msg之间的键值对，这样可以直接做切割
            return Convert.ToString(_id) + ":" + _msg;
        }

        public static Msg FromString(string str)
        {
            Msg msg = new Msg();
            char[] sep = {':'};
            string[] res = str.Split(sep, 2);
            if (res.Length == 2)
            {
                msg._id = Int32.Parse(res[0]);
                msg._msg = res[1];
            }
            else
            {
                throw new Exception("数据包接收出现错误");
            }
            return msg;
        }
    }
}