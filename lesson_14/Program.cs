using System;

namespace lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n % 7;
                switch (n)
                {
                    case 1%7:
                        Console.WriteLine("Понедельник"); //если знач n % 7 =  1%7, тогда вывед "пон" (остаток от деления будет одинаковый)
                    break;
                    case 2%7:
                        Console.WriteLine("Вторник");
                        break;
                    case 3%7:
                        Console.WriteLine("Среда");
                        break;
                    case 4%7:
                        Console.WriteLine("Четверг");
                        break;
                    case 5%7:
                        Console.WriteLine("Пятница");
                        break;
                    case 6%7:
                        Console.WriteLine("Суббота");
                        break;
                    case 7%7:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            
        }
    }
}
    

