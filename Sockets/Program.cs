﻿using System;

namespace Sockets {
	class Program {
		static void Main(string[] args) {
			
//			Cliente cliente = new Cliente();
//			Console.WriteLine(cliente.conectar());

			Servidor servidor = new Servidor();
			servidor.executaServidor();
		}
	}
}
