using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading {
    public class Conta {
        
        private int saldo = 1000;
        Random random = new Random();
        public void Saque() {
            
            if (saldo>0) {
                Console.WriteLine("Thread: {0}", Thread.CurrentThread.Name);
                Console.WriteLine("Saldo: {0}", saldo);
                saldo = saldo - 100;
                Thread.Sleep(random.Next(1,10)*100);
                Console.WriteLine("Novo saldo: {0}", saldo);
            } else {
                Console.WriteLine("Nao a saldo suficiente");
            }
        }
    }
}