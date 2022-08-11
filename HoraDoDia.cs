using System;

class HoraDoDia {

	static string EstadoDoDia(int x, int y) {
	
		if (x>=6 && x<=12) {
			return "Bom dia";
		} else if (x>12 && x<=18) {
			return "Boa tarde";
		} else if (x>18 && x<=0) {
			return "Boa noite";
		} else return "Boa madrugada";
	}

	static void Main(string[] args) {
		
		string horario, auxHoras="", auxMinutos="";
		int horas = 0, minutos = 0;

		Console.Write("Informe horario: ");
		horario = Console.ReadLine();
	
		if (horario[2]==':') {
			for(int i = 0; i<2; i++)
				auxHoras+=horario[i];

			for(int i = 3; i<horario.Length; i++)
				auxMinutos+=horario[i];

			horas = int.Parse(auxHoras);
			minutos = int.Parse(auxMinutos);
		}

		string resposta = EstadoDoDia(horas, minutos);
		Console.WriteLine(resposta);
	}
}
