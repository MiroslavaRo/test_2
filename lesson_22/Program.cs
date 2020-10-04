using System;

namespace lesson_22
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            do
                if (A % 2 == 0)
                {
                    int C = A*A;
                    Console.Write("{0} ", C);
                        A++;

                }
                else
                {
                    A++;
                }
            while (A <= B);
        }
    }
}
