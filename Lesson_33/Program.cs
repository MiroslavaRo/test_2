using System;

namespace Lesson_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for (int i =0; i < ch.Length; i++)
            {
                if (char.IsLetter(ch[i]))
                {
                    if (char.IsUpper(ch[i]))
                    {
                        ch[i] = char.ToLower(ch[i]);
                    }
                    else
                    {
                        ch[i] = char.ToUpper(ch[i]);
                    }
                }
            }
            Console.WriteLine(ch);
        }
    }
}
