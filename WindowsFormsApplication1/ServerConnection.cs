using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class ServerConnection
    {
        private Socket socket;
        private TextWriter writer;
        private StreamReader incomingData;

        public ServerConnection(String host, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            IPAddress ipAddress = IPAddress.Parse(host);
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            socket.Connect(remoteEP);

            Console.WriteLine("Connected!");
            Console.WriteLine("pop");

            byte[] msg = Encoding.ASCII.GetBytes("GET");

            socket.Send(msg);
        }
    }
}
