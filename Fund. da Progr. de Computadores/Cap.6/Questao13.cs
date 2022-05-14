using System;

class Questao13 {
	static void Main(string[] args) {
		int[] x = new int[10];
		bool contem = false;

		for(int j=0; j<x.Length; j++) { // Leitura
			x[j] = int.Parse(Console.ReadLine());
		}

		for(int m=0; m<x.Length; m++)
			if (x[m]>50) {
				Console.WriteLine(x[m]+" - Posic.: {0}", m);
				contem = true;
			}
		if (contem==false)
			Console.WriteLine("\aNao a numeros superiores a 50 no vetor.");
	}
}	
