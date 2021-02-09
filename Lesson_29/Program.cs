using System;

namespace lesson_29
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int elem in a)
            {
                sum += elem;
            }
            return sum;
        }
        static void Main()
        {
            int[] a = Input();
            Console.WriteLine("Сумма элементов массива={0}", Sum(a));
        }
    }
}
