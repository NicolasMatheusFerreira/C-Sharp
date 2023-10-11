using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Sockets {
    public class Cliente {

        IPEndPoint ipEndPoint;
        public Cliente() {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.15.9"), 6000);

        }

        public bool enviar() {

            try {

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.Connect(ipEndPoint);

                byte[] data = Encoding.ASCII.GetBytes("Ola, mundo!");
                socket.Send(data);

                byte[] buffer = new byte[1024];
                int bytesTam = socket.Receive(buffer);
                string resposta = Encoding.ASCII.GetString(data, 0, bytesTam);
                Console.WriteLine("Resposta ao servidor "+resposta);

                socket.Close();
            } catch(Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
    }
}