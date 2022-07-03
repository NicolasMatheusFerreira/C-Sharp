using System;

class OrdemDePrecedencia {
	static void Main(string[] args) {
		
		int resultado = 3+4*2;
		Console.WriteLine(resultado);

		// Priorizando operação

		resultado = (3+4)*2;
		Console.WriteLine(resultado);

		double a = 10/8; 	
		/* Aqui é feita um truncamento com o dado pois você divide inteiro
		 por inteiro o resultado é no minimo um inteiro e você atribui em 
		 uma variável racional*/
		Console.WriteLine(a);

		a = (double) 10/8;
		Console.WriteLine(a);
	}
}
