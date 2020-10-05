using System;

namespace Lesson_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //инициализируем генератор случайных чисел
            int[] myArray;
            int n = rnd.Next(5, 10); //генерируем случайное число из диапазона [5..10)
            myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(10); // заполняем массив случайными числами
            }
            foreach (int elem in myArray) //выводим массив на экран
            {
                Console.Write("{0} ", elem);
            }
        }
    }
}
