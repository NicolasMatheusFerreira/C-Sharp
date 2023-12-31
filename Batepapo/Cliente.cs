using System;
using System.Net;
using System.Net.Sockets;

namespace Batepapo {
    public class Cliente {
        
        private IPAddress ipv4;
        private IPEndPoint ipEndPoint;

        public IPAddress getIP() {

            IPAddress flag = null;
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress x in ip)
                if (x.AddressFamily==AddressFamily.InterNetwork)
                    flag = x;
            return flag;
        }
        public Cliente() {

            ipv4 = getIP();
            ipEndPoint = new IPEndPoint(ipv4, 8000);
        }

        public void conectar() {

            Socket socket = new Socket(ipv4.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Mensagens mensagem = new Mensagens();

            try {
                socket.Connect(ipEndPoint);

                int byteRecebido = 0;
                byte[] buffer = new byte[1024];
                Socket clientSocket = socket;

                while(true) {
                    byteRecebido = clientSocket.Receive(buffer);
                    mensagem.recebido.Push(mensagem.obterString(buffer));
                    Console.WriteLine("Recebido: "+mensagem.recebido.Pop());
                    
                    clientSocket.Send(mensagem.sala());
                }
                clientSocket.Close();
            } catch(Exception ex) {
                Console.WriteLine("Erro ao enviar mensagem {0}", ex);
            }
            Console.WriteLine("Sala de bate papo encerrada!");
        }
    }
}