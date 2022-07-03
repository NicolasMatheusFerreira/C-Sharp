using System;

class FatorPrimo {

	static int CalculaFatorPrimo(long num) {
	
		long soma;
		int maior = 0;
		for(int i = 2; i<=num; i++) {
			soma = 0;
			for(int j = 1; j<=i; j++) {
				if (i%j==0)
					soma++;
			}

			if (soma==2)
				if (num%i==0) {
			//		Console.Write("{0} ", i);
					if (i>maior)
						maior = i;
				}
		}
		return maior;
	}

	static void Main(string[] args) {

		int resultado = CalculaFatorPrimo(long.Parse(Console.ReadLine()));		
		Console.WriteLine("O maior fator primo e "+resultado);
	}
}
