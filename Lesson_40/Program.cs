using System;
using System.Text;

namespace Lesson_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "первый второй первый";
            string s = Console.ReadLine();
            var array = s.Split(' ');
            int k = 0;
            Console.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= 0; j--)
                {
                    if (array[i] == array[j])
                    {
                        k++;
                    }
                }
                if (k == 1)
                {
                    Console.WriteLine(array[i]);
                }
                k = 0;
            }
        }
    }
}