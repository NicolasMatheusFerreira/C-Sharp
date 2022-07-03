using System;

class Atribuicao2 {
	static void Main(string[] args) {
		int a = 10; // Atribui o valor 10 a variável 'a'.

		Console.WriteLine("Exemplo 1.");
		Console.Write((a++)+"\n"); // Exibe o dado guardado na variável para aí pós incrementar o valor.
		Console.WriteLine(a); // E enfim mostrando o resultado 11 na variável.

		Console.WriteLine("\nExemplo 2.");
		Console.WriteLine(++a); // Incrementa primeiro o valor para aí depois exibir o resultado.
	}
}
