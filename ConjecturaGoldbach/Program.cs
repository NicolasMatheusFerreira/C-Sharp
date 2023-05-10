using System;

namespace ConjecturaGoldbach
{
    class Program
    {
	static bool EhPrimo(int j) {

		int soma = 0, i = 1;
		while(i<=j) {
			if (j%i==0)
				soma++;
			i = i+1;
		}
		if (soma==2)
			return true;		
		return false;
	}

	static int[] Conjectura(int valor) {
	
		int i;
		int[] resp = new int[] {-1,-1};

		if (valor>=2 && valor<=4294967294) {
			for(i = 2; i<valor; i++) {
				if (EhPrimo(i)) {
					resp[0] = i;
					for(int j = resp[0]; j<valor; j++) {
						if (EhPrimo(j)) {
							resp[1] = j;

							if (resp[0]+resp[1]==valor)
								return resp;
						}
					}
				}
			}
		}
		resp[0] = -1; resp[1] = -1;
		return resp;
			
	}
        static void Main(string[] args)
        {
         	int[] resposta = new int[2];

		Console.Write("Informe valor: ");
		int valor = int.Parse(Console.ReadLine());
		resposta = Conjectura(valor);

		Console.WriteLine("A conjectura de {0} e igual a soma de {1} + {2}", valor, resposta[0], resposta[1]);

        }
    }
}
