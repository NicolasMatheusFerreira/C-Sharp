using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sockets {
	public class Servidor {

		public static IPAddress ipAddress;
		public static IPEndPoint ipEndPoint;

		public Servidor() {
			ipAddress = IPAddress.Parse("192.168.1.10");
			ipEndPoint = new IPEndPoint(ipAddress, 6000);
		}

		public void executarServidor() {
			
			Socket escutando = new Socket(ipAddress.AddressFamily, SocketType.Dgram, ProtocolType.Udp);

			try {
				escutando.Bind(ipEndPoint);
				escutando.Listen(10);

				while(true) {
					Console.WriteLine("Aguardando conexao");

					Socket clienteSocket = escutando.Accept();

					byte[] bytes = new byte[1024];
					string data = null;

					while(true) {
						int numByte = clienteSocket.Receive(bytes);
						data+=Encoding.ASCII.GetString(bytes, 0, numByte);

						if (data.IndexOf("<EOF>")>-1)
							break;
					}
					Console.WriteLine("Texto recebido {0}", data);
					byte[] mensagem = Encoding.ASCII.GetBytes("Texto recebido!");

					clienteSocket.Send(mensagem);

					clienteSocket.Shutdown(SocketShutdown.Both);
					clienteSocket.Close();
				}
			} catch(Exception ex) {
				Console.WriteLine(ex);
			}
		}
	}
}