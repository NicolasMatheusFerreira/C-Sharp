using System;

class Temporizador {


		private bool sinal;
		private string data;
		private string hora;


	public Temporizador(string date, string time, bool sign) {
		this.data = date;
		this.hora = time;
		this.sinal = sign;
	}

	public Temporizador() {	
	}

	public void setData(string x) {
		this.data = x;
	}
	public string getData() {
		return this.data;
	}

	public void setHora(string x) {
		this.hora = x;
	}
	public string getHora() {
		return this.hora;
	}

	public void setSinal(bool x) {
		this.sinal = x;
	}
	public bool getSinal() {
		return this.sinal;
	}

	private void Visual(bool sinal) {		
		if (sinal==true) {	
			Console.ForegroundColor = ConsoleColor.Yellow;						
			Console.WriteLine("Processando . . .");						
		}
	}
	private bool FiltroTempo(string[] DataHoraSystem, string data, string hora) {

		if (int.Parse(data.Substring(0,2))>=int.Parse(DataHoraSystem[0].Substring(0,2))) {
			if (int.Parse(data.Substring(3,2))>=int.Parse(DataHoraSystem[0].Substring(3,2))) {
				if (int.Parse(data.Substring(6,4))>=int.Parse(DataHoraSystem[0].Substring(6,4))) {
					if (int.Parse(hora.Substring(0,2))>=int.Parse(DataHoraSystem[1].Substring(0,2))) {
						if (int.Parse(hora.Substring(3,2))>=int.Parse(DataHoraSystem[1].Substring(3,2))) {					
							//if (int.Parse(hora.Substring(6,2))>=int.Parse(DataHoraSystem[1].Substring(6,2))) {
								return true;
							//} else Console.WriteLine("Segundos invalidos!");
						} else Console.WriteLine("Minutos invalidos");
					} else Console.WriteLine("Hora invalida");
				} else Console.WriteLine("Ano invalido!");
			} else Console.WriteLine("Mes invalido!");
		} else Console.WriteLine("Dia invalido!");		
		return false;
	}	

	public bool Temp(string data, string hora, bool sinal) {
		
		string dataHoraSystem = DateTime.Now.ToString();	
		string[] DataHoraSystem = new string[2];

		DataHoraSystem = dataHoraSystem.Split(' ');		

		if (FiltroTempo(DataHoraSystem, data, hora)) {
			do {
				dataHoraSystem = DateTime.Now.ToString();		
				DataHoraSystem = dataHoraSystem.Split(' ');
				Visual(sinal);
			} while(!data.Equals(DataHoraSystem[0]) || !hora.Equals(DataHoraSystem[1]));			
		} else return false;
		Console.ForegroundColor = ConsoleColor.Green;			
		return true;
	}
}
