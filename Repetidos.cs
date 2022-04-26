using System;

class Repetidos {
	static void Main(string[] args) {
		int aux = 0, repetido = 0;
		int[] numeros = new int[10];

		for(int i=0; i<numeros.Length; i++) {
			numeros[i] = int.Parse(Console.ReadLine());
		}

		for(int i=0; i<numeros.Length; i++) {
			if (numeros[i]!=-1) {
				aux = numeros[i];
				for(int j=0; j<numeros.Length; j++) {
					if (aux==numeros[j]) {
						repetido++;
						numeros[j]=-1;
					}
				}
				if (repetido>1) {
					Console.WriteLine("Numero {0} repetiu {1} vezes.", aux, --repetido);
				}
				repetido = 0;
			}
		}
	}
}
