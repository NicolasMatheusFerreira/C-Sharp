using System;

class Lista {
	
	static void Remover(string[] lista, ref int n, int i) {
		
		if (n>0) {
			for(int y = i; y<n; y++)
				lista[y] = lista[y+1];			
			lista[n] = "";
			n--;
		} else Console.WriteLine("Lista esta vazia");
	}

	static void RemoverFim(string[] lista, ref int n) {
		
		if (n>0) {
			lista[n] = "";
		} else Console.WriteLine("Lista esta vazia!");
	}	

	static void RemoverInicio(string[] lista, ref int n) {

		if (n>0) {
			lista[0] = "";
			for(int i = 0; i<=n; i++)
				lista[i] = lista[i+1];
			n--;
		} else Console.WriteLine("Lista esta vazia!");
	}

	static void InserirInicio(string x, string[] lista, ref int n) {
		
		if (lista.Length>n) {
			for(int i = n; i>0; i--) {
				lista[i] = lista[i-1];
			}
			lista[0] = x;
			n++;
		} else Console.WriteLine("Lista cheia!");
	}
	
	static void InserirFinal(string x, string[] lista, ref int n) {
		
		if (lista.Length>n) {
			lista[n] = x;
			n++;
		} else Console.WriteLine("Lista cheia!");
	}

	static void Inserir(string[] lista, ref int n, int i, string x) {
		
		if (n<lista.Length) {
			for(int y = n; y>i; y--)
				lista[y] = lista[y-1];			
			lista[i] = x;
			n++;
		} else Console.WriteLine("Lista esta cheia");
	}

	static void Main(string[] args) {
				
		string[] Lista = new string[10];
		int n = 0;
		bool parada;

		parada = true;
		while(parada && n<Lista.Length) {					
			Console.Write("Informe uma palavra: ");
			Lista[n] = Console.ReadLine();

			if (Lista[n]=="0") {
				parada = false;
			} else n++;
		}
	
		for(int i = 0; i<Lista.Length; i++)
			Console.Write("{0} ", Lista[i]);

		Console.WriteLine();
		for(int i = 0; i<Lista.Length; i++)				
			Console.Write("{0} ", Lista[i]);
		

	}
}
