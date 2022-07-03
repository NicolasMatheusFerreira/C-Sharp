using System;

class Questao17 {
	static void Main(string[] args) {
		
		float salario, retirada1, retirada2, cpmf1, cpmf2;		

		Console.Write("Informe o salario do func.: ");
		salario = float.Parse(Console.ReadLine());

		Console.Write("Operacao 1. Informe a quantidade que deseja retirar: ");
		retirada1 = float.Parse(Console.ReadLine());
		
		Console.Write("Operacao 2. Informe a quantidade que deseja retirar: ");
		retirada2 = float.Parse(Console.ReadLine());

		cpmf1 = 0.38f/100*retirada1;
		cpmf2 = 0.38f/100*retirada2;

		salario = salario-retirada1-retirada2-cpmf1-cpmf2;

		Console.WriteLine("Seu salario apos a emissao dos cheques e {0:0.00}", salario);
	}
}
