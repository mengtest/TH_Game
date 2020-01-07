using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Google.Protobuf;
using Lib;
using UnityEngine;
using Util;
using XLua;

namespace Net
{
    [LuaCallCSharp]
    //与服务器连接，并传输与接收数据
    partial class NetHelper
    {
        partial class Client
        {
            private byte[] _buf;
            private static TcpClient _client;
            
            public Client(string host, int port)
            {
                _buf = new byte[1024];
                _client = new TcpClient();
                _client.BeginConnect(IPAddress.Parse(host), port, OnConnected, _client);
            }

            private void OnConnected(IAsyncResult ar)
            {
                Listener.Instance.Event("connected_with_server");
                var client = ar.AsyncState as TcpClient;
                System.Diagnostics.Debug.Assert(client != null, nameof(client) + " != null");
                if (client.Connected)
                {
                    client.EndConnect(ar);
                    //不太明白为什么C#设计成在这里就读出了数据
                    client.GetStream().BeginRead(_buf, 0, 1024, OnRead2, client.GetStream());
                }
            }
            
            private void OnRead2(IAsyncResult ar)
            {
                var stream = ar.AsyncState as NetworkStream;
                stream.EndRead(ar);
                //取出
                int count = _buf.TakeWhile(b => b != 0).Count();
                byte[] buffer = new byte[count];
                Buffer.BlockCopy(_buf, 0, buffer, 0, buffer.Length);
                stream.BeginRead(_buf, 0, 1024, OnRead2, stream);
                Core.DataCenter.Instance.Receive(Msg.Parser.ParseFrom(buffer));
            }
            
            //这个是普通的byte数组的解析，主要还是要获取到数组的长度
            private void OnRead(IAsyncResult ar)
            {
                var stream = ar.AsyncState as NetworkStream;
                System.Diagnostics.Debug.Assert(stream != null, nameof(stream) + " != null");
                var str = Encoding.UTF8.GetString(_buf);
                char[] usageBuf = new char[15];
                Buffer.BlockCopy(str.ToCharArray(), 0, usageBuf, 0, 15);
                stream.EndRead(ar);
//                var str = Encoding.UTF8.GetString(usageBuf);
//                str = str.Trim();
//                LoginMsg msg = new LoginMsg();
//                msg.Code = 1000;
//                msg.Msg = "hello world";
//                var bytes = msg.ToByteString();
//                var s = msg.ToString();
//                var data = LoginMsg.Parser.ParseFrom(Encoding.UTF8.GetBytes(usageBuf));
                //                var byteStr = ByteString.CopyFromUtf8(str);
//                var msg = LoginMsg.Parser.ParseFrom(byteStr);
//                var msg = new LoginMsg();
                //进入到循环当中
                var res = stream.BeginRead(_buf, 0, 1024, OnRead, stream);
            }

            public void OnRead()
            {
                
            }

            //这个是读取json的版本
//            private void OnRead(IAsyncResult ar)
//            {
//                var stream = ar.AsyncState as NetworkStream;
//                System.Diagnostics.Debug.Assert(stream != null, nameof(stream) + " != null");
////                var buf = new byte[1024];
////                var size = stream.Read(buf, 0, 1024);
//                byte[] usageBuf = new byte[38];
//                Buffer.BlockCopy(_buf, 0, usageBuf, 0, 38);
//                stream.EndRead(ar);
//                Debug.Log(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff:ffffff"));
//                var str = Encoding.UTF8.GetString(usageBuf);
////                str = str.Trim();
//                LoginMsg msg = new LoginMsg();
//                msg.Code = 1000;
//                msg.Msg = "hello world";
//                var bytes = msg.ToByteString();
//                var s = msg.ToString();
//                var data = LoginMsg.Parser.ParseJson(str);
////                var byteStr = ByteString.CopyFromUtf8(str);
////                var msg = LoginMsg.Parser.ParseFrom(byteStr);
////                var msg = new LoginMsg();
//                //进入到循环当中
//                stream.BeginRead(_buf, 0, 1024, OnRead, stream);
//            }
            
            //向服务器发送消息
            public void Send(byte[] msg)
            {
//                var buffer = System.Text.Encoding.UTF8.GetBytes();
//                var buffer = msg.ToByteArray();
                _client.GetStream().BeginWrite(msg, 0, msg.Length, OnSend,
                    _client.GetStream());
            }

            private void OnSend(IAsyncResult ar)
            {
                var stream = ar as NetworkStream;
                //消息发送完毕，不会进入循环，而是等到用户触发某个事件再发送消息
                System.Diagnostics.Debug.Assert(stream != null, nameof(stream) + " != null");
                stream.EndWrite(ar);
            }

            private void Destroy()
            {
                Debug.Log("Destroy");
                _client.Close();
                _client.Dispose();
            }
        }
    }
}