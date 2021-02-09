using System;
using System.Dynamic;

namespace lesson_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int max = 0;
            for (int n2 = 0; n2 < a.GetLength(0); n2++)
            {
                for (int f = 0; f < a.GetLength(1); f++)
                {
                    max = max < a[n2, f] ? a[n2, f] : max;
                    
                }
                Console.Write(max + " "); //выведет максимальные значения в каждой СТРОКЕ
            }

           // Console.Write(max + " ");//выведет макс значение ВО ВСЕМ МАССИВЕ
        }
    }
}
