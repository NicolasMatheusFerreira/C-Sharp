using System;

class Caractere {
	static void TabelaASCII() {
		
		for(int cont = 33; cont<=256; cont++)
			Console.WriteLine("{0} - {1}", cont, Convert.ToChar(cont));
	}

	static void Main(string[] args) {
		char letra = '\u0041';

		Console.WriteLine(letra);

		TabelaASCII();
	}
}
