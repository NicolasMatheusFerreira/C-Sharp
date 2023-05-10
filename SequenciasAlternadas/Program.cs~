using System;

namespace SequenciasAlternadas
{
    class Program
    {
	static void OrdenaDecrescente(int[,] vet, int s) {
		
		for(int i = 0; i<vet.GetLength(1); i++)
			for(int j = i+1; j<vet.GetLength(1); j++)
				if (vet[s,j]>vet[s,i]) {
					int aux = vet[s,i];
					vet[s,i] = vet[s,j];
					vet[s,j] = aux;
				}
	}

	static void OrdenaCrescente(int[,] vet, int s) {
		
		for(int i = 0; i<vet.GetLength(1); i++)
			for(int j = i+1; j<vet.GetLength(1); j++)
				if (vet[s,j]<vet[s,i]) {
					int aux = vet[s,i];
					vet[s,i] = vet[s,j];
					vet[s,j] = aux;
				}
	}

	static void Sequencia(int[,] mat) {
		
		for(int i = 0; i<mat.GetLength(0); i++)
			if (i%2==0) {
				// Ordena crescente
				OrdenaCrescente(mat, i);
			} else {
				// Ordena decrescente
				OrdenaDecrescente(mat,i);
			}
				
	}

	static void Leitura(int[,] mat) {
		
		for(int i = 0; i<mat.GetLength(0); i++)
			for(int j = 0; j<mat.GetLength(1); j++)
				mat[i,j] = int.Parse(Console.ReadLine());
	}
  
	static void Print(int[,] mat) {
		
		for(int i = 0; i<mat.GetLength(0); i++) {
			for(int j = 0; j<mat.GetLength(1); j++)
				Console.Write($"{mat[i,j]} ");
			Console.WriteLine();			
		}
	}

        static void Main(string[] args)
        {
		int n;

         	Console.Write("Informe N: ");
		n = int.Parse(Console.ReadLine());

		int[,] matriz = new int[n,5];

		Leitura(matriz);

		Sequencia(matriz);

		Print(matriz);
        }
    }
}
