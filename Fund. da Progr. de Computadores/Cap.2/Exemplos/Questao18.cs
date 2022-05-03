using System; 

class Questao18 {
	static void Main(string[] args) {
		
		double entrada, quadrado, cubo, raiz;

		do {
			entrada = double.Parse(Console.ReadLine());

			quadrado = Math.Pow(entrada, 2);
			cubo = Math.Pow(entrada, 3);
			raiz = Math.Sqrt(entrada);

			Console.WriteLine("Quadrado = {0} | Cubo = {1} | Raiz = {2:0.0}", quadrado, cubo, raiz);
		} while(entrada>0);
		
		Console.Write("\aFim!");		
	}
}
