using System;

class Questao15 {
	static void Main(string[] args) {
		
		float precFabrica, custoConsumidor;
		int percentImpostos, percentLucro;

		Console.Write("Informe o preco de fabrica de um carro: ");
		precFabrica = float.Parse(Console.ReadLine());
		Console.Write("Informe o percentual de impostos: ");
		percentImpostos = int.Parse(Console.ReadLine());
		Console.Write("Informe o percentual de lucro: ");
		percentLucro = int.Parse(Console.ReadLine());

		custoConsumidor = precFabrica+precFabrica*(percentImpostos+percentLucro)/100;
		Console.WriteLine("O preco de custo ao consumidor e igual a {0:0.00} R$", custoConsumidor);
	}
}
