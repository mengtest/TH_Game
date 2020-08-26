using System;
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
            private UdpClient _client;
            
            public Client()
            {
                _client = new UdpClient();
            }

            public bool IsConnected()
            {
                return _client != null && _client.Client.Connected;
            }

            public async void Connect(string host, int port)
            {
                try
                {
                    await _client.Client.ConnectAsync(host, port);
                }
                catch (Exception)
                {
                    Listener.Instance.Event("cant_connect_server");
                    return;
                }
                OnConnected();
            }
            
            private async void MyRead()
            {
                //最终的整个数据包应该是这样的情况
                //session id 8byte
                //length 8byte
                //type 8byte
                //data 
                var data = await _client.ReceiveAsync();
                byte[] type = new byte[8];
                Buffer.BlockCopy(data.Buffer, 0, type, 0, type.Length);
                byte[] msg = new byte[data.Buffer.Length - 8];
                Buffer.BlockCopy(data.Buffer, 8, msg, 0, msg.Length);
                Core.DataCenter.Instance.Receive(int.Parse(Encoding.UTF8.GetString(type)), msg);
                MyRead();
            }

            private void OnConnected()
            {
                Listener.Instance.Event("connected_with_server");
                var client = _client.Client;
                System.Diagnostics.Debug.Assert(client != null, nameof(client) + " != null");
                if (_client.Client.Connected)
                {
                    MyRead();
                }
            }
            
            /**
             * <summary>
             * 发送protobuf的消息
             * </summary>
             */
            public void Send(int code, IMessage msg)
            {
                var msgBytes =  msg.ToByteArray();
                var type = code.ToString("00000000");
                var bytes = Encoding.UTF8.GetBytes(type);
                var mem = new byte[bytes.Length + msgBytes.Length];
                Buffer.BlockCopy(bytes, 0, mem, 0, bytes.Length);
                Buffer.BlockCopy(msgBytes, 0, mem, bytes.Length, msgBytes.Length);
//                _client.GetStream().Write(mem, 0, mem.Length);
                _client.SendAsync(mem, mem.Length);
            }

            /**
             * <summary>
             * 发送非protobuf的消息
             * </summary>
             */
            public void Send(int code, string msg)
            {
                var type = code.ToString("00000000");
                var typeBytes = Encoding.UTF8.GetBytes(type);
                var bytes = Encoding.UTF8.GetBytes(msg);
                var mem = new byte[typeBytes.Length + bytes.Length];
                Buffer.BlockCopy(typeBytes, 0, mem, 0, typeBytes.Length);
                Buffer.BlockCopy(bytes, 0, mem, typeBytes.Length, bytes.Length);
//                _client.GetStream().Write(mem, 0, mem.Length);
                _client.Send(mem, mem.Length);
            }

            private void Destroy()
            {
                _client.Close();
                _client.Dispose();
            }
        }
    }
}