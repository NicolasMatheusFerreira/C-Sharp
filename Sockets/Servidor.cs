using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sockets {
    public class Servidor {

        private static IPEndPoint ipEndPoint;
        private static IPAddress ipv4;
        private static int porta;
        

        public IPAddress Ipv4 {
            get; set;
        }
        public int Porta {
            get; set;
        }
        public Servidor() {
        }

        public Servidor(string ipv4, int porta) {

            this.Ipv4 = IPAddress.Parse(ipv4);
            this.Porta = porta;

            ipEndPoint = new IPEndPoint(Ipv4, porta);
        }
    
        public void executar() {

            Socket socket = new Socket(Ipv4.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try {
                socket.Bind(ipEndPoint);
                socket.Listen(10);

                Socket clienteSocket = null;
                bool continuar = true;
                while(continuar) {
                    Console.WriteLine("Servidor sendo executado!");
                    clienteSocket = socket.Accept();

                    byte[] buffer = new byte[1024];
                    clienteSocket.Receive(buffer);
                    string mensagemRecebida = Encoding.ASCII.GetString(buffer);
                    Console.WriteLine("Mensagem recebida: "+mensagemRecebida);

                    clienteSocket.Send(BitConverter.GetBytes(200));
                }

                Console.WriteLine("Servidor desconectado!");
                clienteSocket.Close();
            } catch(Exception ex) {
                Console.WriteLine("Erro ao iniciar o servidor. "+ex);
            }
        }
    }
}