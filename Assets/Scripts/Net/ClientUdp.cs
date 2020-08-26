using System.Net;
using System.Net.Sockets;

namespace Net
{
    public class ClientUdp
    {
        private UdpClient _client;

        public ClientUdp()
        {
            _client = new UdpClient();
        }

        private void Read()
        {
            var ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            var socket = new Socket(ip.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            
        }

        public void Send(byte[] bytes)
        {
            
        }
    }
}