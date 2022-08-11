using System;

class Questao18 {
	static void Main(string[] args) {
		
		double pesoSacoRacao = 0, racaoGato1, racaoGato2;

		Console.Write("Informe o peso do saco de racao em KG: ");
		pesoSacoRacao = double.Parse(Console.ReadLine());

		Console.Write("Informe a quantidade de racao do gato 1: ");
		racaoGato1 = double.Parse(Console.ReadLine())/1000;
		Console.Write("Informe a quantidade de racao do gato 2: ");
		racaoGato2 = double.Parse(Console.ReadLine())/1000;
			
		pesoSacoRacao -= (racaoGato1+racaoGato2)*5;
		Console.WriteLine($"Apos cinco dias vao ainda restar {pesoSacoRacao} Kg de racao no saco");
	}

}
