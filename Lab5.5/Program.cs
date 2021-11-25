using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int M = N;
            int[,] array = new int[N, M];
            array [1, 1] = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < M; j++)
                {
                    array[i, j] = 1 - (i + j)%2;
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}