using System;

class SistemasNumericos {
	
	static string DecBin(double x, int y) {
		string bin = "1";
		if (x>=Math.Pow(2,y)) {
			x = x - Math.Pow(2,y);
		} else bin = "0";

		if (y==0)
			return bin;
		else return bin+DecBin(x, --y);
	}
	
	static void Main(string[] args) {
	
		Console.WriteLine(DecBin(int.Parse(Console.ReadLine()),9));
	}
}
