using System;

class Saida {
	static void Main(string[] args) {
		
		int idade = 34;
		double saldo = 4.32;
		string nome = "Nicolas";

		Console.Write(nome);
		Console.Write(" tem ");
		Console.Write(idade);
		Console.Write(" anos.");

		// Placeholder
		Console.WriteLine("{0} tem {1} anos e com o saldo de {2:F2} reais.", nome, idade, saldo);
		// Interpolação
		Console.WriteLine($"{nome} tem {idade} anos e com o saldo de {saldo} reais.");
		// Concatenação de strings
		Console.WriteLine(nome+" tem "+idade+" anos e com o saldo de "+saldo+" reais.");
	}
}
