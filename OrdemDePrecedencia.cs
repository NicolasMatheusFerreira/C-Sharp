using System;

class OrdemDePrecedencia {
	static void Main(string[] args) {
		
		int resultado = 3+4*2;
		Console.WriteLine(resultado);

		// Priorizando opera��o

		resultado = (3+4)*2;
		Console.WriteLine(resultado);

		double a = 10/8; 	
		/* Aqui � feita um truncamento com o dado pois voc� divide inteiro
		 por inteiro o resultado � no minimo um inteiro e voc� atribui em 
		 uma vari�vel racional*/
		Console.WriteLine(a);

		a = (double) 10/8;
		Console.WriteLine(a);
	}
}
