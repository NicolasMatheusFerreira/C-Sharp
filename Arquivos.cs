using System;
using System.IO;

class Arquivos {
	
	static void GravarArquivo(string caminho, string nomeArquivo, string nome, string endereco) {
			
		string source = caminho+nomeArquivo;

		try {
			StreamWriter arquivo = new StreamWriter(source, true);
		
			arquivo.WriteLine(nome);
			arquivo.WriteLine(endereco);
			arquivo.WriteLine();

			arquivo.Close();		
		} catch(Exception ex) {
			Console.WriteLine("\aErro!");
		}
	}

	static void CadastraClientes() {
		
		string nome, endereco;
		int codig = 0;
		char continuar = 's';
		
		Console.WriteLine("Cadastro de clientes \n");
		
		do {
			Console.WriteLine("Cliente {0}", ++codig);
			Console.Write("Informe nome: ");
			nome = Console.ReadLine();
			Console.Write("Informe endereco: ");
			endereco = Console.ReadLine();
			
			GravarArquivo(@"", "Clientes.dat", nome, endereco);

			Console.Write("(S) - Para continuar ou (N) - Para sair: ");
			continuar = char.ToUpper(Console.ReadKey().KeyChar);
		} while(continuar=='S');
	
	}

	static void Main(string[] args) {
		
		CadastraClientes();
		Console.WriteLine("\aFim!");
	}
}
