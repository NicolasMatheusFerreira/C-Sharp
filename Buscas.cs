using System;

class Buscas {

	static int BuscaSeqRecursiva(string[] nomes, string nome, int x) {
	
		int posic = 0;
		if (x<nomes.Length) {
			if (nomes[x].Equals(nome)) {
				return 1;
			} else posic += BuscaSeqRecursiva(nomes, nome, ++x);
			return posic;
		} else return -1;
	}

	static int BuscaSeqIterativa(string[] nomes, string nome) {
		
		int i = 0;
		while(i<nomes.Length) {
			if (nomes[i].Equals(nome)) {
				return i;
			} else i++;
		}
		return -1;
	}

	static void Main(string[] args) {
		
		string[] x = new string[6]{"Anabel", "Davi", "Devid", "Paulo", "Gabriel", "Ana"};	
		
		Console.Write(x[BuscaSeqRecursiva(x, "Davi", 0)]);
	}
}
