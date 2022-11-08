using System;
using System.Diagnostics;

namespace Temporizacao {
    class Program {
        static void Main(string[] args) {
    		Temporizador temporizador = new Temporizador();

            Console.Clear();
		    bool retorno = temporizador.Temp(args[0],args[1], bool.Parse(args[2]));

            if (retorno) {
               Console.WriteLine(System.Diagnostics.Process.Start("calc.exe"));               
            }
            Console.ResetColor();
        }
    }
}
