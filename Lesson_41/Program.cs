using System;
using System.Linq;

namespace Lesson_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [10];
            for(int i=0; i<array.Length;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var high =
                from a in array
                where a > 176
                select a;
            foreach(var h in high)
            {
                Console.Write($"{h} ");
            }
        }
    }
}
