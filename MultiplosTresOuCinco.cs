using System;

class MultiplosTresOuCinco {

	static int Multiplos(int x) {
		
		int soma = 0;
		for(int i = x-1; i>=1; i--) {
			if (i%3==0 || i%5==0)
				soma += i;
		}
		return soma;
	}

	static void Main(string[] args) {
		Console.WriteLine(Multiplos(1000));
	}
}
