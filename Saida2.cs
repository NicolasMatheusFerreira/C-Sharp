using System;

class Saida2 {
	static void Main(string[] args) {

		string produto1 = "Caneta";
		string produto2 = "Caderno";
	
		byte idade = 30;
		int codigo = 5904;
		char genero = 'M';

		double prec1 = 2100.0;
		double prec2 = 650.32;
		double medida = 53.65462146;

		Console.WriteLine("Produtos");
		Console.WriteLine($"{produto1}, cujo preco e $ {prec1} reais"); // M�todo da interpola��o
		Console.WriteLine(produto2+" cujo o preco e igual a "+prec2+" reais. \n\n"); // M�todo da contatena��o
		Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}\n", idade, codigo, genero); // M�todo do placeholder
		Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
		Console.WriteLine("Medida com quatro casas decimais: {0:F4}", medida);
		Console.WriteLine("Medida com duas casas decimais: {0:F2}", medida);
		Console.WriteLine("Medida com zero casas decimais: {0:0}", medida);
	}
}
