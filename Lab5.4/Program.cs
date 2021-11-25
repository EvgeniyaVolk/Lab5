using System;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0}", array[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
