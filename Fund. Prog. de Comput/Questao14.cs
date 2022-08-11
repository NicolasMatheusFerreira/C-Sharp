using System;

class Questao14 {
	static void Main(string[] args) {
		
		int anoAtual, anoNascimento;

		Console.Write("Informe o ano atual: ");
		anoAtual = int.Parse(Console.ReadLine());
		Console.Write("Informe o ano de nascimento: ");
		anoNascimento = int.Parse(Console.ReadLine());

		Console.Write("A idade do individuo e igual a {0}", anoAtual-anoNascimento);	
	}
}
