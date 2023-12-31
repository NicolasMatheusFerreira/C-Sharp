using System;
using System.Net;
using System.Net.Sockets;

namespace Batepapo {
    public class Servidor {
        
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
        public Servidor() {

            ipv4 = getIP();
            ipEndPoint = new IPEndPoint(ipv4, 8000);
            Console.WriteLine("Conexao realizada pelo IP: {0}",ipv4);
        }

        public void executar() {

            Socket socket = new Socket(ipv4.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Mensagens mensagem = new Mensagens();

            try {
                socket.Bind(ipEndPoint);
                socket.Listen(10);                

                int byteRecebido = 0;
                byte[] buffer = new byte[1024];
                Socket clientSocket = socket.Accept();

                bool flag = true;
                while(flag) {
                    byteRecebido = clientSocket.Receive(buffer);
                    mensagem.recebido.Push(mensagem.obterString(buffer));
                    Console.WriteLine("Recebido: "+mensagem.recebido.Pop());
                    
                    clientSocket.Send(mensagem.sala());
                }
                clientSocket.Close();
            } catch(Exception ex) {
                Console.WriteLine("Erro ao executar servidor {0}", ex);
            }
            Console.WriteLine("Sala de bate papo encerrada!");
        }
    }
}