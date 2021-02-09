using System;

namespace Lesson_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            lesson3();
            lesson4();
            lesson5();
            lesson6();
            lesson7();
            lesson8();
            lesson9();
            lesson10();
            lesson11();
        }

        static void lesson3()
        {
            double x = 5.25;
            double y = 3;
            Console.WriteLine("{0:f4}", x * y); //выводит произведение с 4 знаками после запятой  
        }
        static void lesson4()
        {
            int a = int.Parse(Console.ReadLine());//приобразовывает строку, котторую юзор вводит с клавы, в целое число
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b + c);
        }
        static void lesson5()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}", a / b);
        }
        static void lesson6()
        {
            int nom = int.Parse(Console.ReadLine());
            int kolvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма денег = {0:C}", nom * kolvo);//выводит в денежном формате
        }
        static void lesson7()
        {
            string name = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}, твой год рождения {1}", name, 2019 - b);
        }
        static void lesson8()
        {
            int i = 256;
            byte y = 4;
            int a = (int)y;//преобраз без потери точности
            byte b = (byte)i;// преобразовывает с потерей точности (байт до 255)
            Console.WriteLine("{0} {1}", a, b);
        }
        static void lesson9()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = (a > b) ? a : b;//если операнд 1 (лог выражение) правильно, то макс=операнд 2, если нет - макс=опереанд 3
            Console.WriteLine(max);
        }
        static void lesson10()
        {
            int a = 10, b = 3;
            int c = (a++) - b;
            b += c * a;
            Console.WriteLine(b);
        }
        static void lesson11()
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
            else
            {
                Console.WriteLine("Старик");
            }
        }
    }
}
