using System;

namespace lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());            
            do
                if (A % 2!= 0 && A % 5 == 0)
                {
                    Console.Write("{0} ", A++);

                }
                else
                {
                    A++;
                }
            while (A <= B);
        }
    }
}
