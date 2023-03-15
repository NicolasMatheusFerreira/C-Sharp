using System;

public class Lutador {
	
	private string nome;
	private string nacional;
	private int idade;
	private double altura;
	private double peso;
	private string categoria;
	private int vitorias;
	private int derrotas;
	private int empates;

	public Lutador() {
		this.nome = "N/A";
		this.nacional = "N/A";
		this.idade = 0;
		this.altura = 0.0;
		this.peso = 0.0;
		this.categoria = "N/A";
		this.vitorias = 0;
		this.derrotas = 0;
		this.empates = 0;
	}



	public void setNome(string nome) {
		this.nome = nome;
	}
	public string getNome() {
		return this.nome;
	}
	public void setNacional(string nacional) {
		this.nacional = nacional;
	}
	public string getNacional() {
		return this.nacional;
	}
	public void setIdade(int idade) {
		this.idade = idade;
	}
	public int getIdade() {
		return this.idade;
	}
	public void setAltura(double altura) {
		this.altura = altura;
	}
	public double getAltura() {
		return this.altura;
	}
	public void setPeso(double peso) {
		this.peso = peso;
	}
	public double getPeso() {
		return this.peso;
	}
	public void setCategoria() {
		if (peso<52.2) 
			categoria = "Invalido";
		else if (peso<70.3)
			categoria = "Leve";
		else if (peso<83.9)
			categoria = "Medio";
		else categoria = "Pesado";
	}
	public string getCategoria() {
		return this.categoria;
	}
	public void setVitorias(int vitorias) {
		this.vitorias = vitorias;
	}
	public int getVitorias() {
		return this.vitorias;
	}

	public void setDerrotas(int derrotas) {
		this.derrotas = derrotas;
	}
	public int getDerrotas() {
		return this.derrotas;
	}
	public void setEmpates(int empates) {
		this.empates = empates;
	}
	public int getEmpates() {
		return this.empates;
	}

	public void ganharLuta() {
		this.setVitorias(getVitorias()+1);
	}
	public void perderLuta() {
		this.setDerrotas(getDerrotas()+1);
	}
	public void empatarLuta() {
		this.setEmpates(getEmpates()+1);
	}

	public void apresentarLutador() {

		Console.WriteLine("Lutador: "+getNome());
		Console.WriteLine("Origem: "+getNacional());
		Console.WriteLine(getIdade()+" anos");
		Console.WriteLine(getAltura()+" cm");
		Console.WriteLine("Pesando: "+getPeso()+" kg");
		Console.WriteLine("Ganhou: "+getVitorias()+" vezes");
		Console.WriteLine("Perdeu: "+getDerrotas()+" vezes");
		Console.WriteLine("Empatou: "+getEmpates()+" vezes");
	}
}
