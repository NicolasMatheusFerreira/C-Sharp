using System;

class Questao2 {
	static void Main(string[] args) {
			
		double[] ValorUnitario = new double[5]; // Declação de variáveis (Reservando espaços na memória do computador)
		double[] TotalVendidos = new double[5];
		int[] QtdPecasVendidas = new int[5];
		int maior = 0, produto = 0;

		double salarioVendedor = 545.00, acressimo = 0;

		for(int e = 0; e<ValorUnitario.Length; e = e+1) { // Leitura e processamento dos dados
			Console.Write("Poduto {0}.\nInforme preco: R$ ", 1+e);
			ValorUnitario[e] = double.Parse(Console.ReadLine());

			Console.Write("Informe quantidade de pecas vendidas: ");
			QtdPecasVendidas[e] = int.Parse(Console.ReadLine());

			TotalVendidos[e] = ValorUnitario[e]*QtdPecasVendidas[e];
			acressimo = acressimo + 0.05*TotalVendidos[e];			

			if (QtdPecasVendidas[e]>maior) {
				maior = QtdPecasVendidas[e];
				produto = e+1;
			}

			Console.WriteLine();
		}

		salarioVendedor += acressimo;

		for(int aq = 0; aq<5; aq++) // Saída
			Console.WriteLine("Produto {0}. Valor unit.: R$ {1:0.00} - Qtd. Vendida {2} - Total {3}", aq+1, ValorUnitario[aq], QtdPecasVendidas[aq], TotalVendidos[aq]);
		Console.WriteLine("O produto mais vendido e o produto {0} com {1} quant. vendidas.", produto, maior);		
		Console.WriteLine("Salario + acressimo do vendedor e igual a R$ {0:0.00}", salarioVendedor);		
	}
}
