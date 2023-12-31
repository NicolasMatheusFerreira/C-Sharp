using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace NetworkInformation {
    public class Program {
        static void Main(string[] args) {

            string nomeHost = Dns.GetHostName();
            Console.WriteLine(nomeHost);
            IPAddress[] enderecos = Dns.GetHostAddresses(nomeHost);

            foreach(IPAddress ip in enderecos) {
		
                if (ip.AddressFamily==AddressFamily.InterNetwork)
                    Console.WriteLine(ip);
            }
        }
    }
}
