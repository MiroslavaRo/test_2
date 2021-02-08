using System;

namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            int c = (a++) - b;
            b += c * a;
            Console.WriteLine(b);
        }
    }
}
