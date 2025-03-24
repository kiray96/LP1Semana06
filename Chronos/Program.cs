using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Criar os cronómetros 
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Inicia o cronómetro 1
            crono1.Start();
            // Pausa o programa durante 5oo milissegundos
            Thread.Sleep(500);
            // Inicia o cronómetro 2
            crono2.Start();
            // Pausa o programa durante 250 milissegundos
            Thread.Sleep(250);
            // Pausa o conómetro 1
            crono1.Stop();
            // Pausa o conómetro 2
            crono2.Stop();

            // Retirar os resuultados de tempo dos 2 cronómetros 
            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            // Print na consola do tempo com quatro casas decimais
            Console.WriteLine($"{ts1.TotalSeconds:f4}");
            Console.WriteLine($"{ts2.TotalSeconds:f4}");

        }
    }
}
