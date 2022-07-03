using System;

class Fibonacci {
	static int isFibonacci(int termo) {
		
		int j = 1, a = 1, b = 2, c = 0;

//		Console.Write("{0} {1}", a, b);
		while(j<=termo-2) {
			c = a+b;
//			Console.Write(" {0}", c);
			a = b;
			b = c;

			j++;
		}
		return c;
	}

	static void Main(string[] args) {
		
	
	}
}
