using System;

namespace lesson_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Input();
            int index;
            int min = Min(a, out index);
            Console.WriteLine("min = {0} \t index of min = {1}", min, index);
        }
        static int [] Input()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());           
            int[] a = new int[n];
            for(int i =0; i < n; i++)
            {
                Console.Write("a[{0}] = ",i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(a);
            return a;
        }
        static int Min (int[]a, out int index)
        {
            int min = a[0];
            index = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (min > a[j])
                {
                    min = a[j];
                    index = j;
                    Console.WriteLine(index);
                }
            }
            return min;
        } 
    }
}
