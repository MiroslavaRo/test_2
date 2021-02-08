using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());//приобразовывает строку, котторую юзор вводит с клавы, в целое число
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a+b+c);
        }
    }
}
