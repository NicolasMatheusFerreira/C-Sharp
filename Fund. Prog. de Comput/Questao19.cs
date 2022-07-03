using System;

class Questao19 {
	static void Main(string[] args) {
		

		int alturaUsuario, alturaDegrau, qtdDegraus;
		Console.Write("Informe a altura que o usuario deseja alcancar: ");
		alturaUsuario = int.Parse(Console.ReadLine());

		Console.Write("Informe a altura do degrau: ");
		alturaDegrau = int.Parse(Console.ReadLine());

		qtdDegraus = alturaUsuario/alturaDegrau;

		Console.WriteLine("O usuario devera subir {0} degraus", qtdDegraus);
	}
}
