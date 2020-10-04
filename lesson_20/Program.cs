using System;

namespace lesson_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
           // int C = A + 1;
            do
                if (A % 2 == 0 && A % 3 == 0)
                {
                    Console.WriteLine("{0} ", A++);
                    
                }
            else
                {
                    A++;
                }

            
            while (A < B);
        }
    }
}
