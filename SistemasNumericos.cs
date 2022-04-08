using System;

class SistemasNumericos {

	static int BinIntRec(string num, int i) {
		
		int soma = 0;
		if (i==num.Length()) {
			return i;
				
		} else soma = soma +num.substring(i, )*Math.pow(2,i)
		return soma;
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
		
		if (args[1].Equals("int") && args[2].Equals("bin") && args[3].Equals("-r")) {
			Console.WriteLine(IntBinRec(int.Parse(args[0])));
		} else if (args[1].Equals("int") && args[2].Equals("bin") && args[3].Equals("-i")) {
			Console.WriteLine(IntBinIte(int.Parse(args[0])));
		}
	}
}
