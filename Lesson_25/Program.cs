using System;

namespace Lesson_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type quantity of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] A = new float[n];
            float sum;
            int i = 0;
            Console.WriteLine("Type elements of array: ");
            while (i < n)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            sum = 0;
            i = 0;
            while (i < n)
            {
                sum += A[i];
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
