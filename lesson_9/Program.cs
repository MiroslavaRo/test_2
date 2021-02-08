using System;

namespace lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = (a > b) ? a : b;//если операнд 1 (лог выражение) правильно, то макс=операнд 2, если нет - макс=опереанд 3
            Console.WriteLine(max);
        }
    }
}
