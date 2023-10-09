using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Sockets {
	class Cliente {
		
		public static string enderecoIP = "192.168.1.10";

		public Cliente() {
		}
		
		public Cliente(string enderecoIP) {

			enderecoIP = enderecoIP;
		}
		
		public bool enviaArquivo(string caminhoArquivo, string arquivo) {

			try {
				IPEndPoint endIPCliente = new IPEndPoint(IPAddress.Parse(enderecoIP), 5656);
				Socket clienteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

				byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

				if (nomeArquivoByte.Length>5000*1024) {
					Console.WriteLine("Tamanho de arquivo maior que 5mb!");
					return false;
				}
				
				byte[] fileData = File.ReadAllBytes(caminhoArquivo+arquivo);
				byte[] clienteData = new byte[4+nomeArquivoByte.Length+fileData.Length];
				byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

				nomeArquivoLen.CopyTo(clienteData, 0);
				nomeArquivoByte.CopyTo(clienteData, 4);
				fileData.CopyTo(clienteData, 4+nomeArquivoByte.Length);

				clienteSocket.Connect(endIPCliente);
				clienteSocket.Send(clienteData, 0, clienteData.Length, 0);
				clienteSocket.Close();

			} catch(Exception ex) {
				Console.WriteLine(ex);
				return false;
			}
			Console.WriteLine($"Arquivo {caminhoArquivo+arquivo} tranferido!");
			return true;
		}
	}
}
