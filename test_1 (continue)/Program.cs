using System;

namespace lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
             
            if (i < 18)
            {
                Console.WriteLine("Ребенок");
            }
            if (i >= 18 && i < 70)
            {
                Console.WriteLine("Взрослый");
            }
            if(i>=70)
            {
                Console.WriteLine("Старик");
            }
        }
    }
}
