using System;
using System.Threading;
using System.Diagnostics;

namespace Threading {
    public class Program {
        static void Main(string[] args) {

            Conta conta = new Conta();
            Thread[] threads = new Thread[12];
            
            for(int i=0; i<threads.Length; i++) {
                Thread thread = new Thread(conta.Saque);
                thread.Name = "Thread"+i;
                threads[i] = thread;
            }

            foreach(Thread x in threads) {
                x.Start();
            }

            Console.Read();
        }

        static void MetodoThread() {
            for(int i=1; i<=10; i++)
                Console.WriteLine("{0} Threading 01 sendo executada.", i);
        }
    }
}