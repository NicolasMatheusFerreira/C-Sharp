using System;

class BuscaBinariaRec {

	static int Busca(string[] arr, string target, int inicio, int fim) {
		
		int meio;
		if (inicio<=fim) {
			meio = (inicio+fim)/2;
			if (arr[meio]==target)
				return meio;
			else if (target.CompareTo(arr[meio])>0)
				return Busca(arr, target, meio+1, fim);
			else if (target.CompareTo(arr[meio])<0)
				return Busca(arr, target, 0, meio-1);		
		} 
		return -1;
	}

	static void Main(string[] args) {
	
		int posic;
		string alvo = "";

		if (args.Length>0) {
			Console.Write("Informe alvo: ");
			alvo = Console.ReadLine();		
		} else {
			args = new string[5];
			for(int i = 0; i<args.Length; i++) {
				Console.Write("Informe palavra: ");
				args[i] = Console.ReadLine();
			}
			Console.Write("Informe alvo: ");
			alvo = Console.ReadLine();
		}
		Array.Sort(args);		

		posic = Busca(args, alvo, 0, args.Length-1);

		if (posic>=0)
			Console.WriteLine("A palavra contida na posicao: {0} e {1}", posic, args[posic]);
		else Console.WriteLine("Elemento inexistente no vetor!");
	}
}
