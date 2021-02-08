using System;

namespace lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom = int.Parse(Console.ReadLine());
            int kolvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма денег = {0:C}",nom*kolvo);//выводит в денежном формате
        }
    }
}
