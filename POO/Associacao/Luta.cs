using System;

public class Luta {
	
	private Lutador desafiado;
	private Lutador desafiante;
	private int rounds;
	private bool aprovada;

	public Luta(Lutador desafiado, Lutador desafiante) {

		this.desafiado = desafiado;
		this.desafiante = desafiante;
		rounds = 0;
		aprovada = false;
	}

	public void setDesafiado(Lutador desafiado) {
		this.desafiado = desafiado;
	}
	public Lutador getDesafiado() {
		return this.desafiado;
	}
	public void setDesafiante(Lutador desafiante) {
		this.desafiante = desafiante;
	}
	public Lutador getDesafiante() {
		return this.desafiante;
	}

	public void marcarLuta(Lutador l1, Lutador l2) {
		
		if (l1.getCategoria().Equals(l2.getCategoria()) && l1!=l2) {
			this.desafiado = l1;
			this.desafiante = l2;
			aprovada = true;
		} else {
			aprovada = false;
			Console.WriteLine("Categorias invalidas!");
		}
	}

	public void lutar() {
		
		Random aleatorio = new Random();
		if (aprovada==true) {
			desafiado.apresentarLutador();
			desafiante.apresentarLutador();

			int vencedor = 	aleatorio.Next(0,3);			

			switch (vencedor) {
				case 0:
					Console.WriteLine("Empatou!");
				break;

				case 1:
					Console.WriteLine("O desafiado venceu!");
					desafiado.apresentarLutador();
				break;

				case 2:
					Console.WriteLine("O desafiante venceu!");
					desafiante.apresentarLutador();
				break;
			}
		} else {
			Console.WriteLine("Luta nao aprovada ainda!");
		}
	}
}
