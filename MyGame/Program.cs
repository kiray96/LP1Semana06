using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Aceitar o número de inimigos na linha de comandos
            int emy = Convert.ToInt32(args[0]);

            // Criação de array de inimigos
            Enemy[] enemies = new Enemy[emy];

            // Percorrer os indices do array
            for(int e = 0; e < emy; e++)
            {
                // Pedir e guardar o número de inimigos ao utilizador
                Console.Write($"Nome do inimigo {e + 1}: ");
                string name = Console.ReadLine();

                // Preencher o array de enemies
                enemies[e] = new Enemy(name);
            }
           
            
        }
    }
}
