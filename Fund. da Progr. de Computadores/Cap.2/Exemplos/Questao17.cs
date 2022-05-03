using System;

class Questao17 {
	static void Main(string[] args) {
		double salarioCarlos, salarioJoao;
		int meses = 0;

		Console.WriteLine("Informe o salario de Carlos: ");
		salarioCarlos = double.Parse(Console.ReadLine());

		salarioJoao = salarioCarlos/3.0;

		while(salarioJoao<salarioCarlos) {
			
			salarioCarlos += (salarioCarlos*0.02);
			salarioJoao += (salarioJoao*0.05);

			meses++;
		}

		Console.WriteLine("Sao necessarios {0} meses para que o salario de Joao, ultrapasse o salario de Carlos. \n\n", meses);

		Console.WriteLine("Salario de Joao: R$ {0:0.00}", salarioJoao);
		Console.WriteLine("Salario de Carlos: R$ {0:0.00}", salarioCarlos);
	}
}
