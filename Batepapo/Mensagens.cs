using System;
using System.Text;
using System.Collections.Generic;

namespace Batepapo {
    public class Mensagens {
        
        public Stack<string> recebido = new Stack<string>();
        private string mensagem;
        public Mensagens() {
            this.Mensagem = "Ola, mundo!";
        }

        // Setters e gettes
        public string Mensagem { 
            get; set; 
        }

        public byte[] obterBytes(string x) {
            byte[] buffer = new byte[1024];
            buffer = Encoding.ASCII.GetBytes(x);
            return buffer;
        }

        public string obterString(byte[] x) {
            string buffer = null;
            buffer = Encoding.ASCII.GetString(x);
            return buffer;
        }

        public byte[] sala() {
            Console.Write("Voce: ");
            Mensagem = Console.ReadLine();
            return obterBytes(Mensagem);
        }
    }
}