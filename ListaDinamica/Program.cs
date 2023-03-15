using System;

namespace ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            fila.Inserir(1);
            fila.Inserir(2);
            fila.Inserir(3);
            fila.Inserir(4);
            fila.Listar();
        }
    }
}
