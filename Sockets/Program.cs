using System;

namespace Sockets {
	class Program {
		static void Main(string[] args) {
			
			Cliente cliente = new Cliente();	
			cliente.enviaArquivo("C:\\Users\\nicol\\desktop\\", "teste.txt");
		}
	}
}
