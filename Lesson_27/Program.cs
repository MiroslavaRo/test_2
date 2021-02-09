using System;

namespace lesson_27
{
    class Program
    {
        static void Print(int[,] a)//вывод массива
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Input(out int[,] a)
        {
            Console.Write("n= "); //длина массива
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");//ширина массива
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            for (int i = 0; i < a.GetLength(0); i++) //заполнение массива
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Change(int[,] a) // изменение массива
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] % 2 == 0)
                    {
                        a[i, j] = 0;
                    }
        }
        static void Main()
        {
            int[,] a;
            Input(out a); //заполняем каждый элемент массива
            Console.WriteLine("Исходный массив:");
            Print(a); // выводим массив
            Change(a);//изменяем
            Console.WriteLine("Измененный массив:");
            Print(a);//выводим измененный массив
        }
    }
}
