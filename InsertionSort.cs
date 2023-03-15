using System;

class InsertionSort {

	static void Swp(int[] Valores, int a, int b) {
		
		int aux = Valores[a];
		Valores[a] = Valores[b];
		Valores[b] = aux;
	}

	static int[] Sort(int[] Valores) {
	
		int menor, menorP = 0;
		for(int k = 0; k<Valores.Length; k++) {
			menor = Valores[k];
			for(int j = k; j<Valores.Length-1; j++) {
				if (Valores[j]<menor) {
					menor = Valores[j];					
					menorP = j;
				}
			}
			Swp(Valores, k, menorP);
		}
		return Valores;
	}

	static void Main(string[] args) {
		
		int cont;
		Random aleatorio = new Random();
		int[] Valores = new int[10];

		Console.WriteLine("Entrada");

		cont = 0;
		while(cont<10) {
			Valores[cont++] = aleatorio.Next(0,50);
			Console.Write($"{Valores[cont-1]} ");
		}		

		Console.WriteLine();

		Valores = Sort(Valores);

		cont = 0;
		while(cont<10) {
			Console.Write($"{Valores[cont++]} ");		
		}
	}
}
