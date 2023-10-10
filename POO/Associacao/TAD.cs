using System;
using System.IO;

public class TAD {
	
	public static void ImportarDados(Lutador[] lutador, string caminho, string nomeArquivo) {
		
		StreamReader arquivo = new StreamReader(caminho+nomeArquivo);

		if (File.Exists(caminho+nomeArquivo)) {
			for(int j = 0; j<lutador.Length; j++) {

				lutador[j].setNome(arquivo.ReadLine());	
				lutador[j].setNacional(arquivo.ReadLine());
				lutador[j].setIdade(int.Parse(arquivo.ReadLine()));
				lutador[j].setAltura(double.Parse(arquivo.ReadLine()));
				lutador[j].setPeso(double.Parse(arquivo.ReadLine()));
				lutador[j].setCategoria();
				lutador[j].setVitorias(int.Parse(arquivo.ReadLine()));
				lutador[j].setDerrotas(int.Parse(arquivo.ReadLine()));
				lutador[j].setEmpates(int.Parse(arquivo.ReadLine()));	
				arquivo.ReadLine();				
				arquivo.ReadLine();
			}
		} else {
			Console.WriteLine("Arquivo nao encontrado!");
		}
	}

	public static void ExportarDados(Lutador[] lutador, string caminho, string nomeArquivo, bool permissao) {
		
		StreamWriter arquivo = new StreamWriter(caminho+nomeArquivo, permissao);
				
		for(int h = 0; h<lutador.Length; h++) {
			arquivo.WriteLine(lutador[h].getNome());
			arquivo.WriteLine(lutador[h].getNacional());
			arquivo.WriteLine(lutador[h].getIdade());
			arquivo.WriteLine(lutador[h].getAltura());
			arquivo.WriteLine(lutador[h].getPeso());
			arquivo.WriteLine(lutador[h].getVitorias());
			arquivo.WriteLine(lutador[h].getDerrotas());
			arquivo.WriteLine(lutador[h].getEmpates());
			arquivo.Write("\n\n");
		}
		arquivo.Close();
	}

	public static void Listar(Lutador[] lutador) {
	
		for(int e = 0; e<lutador.Length; e++)	
			Console.WriteLine($"|{lutador[e].getNome()}, {lutador[e].getNacional()}, {lutador[e].getIdade()}, {lutador[e].getAltura()}, {lutador[e].getPeso()}, {lutador[e].getCategoria()}, {lutador[e].getVitorias()}, {lutador[e].getDerrotas()}, {lutador[e].getEmpates()}|\n");
	}

	public static void executa() {

		const string caminho = @"C:\Users\nicol\Desktop\";
		const string arquivo = "bd_lutadores.txt";

		Lutador[] lutador = new Lutador[10];
	
		for(int i = 0; i<lutador.Length; i++)
			lutador[i] = new Lutador();	
	
		
//		ExportarDados(lutador, caminho, arquivo, true);
		ImportarDados(lutador, caminho, arquivo);

		Luta luta = new Luta(lutador[0], lutador[1]);
		luta.marcarLuta();
		luta.lutar();
	}
}