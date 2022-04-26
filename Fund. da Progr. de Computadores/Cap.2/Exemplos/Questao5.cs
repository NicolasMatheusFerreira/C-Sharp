using System;

class Questao5 {
	static void Main(string[] args) {
		int num_termos, num, fat, i, j;
		double s=-1;

		fat = 1;
		i = 1;

		Console.Write("Informe a quantidade de termos: ");
		num_termos = int.Parse(Console.ReadLine());

		Console.Write("Informe um numero: ");
		num = int.Parse(Console.ReadLine());

		if (num>0) {
			while(i<=num_termos) {
				if (i%2==0)
					num*=-1;

				j = i;
				while(j>0) {
					fat*=j;
					j--;
				}

				s = Math.Pow(num,i)/fat;
				Console.Write("{0} ", s);
				i++;
			}
		}
	}
}
