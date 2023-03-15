using System;

class Conversao {
	static void Main(string[] args) {
		
		int x = 10;
		double y = 3.5;
		char z = 'a';
		string h = "Ana";
		bool condicao = true;

		Console.WriteLine("x = {0} {1}", x, x.GetType());
		Console.WriteLine("y = {0} {1}", y, y.GetType());
		Console.WriteLine("z = {0} {1}", z, z.GetType());
		Console.WriteLine("h = {0} {1}", h, h.GetType());
		Console.WriteLine("f = {0} {1}", condicao, condicao.GetType());

		Console.Write("\n\nConversao\n\n");

		Console.WriteLine(y.ToString().GetType());
		Console.WriteLine(z.ToString().GetType());
		
	}
}
