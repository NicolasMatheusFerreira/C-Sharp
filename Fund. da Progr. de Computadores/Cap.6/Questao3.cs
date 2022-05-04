using System;

class Questao3 {

	static void ExibeArranjo(int[] x) {
	
		for(int a = 0; a<x.Length; a++) {
			Console.Write(" {0}", x[a]);
		}
		Console.WriteLine();
	}

	static void Main(string[] args) {
		
		int icrementador = 0;
		int[] Vetor1 = new int[] {3, 5, 4, 2, 2, 5, 3, 2, 5, 9};
		int[] Vetor2 = new int[] {7, 15, 20, 0, 18, 4, 55, 23, 8, 6};

		int[] Vetor3 = new int[20];

		for(int s = 0; s<20; s+=2) {
			Vetor3[s] = Vetor1[icrementador++];
		}

		icrementador = 0;

		for(int s = 1; s<20; s+=2) {
			Vetor3[s] = Vetor2[icrementador++];
		}

		ExibeArranjo(Vetor3);
	}
}
