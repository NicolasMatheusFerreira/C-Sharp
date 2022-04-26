using System;

class Questao6 {
	static void Main(string[] args) {
		
		int qtd_func = 1, codigo, hrs_trab_mes=0, i = 1;
		char turno_trabalho, categoria;
		double salario_minimo = 450, salario_inicial = 0, aux_aliment=0, percent=0, valor_hora_trab=0;

		while(i<=qtd_func) {
			Console.WriteLine("Informe o codigo do funcionario: ");
			codigo = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe as horas trabalhadas no mes: ");
			hrs_trab_mes = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe o turno de trabalho:");
			turno_trabalho = Char.ToUpper(Console.ReadKey().KeyChar);

			if (turno_trabalho=='N' || turno_trabalho=='V' || turno_trabalho=='M') {
				Console.WriteLine("Informe a categoria do funcionario: ");
				categoria = Char.ToUpper(Console.ReadKey().KeyChar);

				if (categoria=='O' || categoria=='G') {
					if (categoria=='G' && turno_trabalho=='N') {
						valor_hora_trab = salario_minimo*18/100;
					} else if (categoria=='G' && (turno_trabalho=='M' || turno_trabalho=='V')) {
						valor_hora_trab = salario_minimo*15/100;
					} else if (categoria=='O' && turno_trabalho=='N') {
						valor_hora_trab = salario_minimo*13/100;
					} else if (categoria=='O' && (turno_trabalho=='M' || turno_trabalho=='V')) {
						valor_hora_trab = salario_minimo*10/100;
					}
				} else Console.WriteLine("\aCategoria invalida!");
			} else Console.WriteLine("\aTurno de trabalho invalido!");
			
			salario_inicial = valor_hora_trab*hrs_trab_mes;

			if (salario_inicial<300) {
				percent = 0.20;
			} else if (salario_inicial>=300 && salario_inicial<=600) {
				percent = 0.15;
			} else percent = 0.05;

			aux_aliment = percent*salario_inicial;

			Console.WriteLine("Funcionario {0} - Qtd. de horas trab. {1} - Valor da hora trab. R$ {2} - Salario Inic. {3} - Aux. Alim. {4} - Salario final R$ {5}", codigo, hrs_trab_mes, valor_hora_trab, salario_inicial, aux_aliment, (salario_inicial+aux_aliment));		
			i++;
		}
	}
}
