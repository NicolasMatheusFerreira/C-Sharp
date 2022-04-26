using System;
using System.IO;

class Arquivos {
	static void Main(string[] args) {	

				
		const string nome_arquivo = "Registro.txt";
		const string caminho = @"C:\users\nicol\desktop\"+nome_arquivo;

		StreamWriter escrita = new StreamWriter(caminho);
		string texto;

		try {
			escrita.Write("Olá, Mundo!");

			escrita.Close();

			StreamReader leitura = new StreamReader(@"C:\users\nicol\desktop\registro.txt");
			texto = leitura.ReadLine();
			leitura.Close();

			Console.WriteLine(texto);
		} catch (Exception ex) {
			Console.WriteLine("\aErro!");
		}
	}
}
