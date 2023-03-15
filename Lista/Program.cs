using System;
using System.Collections.Generic;

namespace Lista {
    class Program {
        static void Main(string[] args) {
            List<double> Valores = new List<double>();
            List<string> Palavras = new List<string>();

            Valores.Add(1.34);
            Valores.Add(2.00);
            Valores.Add(3.50);
            Palavras.Add("Maria");
            Palavras.Add("Marcos");

            foreach (int j in Valores) {
                Console.WriteLine(j);
            }

            foreach (string j in Palavras) {
                Console.WriteLine(j);
            }

            Console.WriteLine("Tamanho da list (Valores): {0}", Valores.Count);
            Console.WriteLine("Tamanho da list (Palavras): {0}", Palavras.Count);
        }
    }
}
