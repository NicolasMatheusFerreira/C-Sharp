using System;

class Atribuicao1 {
	static void Main(string[] args) {

		string nome = "Nicolas";
		string resultado="";

		int a = 10;
		Console.WriteLine(a);

		a = a + 2;
		Console.WriteLine(a);

		a+= 2;
		Console.WriteLine(a);

		a/= 2;
		Console.WriteLine(a);

		a = a-4;
		Console.WriteLine(a);

		a-= 3;
		Console.WriteLine(a);

		nome += " Matheus Ferreira";
		Console.WriteLine(nome);

		resultado = resultado + nome + " tem 21 anos";
		Console.WriteLine(resultado);
	}
}
