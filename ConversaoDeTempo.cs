using System;

namespace Teste
{
    class Program
    {
	static void ConversaoTempo(ref int numDias, ref int dia, ref int mes, ref int ano) {

	    if (numDias>=365) {
                ano = (numDias/365);
		numDias-=ano*365;              
            } 
	    mes = (numDias/30);
	    numDias-=mes*30;
	    
	    dia = numDias;                       
	}

        static void Main(string[] args)
        {
            int ano = 0, mes = 0, dia = 0;
	    int entrada = int.Parse(Console.ReadLine());

            ConversaoTempo(ref entrada, ref dia, ref mes, ref ano);     		  
            Console.WriteLine("{0} ano (s) {1} mes (ses) {2} dia (s)", ano, mes, dia);
        }
    }
}
