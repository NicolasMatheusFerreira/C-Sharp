using System;

class Questao6 {
	static void Main(string[] args) {
		double[] numeros = new double[10];

		for(int i = 0; i<numeros.Length; i++) { // Entrada de valores
			Console.WriteLine("Informe um valor: ");
			numeros[i] = double.Parse(Console.ReadLine());			
		}

		double aux=0; // Ordenação por método da bolha
		for(int i=0; i<numeros.Length; i++) {
			for(int j=0; j<numeros.Length-1; j++) {
				if (numeros[j]>numeros[j+1]) {
					aux = numeros[j];
					numeros[j] = numeros[j+1];
					numeros[j+1] = aux;
				}
			}
		}

		int cont = 0; // Saída de valores
		while(cont!=numeros.Length) {
			Console.Write(" "+numeros[cont]);
			cont = cont + 1;
		}
		Console.WriteLine();
	}
}
