using System;

class Sort {

	static int[] Ordena(int[] N) {

		int i, j, k;
		int[] Aux = new int[N.Length];
		for(i = 0; i<Aux.Length; i++)
			Aux[i] = 0;
		for(i = 0; i<N.Length; i++) {
			Aux[N[i]] = Aux[N[i]] + 1;		
		}

		for(i = 0, k = 0; i<Aux.Length; i++)
			for(j = Aux[i]; j>0; j--) {
				N[k++] = i;			
			}

		return N;
	}

	static void Main(string[] args) {

		Random random = new Random();
		int tamanho;

		if (args.Length==0)
			tamanho = random.Next(0,100000);
		else tamanho = int.Parse(args[0]);

		int[] Vetor = new int[tamanho];
		for(int q = 0; q<Vetor.Length; q++)
			Vetor[q] = random.Next(0,tamanho);
		Ordena(Vetor);
		
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write("{0} ", Vetor[i]);
		
	}
}
