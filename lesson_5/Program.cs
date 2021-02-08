using System;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}",a/b);
        }
    }
}
