using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type quantity of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] Array1 = new float[n];
            Console.WriteLine("Type elements of array: ");
            for (int i =0; i < n; i++)
            {
                Array1[i]= Convert.ToInt32(Console.ReadLine());
                
            }     
            foreach(int elem in Array1)
            {
                Console.WriteLine(elem * 3);
            }

        }
    }
}
