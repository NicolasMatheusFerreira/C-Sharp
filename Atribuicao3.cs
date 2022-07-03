using System;

class Atribuicao3 {

	static void Exemplo2() {
		int a, b;

		a = 10;
		b = a++;

		Console.WriteLine(a);
		Console.WriteLine(b);
	}

	static void Exemplo1() {
	
		int a, b;
		a = 10;
		b = ++a;

		Console.WriteLine(a);
		Console.WriteLine(b);
	}

	static void Main(string[] args) {
		
		Exemplo2();
	}
}
