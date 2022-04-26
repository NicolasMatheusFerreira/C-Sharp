using System;

class Questao8 {
	static void Main(string[] args) {
		int[,] numeros = new int[6, 4];
		
		int i = 0, j = 0, qtdNum = 0;
		while(i<6) {
			while(j<4) {
				Console.WriteLine("[{0},{1}]. Informe valor para: ", i, j);
				numeros[i, j] = int.Parse(Console.ReadLine());
//				Console.WriteLine(numeros[i,j]);

				if (numeros[i,j]>30.0) {
					qtdNum = qtdNum + 1;
				}
				j++;
			}
			i++;
			j=0;
		}
		Console.WriteLine("Existem {0} numeros maiores que 30 nesta matriz", qtdNum);
	}
}
