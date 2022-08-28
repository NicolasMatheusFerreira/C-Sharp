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

	static int BinDecRec(string bin, int i) {

	}
	
	static void Main(string[] args) {
	
		Console.WriteLine(BinDecRec(Console.ReadLine(),0));
	}
}
