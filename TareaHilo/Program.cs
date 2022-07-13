using System;
using System.Threading;

namespace Threads
{
    class Program{
        private static bool ejecutar = true;
        
        static void Main(string[] args)
        {
            int m = 0;
            
                Thread hilo = new Thread(Mensaje);
                hilo.Start();
            
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Trabajando desde el hilo principal {0}",m);
                m++;
                
                if (m == 1000)
                    ejecutar = false;
            }
        }
        static void Mensaje()
        {
            int n = 0;
            
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Trabajando desde el hilo secundario {0}",n);
                n++;
            }
        }
    }
}


