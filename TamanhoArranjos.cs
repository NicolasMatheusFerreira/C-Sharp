using System;

class Arranjos {
	static void Main(string[] args) {
		int[] Vetor = new int[10];
		int[,] Matriz = new int[10,10];

		Console.WriteLine(Vetor.Length+" Posicoes");
		Console.WriteLine(Matriz.Length+" Posicoes");

		Console.WriteLine(sizeof(int)*Matriz.Length+" Bytes");
	}
}
