using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sockets {
	public class Servidor {
		
		public static IPAddress ipAddress;
		public static IPEndPoint ipEndPoint;

		public Servidor() {
			
			ipAddress = IPAddress.Parse("192.168.15.9");
			ipEndPoint = new IPEndPoint(ipAddress, 8000);
		}

		public void executaServidor() {
			
			Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			socket.Bind(ipEndPoint);

			socket.Listen(10);

			Console.WriteLine("Aguardando conexao");
			socket.Accept();

			string data = null;
			byte[] bytes = new byte[1024];
			int bytesRec = socket.Receive(bytes);
			data+= Encoding.ASCII.GetString(bytes);

			Console.WriteLine("Texto recebido "+data);

			Socket hand = socket;
			byte[] msg = Encoding.ASCII.GetBytes("Servidor respondido!");
			socket.Send(msg);
			socket.Close();
		}
	}
}
