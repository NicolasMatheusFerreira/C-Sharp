using System;

namespace SeparcaoSilabas
{
    class Program
    {
	static void Separa(string frase) {
		
		int i = 0;
		string aux = "";

		if (frase.Length>50)
			Console.WriteLine("Quantidade de caracteres invalidos!");
		else {
			while(i<frase.Length) {

				aux = aux + frase[i];			

				if (frase[i]=='a' || frase[i]=='e' || frase[i]=='i' || frase[i]=='o' || frase[i]=='u') {
					Console.Write(aux);
					Console.Write('-');				
					for(int j = i+1; j<frase.Length; j++)
						Console.Write(frase[j]);
					Console.WriteLine();
				}

				i++;
			}	
		}
		Console.WriteLine("Fim");
	}

        static void Main(string[] args)
        {
            Separa("programação");
        }
    }
}
