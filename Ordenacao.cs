using System;

class Ordenacao {
	
	void Imprime(string[] Vetor) {
	
		for(int i = 0; i<Vetor.Length; i++)
			Console.WriteLine(Vetor[i]);
	}

	void BubbleSort(string[] Vetor) {
	
		string aux="";
		for(int i = 0; i<Vetor.Length/2; i++) {
			for(int j = 0; j<Vetor.Length-1; j++) {
				if (Vetor[j].CompareTo(Vetor[j+1])>0) {
					aux = Vetor[j];
					Vetor[j] = Vetor[j+1];
					Vetor[j+1] = aux;		
				}
			}
		}
	}

	static void Main(string[] args) {
		
		Ordenacao ordenacao = new Ordenacao();
		string[] Nomes = new string[10];

		for(int i = 0; i<Nomes.Length; i++) {
			Console.Write("{0} Informe nome: ", i+1);
			Nomes[i] = Console.ReadLine();
		}
		ordenacao.Imprime(Nomes);	
		ordenacao.BubbleSort(Nomes);
		Console.WriteLine();
		ordenacao.Imprime(Nomes);
	}
}
