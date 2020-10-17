using System;

namespace Lesson_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int index = 0;
            string str = Console.ReadLine();
            char[] div = {' '};
            string []s = str.Split(div);
            for(int i =0; i < s.Length; i++)
            {                
                max = max > s[i].Length ? max : s[i].Length;
                index = i;               
            }
            Console.WriteLine(s[index]);

        }
    }
}
