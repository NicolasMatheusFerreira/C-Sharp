using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Sockets {
	public class Cliente {

		public static IPAddress ipAddress; // Objeto para armazenar o endereço IP
		public static IPEndPoint ipEndPoint;// Objeto para atrelar o endereço de IP a porta da conexão	

		public Cliente() {

			ipAddress = IPAddress.Parse("192.168.1.11");
			ipEndPoint = new IPEndPoint(ipAddress, 6000);
		}
		
		public bool iniciarConexao() {

			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

			try {
				socket.Connect(ipEndPoint);
				Console.WriteLine($"{socket.RemoteEndPoint.ToString()}");

				byte[] mensagem = Encoding.ASCII.GetBytes("Ola, Mundo!!!"); // Criando a mensagem
				int byteEnviar = socket.Send(mensagem); // Enviando mensagem para o servidor

				byte[] mensagemRecebida = new byte[1024];
				int byteRecebido = socket.Receive(mensagemRecebida);
				Console.WriteLine($"Mensagem de servidor {Encoding.ASCII.GetString(mensagemRecebida, 0, byteRecebido)}");
				
				socket.Shutdown(SocketShutdown.Both);
				socket.Close();
				
				return true;
			} catch(Exception ex) {
				Console.WriteLine(ex);
				return false;
			}
		
		}
	}
}
