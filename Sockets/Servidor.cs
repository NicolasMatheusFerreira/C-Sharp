using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Sockets {
	class Servidor {

		public static IPEndPoint IPEndServidor;
		public static Socket socketServidor;
		public static string enderecoIP = "192.168.1.11"; 
		public static string mensagemServidor = "Servidor encerrado!";
		public static string caminhoRecepcaoArquivos = "C:\\";

		public Servidor() {
		
		}
		
		public void iniciarServidor() {
			try {
				IPEndServidor = new IPEndPoint(IPAddress.Parse(enderecoIP), 5656);
				socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
				socketServidor.Bind(IPEndServidor);
	
			} catch(Exception ex) {
				mensagemServidor = "Servidor encerrado "+ex;
				Console.WriteLine(mensagemServidor);
				return;
			}

			try {
				socketServidor.Listen(100);
				Socket clienteSock = socketServidor.Accept();
				clienteSock.ReceiveBufferSize = 16384;

				byte[] dadosCliente = new byte[1024*50000];

				int tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
				int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
				string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

				BinaryWriter bWrite = new BinaryWriter(File.Open(caminhoRecepcaoArquivos+nomeArquivo, FileMode.Append));
				bWrite.Write(dadosCliente, 4+tamanhoNomeArquivo, tamanhoBytesRecebidos-4-tamanhoNomeArquivo);

				while (tamanhoBytesRecebidos>0) {
					tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
					if (tamanhoBytesRecebidos==0)
						bWrite.Close();
					else bWrite.Write(dadosCliente, 0, tamanhoBytesRecebidos);
				}
				bWrite.Close();
				clienteSock.Close();

				mensagemServidor = "Arquivo recebido  e arquivado ["+caminhoRecepcaoArquivos+nomeArquivo+"]";
			} catch(Exception ex) {
				Console.WriteLine("Erro ao receber arquivo");
			}
		}
	}
}
