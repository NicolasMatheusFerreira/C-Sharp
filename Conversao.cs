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
		double equivale a 8bytes na mem�ria do computador (64 bits) e o 
		float equivale a 4bytes na mem�ria do computador (32 bits) e

		float 32 < double 64 bytes. Pois ent�o a perda de dados, pois n�o cabe essa quantidade de mem�ria na regi�o.

		Se voc� quiser fazer isso mesmo, � necess�rio fazer uma convers�o explic�ta realizando o 'type casting' 

		double x = 5;
		float y = (float) x; Primeiro converte o x que � um double em um float, responsabilizando a perda de dados de 64 para 32 bytes para o casting e atribuindo em float.
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

		Mesmo problema que no exemplo acima, pois o float equivale a 4bytes assim como o int que tamb�m equivale a 4bytes. Por�m a forma dessas duas vari�veis
		de armazenar e representar seus dados � diferente impossibilitando a atribui��o, do contr�rio funciona pois n�o gera perda de dados j� que o conjunto 
		dos Z inteiros est� contido dos Q racionais.
		
		int a = 5;
		float b = a;
		Console.Write(b);
		*/

		/* Truncamento
		 *
		 *

		 double a = 4.3;
		 int b = (int) a;
		 Ao realizar a atribui��o do n�mero racional o inteiro � feita um type casting trucando as casas decimais e armazenando o valor inteiro.
		 */
	}
}
