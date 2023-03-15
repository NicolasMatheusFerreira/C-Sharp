using System;

class ocorrencia {
	static void Main(string[] args) {
		
		Random rand = new Random();
		int[] Numeros = new int[5];	
		int i, a, j;

//		int k = 1, igual = 0;
//		while(k<=10000) {
			i = 0;
			a = rand.Next(0,100);
			while(i<Numeros.Length) {
				Numeros[i++] = a;
				a = rand.Next(0,100);
				for(j = 0; j<i; j++)
					while(a==Numeros[j]) {
						a = rand.Next(0,100);
					}		
			}

			for(i = 0; i<Numeros.Length; i++)
				Console.Write($"{Numeros[i]} ");

/*			for(i = 0; i<Numeros.Length; i++) {
				for(j = 0; j<Numeros.Length; j++)
					if (Numeros[i]==Numeros[j] && i!=j)
						igual++;						
			}
			k++;
			
			}
		Console.WriteLine("O programa tem uma precisao de "+(100-(igual/10000))+"%");
*/
	}
}
