using System;

class Questao4 {
	static void Main(string[] args) {
		
		int qtd_cidades = 5, codigo_cidade, num_veic_passeio, num_aci_vit, i = 1, maior=0, menor=100000000, maior_cid=0, menor_cid=0, soma_acid=0, soma_veic=0;
		double media_veic, media_acid;

		while(i<=qtd_cidades) {

			Console.Write("Informe codigo da cidade "+i+": ");
			codigo_cidade = int.Parse(Console.ReadLine());

			Console.Write("Informe num. veiculos de passeio: ");
			num_veic_passeio = int.Parse(Console.ReadLine());

			Console.Write("Informe num. de acid. de transito com vitimas: ");
			num_aci_vit = int.Parse(Console.ReadLine());

			if (num_aci_vit>maior) {
				maior_cid = codigo_cidade;
				maior = num_aci_vit;
			}

			if (num_aci_vit<menor) {
				menor_cid = codigo_cidade;
				menor = num_aci_vit;
			}

			soma_veic += num_veic_passeio;

			if (num_veic_passeio<2000) {
				soma_acid++;
			}
			i++;
		}

		media_veic = (double) soma_veic/qtd_cidades*100;
		media_acid = (double) soma_acid/qtd_cidades*100;

		Console.WriteLine("O maior indice de acidentes de transito pertence a cidade {0} com {1} acidentes.", maior_cid, maior);
		Console.WriteLine("O menor indice de acidentes de transito pertence a cidade {0} com {1} acidentes.", menor_cid, menor);
		Console.WriteLine("A media de veic. entre as {0} cidades e igual a {1:0.00}", qtd_cidades, media_veic);
		Console.WriteLine("A media de aci. de transito entre as cidades com menor de 2000 veic. e de {0:0.00}",media_acid);
	}
}
