using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            int s = Convert.ToInt32(args[1]);

            Random random = new Random(s);

            int count = 0;

            for(int i = 0; i < n; i++)
            {
                count += random.Next(1, 7);
            }

            Console.WriteLine(count);
        }
    }
}
