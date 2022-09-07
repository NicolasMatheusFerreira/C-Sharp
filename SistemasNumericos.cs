using System;

class SistemasNumericos {
	
	static string DecBinRec(double x, int y) {
		string bin = "1";
		if (x>=Math.Pow(2,y)) {
			x = x - Math.Pow(2,y);
		} else bin = "0";

		if (y==0)
			return bin;
		else return bin+DecBinRec(x, --y);
	}

	static string DecBinIte(int x) {
		
		string resto = "";
		while(x>=1) {
			resto += x%2;
			x /=2;
		}

		string result = "";
		for(int i = resto.Length-1; i>=0; i--)
			result = result+resto[i];
		return result;
	}

	static double BinDecRec(string bin, int i) {
		
		double result = Math.Pow(2.0,bin.Length-1-i)*int.Parse(Convert.ToString(bin[i]));

		if (i==0)
			return result;
		else return result += BinDecRec(bin, i-1);

	}

	static double BinDecIte(string bin) {
		
		int i = 0;
		double result = 0;
		while(i<bin.Length) {
			result += Math.Pow(2.0,bin.Length-1-i)*int.Parse(Convert.ToString(bin[i]));
			i++;
		}
		return result;
	}
	
	static void Main(string[] args) {
	
		string entrada = Console.ReadLine();
		Console.WriteLine(DecBinIte(int.Parse(entrada)));
	}
}
