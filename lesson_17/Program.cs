using System;

namespace lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int s = 0;
            
            if (x*y > 0)
            {
                s = (x + y)*2;
               Console.WriteLine(s);
            }
            if (x * y == 0)
            {
                s = 0;
                Console.WriteLine(s);
            }
            else
            {
                s = 2 * Math.Abs(x) * y;
                Console.WriteLine(s);
                
            }

        }

    }
}

