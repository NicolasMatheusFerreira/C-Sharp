using System;

class Atribuicao2 {
	static void Main(string[] args) {
		int a = 10; // Atribui o valor 10 a vari�vel 'a'.

		Console.WriteLine("Exemplo 1.");
		Console.Write((a++)+"\n"); // Exibe o dado guardado na vari�vel para a� p�s incrementar o valor.
		Console.WriteLine(a); // E enfim mostrando o resultado 11 na vari�vel.

		Console.WriteLine("\nExemplo 2.");
		Console.WriteLine(++a); // Incrementa primeiro o valor para a� depois exibir o resultado.
	}
}
