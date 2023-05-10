﻿using System;

namespace SomaReservada
{
    class Program
    {
	static int Rev(int x) {
		
		string resto = "";
		while(x>=1) {	
			resto += x%10;		
			x = x/10;
		}
		return Convert.ToInt32(resto);
	}

        static void Main(string[] args)
        {
		int n, m;

		Console.Write("Informe um valor para N: ");
		n = int.Parse(Console.ReadLine());
		Console.Write("Informe um valor para M: ");
		m = int.Parse(Console.ReadLine());

		Console.WriteLine(Rev(Rev(n)+Rev(m)));
        }
    }
}
