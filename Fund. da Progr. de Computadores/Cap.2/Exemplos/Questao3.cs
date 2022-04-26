using System;

class Questao3 {
	static void Main(string[] args) {
		int qtd_num, num, fat, i, j;

		i = 1;

		Console.Write("Informe a quantidade de operacoes deseja realizar: ");
		qtd_num = int.Parse(Console.ReadLine());

		while(i<=qtd_num) {

			fat = 1;

			Console.Write("Informe um valor: ");
			num = int.Parse(Console.ReadLine());

			j = num;
			
			if (j!=0) 			
				while(j>1) {
					fat*=j;				
					j--;

				}		

			Console.WriteLine("Num. {0} - Fat. {1}", num, fat);
			i++;
		}
	}
}
