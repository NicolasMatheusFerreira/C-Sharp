using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sockets {
    public class Cliente {
        private static IPEndPoint ipEndPoint;
        public static IPAddress ipv4;
        public static int porta;
        public static string mensagem;

        public IPAddress Ipv4 {
            get; set;
        }
        public int Porta {
            get; set;
        }
        public string Mensagem {
            get; set;
        }
        public Cliente() {
        }

        public Cliente(IPAddress ipv4, int porta, string mensagem) {

            this.Ipv4 = ipv4;
            this.Porta = porta;
            this.Mensagem = mensagem;

            ipEndPoint = new IPEndPoint(Ipv4, porta);
        }
    
        public int Status(Socket socket, byte[] buffer) {

            int byteRecebido = socket.Receive(buffer);
            return BitConverter.ToInt32(buffer);
        }
        public void conectar() {

            Socket socket = new Socket(Ipv4.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            
            try {
                socket.Connect(ipEndPoint);

                byte[] buffer = new byte[1024];
                buffer = Encoding.ASCII.GetBytes(Mensagem);
                socket.Send(buffer);

                if (Status(socket, buffer)==200)
                    Console.WriteLine("Mensagem enviada com sucesso!");

                socket.Close();
            } catch(Exception ex) {
                Console.WriteLine("Falha ao tentar conectar!\n"+ex);
            }
        }
    }
}