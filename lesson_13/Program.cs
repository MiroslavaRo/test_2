using System;

namespace lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 0)
            {
                Console.WriteLine(2 * x - 10);
            }
            else
            {
                Console.WriteLine((2*Math.Abs(x))-1);
            }
        
        }
    
    }

}
