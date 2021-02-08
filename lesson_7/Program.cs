using System;

namespace lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}, твой год рождения {1}", name, 2019-b);
        }
    }
}
