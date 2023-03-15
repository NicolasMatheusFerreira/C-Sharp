using System;

class SomaSimetrica {

	int Soma(int[,] mat) {

		int soma = 0;
		int i, j;

		for(i = 0; i<mat.GetLength(0); i++) {
			for(j = 0; j<i; j++) {
				soma = soma + mat[i,j]*2;
			}
			soma += mat[i,j];
		}	
		return soma;	
	}

	static void Main(string[] args) {
		
		SomaSimetrica simetrica = new SomaSimetrica();

		int resultado = simetrica.Soma(new int[,] {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}});
		Console.WriteLine("O resultado da soma e igual a {0}", resultado);
	}
}
