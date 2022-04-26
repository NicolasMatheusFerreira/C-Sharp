using System;

class SistemasNumericos {

	static string Invert(string x) {
	
		string y="";
		int cont;

		cont = x.Length-1;
		while(cont>=0) {
			y+=x.Substring(cont,1);
			cont--;
		}
		return y;
	}
	static void BinIntIte(string num) {
			
		int cont=0;
		double soma=0;
		string caractere="";

		num = Invert(num);
		while(cont<num.Length) {
			caractere = num.Substring(cont,1);
			soma +=Math.Pow(2, cont)*int.Parse(caractere);
			cont++;
		}
		Console.WriteLine(soma);
	}

	static string IntBinIte(int num) {
	
		string resto="1";
		while(num!=1) {
			resto = resto + num%2;
			num/=2;
		}
		return resto;
	}

	static string IntBinRec(int num) {
	
		string resto="";

		if (num==1)
			return "1";
		else resto = resto + (IntBinRec(num/2)+num%2);

		return resto;
	}

	static void Main(string[] args) {
/*
		if (args[1].Equals("int") && args[2].Equals("bin") && args[3].Equals("-r")) {
			Console.WriteLine(IntBinRec(int.Parse(args[0])));
		} else if (args[1].Equals("int") && args[2].Equals("bin") && args[3].Equals("-i")) {
			Console.WriteLine(IntBinIte(int.Parse(args[0])));
		}
*/
		string x = Console.ReadLine();
		BinIntIte(x);

	}

}
