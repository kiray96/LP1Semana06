using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Obter parametros da linha de comandos
            int n = Convert.ToInt32(args[0]);
            int s = Convert.ToInt32(args[1]);

            // Criar nova instancia de random
            Random random = new Random(s);

            // Iniciar a variável de contagem
            int count = 0;

            //Loop n vezes 
            for(int i = 0; i < n; i++)
            {
                // Soma um número random entre um e 6
                count += random.Next(1, 7);
            }

            // Imprimir o resultado 
            Console.WriteLine(count);
        }
    }
}
