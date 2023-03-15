using System;

namespace DataTime {
    class Program {
        static void Main(string[] args) {
            DateTime data = DateTime.Now;            
            Console.WriteLine(data);
            string[] dataHora = data.ToString().Split(' ');
            Console.WriteLine(dataHora[0]);            
            Console.WriteLine(dataHora[1]);            
        }
    }
}
