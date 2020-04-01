using System;
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
            private TcpClient _client;
            
            public Client()
            {
                _buf = new byte[1024 * 10];
                _client = new TcpClient();
            }

            public bool IsConnected()
            {
                return _client == null || _client.Connected;
            }

            public async void Connect(string host, int port)
            {
                try
                {
                    await _client.ConnectAsync(host, port);
                }
                catch (Exception e)
                {
                    Listener.Instance.Event("cant_connect_server");
                    return;
                }
                OnConnected();
            }
            
            private async void MyRead()
            {
                var count = await _client.GetStream().ReadAsync(_buf, 0, _buf.Length);
                byte[] type = new byte[8];
                Buffer.BlockCopy(_buf, 0, type, 0, type.Length);
                byte[] msg = new byte[count - 8];
                Buffer.BlockCopy(_buf, 8, msg, 0, msg.Length);
                Core.DataCenter.Instance.Receive(int.Parse(Encoding.UTF8.GetString(type)), msg);
                MyRead();
            }

            private void OnConnected()
            {
                Listener.Instance.Event("connected_with_server");
                var client = _client.GetStream();
                System.Diagnostics.Debug.Assert(client != null, nameof(client) + " != null");
                if (_client.Connected)
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
                _client.GetStream().Write(mem, 0, mem.Length);
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
                _client.GetStream().Write(mem, 0, mem.Length);
            }

            private void Destroy()
            {
                _client.Close();
                _client.Dispose();
            }
        }
    }
}