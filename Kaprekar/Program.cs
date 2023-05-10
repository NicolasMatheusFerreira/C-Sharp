﻿using System;

namespace Kaprekar
{
    class Program
    {
	static void DivideNum(string valor, ref int[] num) {
		
		int i = 0;
		string aux = "";

		for(i = 0; i<valor.Length/2; i++)
			aux += valor[i];

		num[0] = Convert.ToInt32(aux);

		aux = "";

		for(i = i; i<valor.Length; i++)
			aux = aux + valor[i];

		num[1] = Convert.ToInt32(aux);			
	}

	static bool NumeroKaprekar(int num) {
		
		int[] aux = new int[2];
		
		if (num>9) {
			DivideNum(num.ToString(), ref aux);

			int result = aux[0]+aux[1];		
			return (Math.Pow(result, 2)==num)? true:false;
		} else return false;
	}

        static void Main(string[] args)
        {
            Console.Write("Informe um valor: ");	    

	    int num = Convert.ToInt32(Console.ReadLine());

	    if (num>=1 && num<=100000000)
	            Console.WriteLine(NumeroKaprekar(num));
	    else Console.WriteLine("Numero invalido!");
        }
    }
}
