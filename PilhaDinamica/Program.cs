using System;

namespace PilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            Elemento i;
            int opcao; 
            do {
                //Console.Clear();
                Console.WriteLine("(1). Inserir");
                Console.WriteLine("(2). Remover");
                Console.WriteLine("(3). Listar");
                Console.WriteLine("(4). Sair");
                
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.Write("Inserir: ");
                        pilha.Inserir(int.Parse(Console.ReadLine()));
                    break;

                    case 2:
                        i = pilha.Remover();
                    break;

                    case 3:
                        pilha.Listar();
                        Console.ReadKey();
                    break;

                    default: Console.WriteLine("Opcao, invalida!");
                    break;
                }
            } while(opcao!=4);
        }
    }
}
