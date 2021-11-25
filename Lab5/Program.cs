using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                S+= array[i];
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее значение={0}", S/7);
            
            Console.ReadKey();


        }
        
    }
}
