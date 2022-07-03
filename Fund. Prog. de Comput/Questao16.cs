using System;

class Questao16 {
	static void Main(string[] args) {
		
		double valorSalario, valorHoraTrab, salarioBruto, imposto, salarioLiqui;
		int horasTrab;

		Console.Write("Informe o valor do salario minimo: ");
		valorSalario = double.Parse(Console.ReadLine());

		Console.Write("Informe a quantidade de horas trabalhadas: ");
		horasTrab = int.Parse(Console.ReadLine());

		valorHoraTrab = valorSalario/2;
		salarioBruto = horasTrab*valorHoraTrab;
		imposto = salarioBruto*0.03;
		salarioLiqui = salarioBruto-imposto;
		Console.WriteLine("O salario liquido a receber pelas horas trabalhadas e "+salarioLiqui+" R$.");
	}
}
