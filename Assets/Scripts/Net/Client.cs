﻿using System;
using System.Net;
using System.Net.Sockets;
using Google.Protobuf;
using UnityEngine;

namespace Net
{
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
                var client = ar.AsyncState as TcpClient;
                System.Diagnostics.Debug.Assert(client != null, nameof(client) + " != null");
                if (client.Connected)
                {
                    client.EndConnect(ar);
                    //不太明白为什么C#设计成在这里就读出了数据
                    client.GetStream().BeginRead(_buf, 0, 1024, OnRead, client.GetStream());
                }
            }

            private void OnRead(IAsyncResult ar)
            {
                var stream = ar.AsyncState as NetworkStream;
                System.Diagnostics.Debug.Assert(stream != null, nameof(stream) + " != null");
                stream.EndRead(ar);
                Debug.Log(_buf);
                Debug.Log(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff:ffffff"));
                //将取得的数据转成对象，然后交给NetHelper处理
                
                //进入到循环当中
                stream.BeginRead(_buf, 0, 1024, OnRead, stream);
            }
            
            //向服务器发送消息
            public void Send(Util.Msg msg)
            {
                var buffer = System.Text.Encoding.UTF8.GetBytes(msg.ToString());
                _client.GetStream().BeginWrite(buffer, 0, buffer.Length, OnSend,
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