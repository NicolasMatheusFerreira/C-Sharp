using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sockets {
	public class Cliente {
		
		public static IPAddress ipAddress;
		public static IPEndPoint ipEndPoint;

		public Cliente() {

			ipAddress = IPAddress.Parse("192.168.15.8");
			ipEndPoint = new IPEndPoint(ipAddress, 8000);
		}

		public bool conectar() {

			Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			socket.Connect(ipEndPoint);

			byte[] mensagem = Encoding.ASCII.GetBytes("Ola, Mundo");
			socket.Send(mensagem);

			byte[] bytes = new byte[1024];
			int byteSec = socket.Receive(bytes);

			string byteRec = Encoding.ASCII.GetString(bytes);
			Console.WriteLine(byteRec);

			socket.Close();
			return true;
		}


	}
}
