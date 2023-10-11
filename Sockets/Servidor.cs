using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Sockets {
    public class Servidor {
        IPEndPoint ipEndPoint;
        public Servidor() {

            ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.43.11"), 6000);
        }        

        public void executaServidor() {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(ipEndPoint);
            socket.Listen(10);

            while(true) {
                Console.WriteLine("Aguardando por conexoes...   ");
                Socket clientSocket = socket.Accept();

                byte[] buffer = new byte[1024];
                string dados = null;

                //while(true) {   
                    int numByte = clientSocket.Receive(buffer);
                    dados+= Encoding.ASCII.GetString(buffer, 0, numByte);
                
                    //break;
                //}
                Console.WriteLine(dados);
                byte[] mensagem = Encoding.ASCII.GetBytes("Testando servidor");
                clientSocket.Send(mensagem);
                                
                clientSocket.Close();
            }
        }
    }
}