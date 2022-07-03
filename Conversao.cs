using System;

class Conversao {
	static void Main(string[] args) {
		/*
		float a = 4.5f;
		double b = a;
		Console.Write(b);
		*/

		/*
		float a; 
		double b = 4.5;

		a = b;
		Console.WriteLine(a);

		Isto gera um Cannot implicity convert type 'double' to 'float'. Isto gera erro porque
		double equivale a 8bytes na memória do computador (64 bits) e o 
		float equivale a 4bytes na memória do computador (32 bits) e

		float 32 < double 64 bytes. Pois então a perda de dados, pois não cabe essa quantidade de memória na região.

		Se você quiser fazer isso mesmo, é necessário fazer uma conversão explicíta realizando o 'type casting' 

		double x = 5;
		float y = (float) x; Primeiro converte o x que é um double em um float, responsabilizando a perda de dados de 64 para 32 bytes para o casting e atribuindo em float.
		*/

		/*
		int a = 3;
		float b = a;
		Console.Write(b);
		*/

		/*
		float a = 3.5f;
		int b = a;
		Console.Write(b);

		Mesmo problema que no exemplo acima, pois o float equivale a 4bytes assim como o int que também equivale a 4bytes. Porém a forma dessas duas variáveis
		de armazenar e representar seus dados é diferente impossibilitando a atribuição, do contrário funciona pois não gera perda de dados já que o conjunto 
		dos Z inteiros está contido dos Q racionais.
		
		int a = 5;
		float b = a;
		Console.Write(b);
		*/

		/* Truncamento
		 *
		 *

		 double a = 4.3;
		 int b = (int) a;
		 Ao realizar a atribuição do número racional o inteiro é feita um type casting trucando as casas decimais e armazenando o valor inteiro.
		 */
	}
}
