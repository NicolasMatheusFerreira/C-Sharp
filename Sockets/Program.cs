using System;
using System.Net;
using System.Net.Sockets;

namespace Sockets {
    class Program {
        static void Main(string[] args) {
            //Servidor servidor = new Servidor("192.168.15.9", 8000);
            //servidor.executar();

            Cliente cliente = null;
            Console.Write("Informe IP de destino: ");
            Cliente.ipv4 = IPAddress.Parse(Console.ReadLine());
            Console.Write("Informe porta de destino: ");
            Cliente.porta = int.Parse(Console.ReadLine());
            Console.Write("Informe mensagem: ");
            Cliente.mensagem = Console.ReadLine();

            cliente = new Cliente(Cliente.ipv4, Cliente.porta, Cliente.mensagem);
            cliente.conectar();
        }
    }
}