using System;

class Questao10 {

	static void Main(string[] args) {
		
		int times = 2, jogadores = 4;
		int idade, qtdMenor18 = 0, acima80kg = 0;
		double peso, altura;
		double mediaIdade, mediaAltura, percent, somaIdade, somaAltura = 0;

		for(int i=1; i<=times; i++) {

			somaIdade = 0;

			for(int j=1; j<=jogadores; j++) {
				Console.WriteLine("Time {0} - Jogador {1}.\nInforme a idade: ", i, j);
				idade = int.Parse(Console.ReadLine());

				Console.WriteLine("Informe a altura: ");
				altura = double.Parse(Console.ReadLine());

				Console.WriteLine("Informe peso: ");
				peso = double.Parse(Console.ReadLine());

				if (idade<18.0) {
					qtdMenor18++;
				}

				somaIdade = somaIdade + idade;
				somaAltura = somaAltura + altura;

				if (peso>80.0) {
					acima80kg++;
				}
			}
		
			mediaIdade = somaIdade/jogadores;
			Console.WriteLine("A idade media dos jogadores de cada time e {0}", mediaIdade);		
		}
		
		mediaAltura = somaAltura/jogadores;
		percent = acima80kg/jogadores*100;
		
		Console.WriteLine("A quantidade de jogadores com a idade inferior a 18 anos e {0}", qtdMenor18);
		Console.WriteLine("A altura media dos jogadores de cada time e {0}", mediaAltura);
		Console.WriteLine("A porcentagem dos jogadores com mais de 80 Kg e {0} \n", percent);		
	}
}
