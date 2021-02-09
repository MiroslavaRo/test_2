using System;

namespace lesson_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] div = { ' ' };
            
            string[] parts = str.Split(div);
            for (int i = 0; i < parts.Length; i++)
            {
                char[] ch = parts[i].ToCharArray();
                if (P(ch))
                {
                    Console.WriteLine(parts[i]);
                }                     
            }           

        }
        static bool P(char[] ch)
        {
            bool p = false;
            for (int j = 0; j < ch.Length; j++)
            {
                if (ch[j] == ch[ch.Length - 1 - j])
                {
                    p = true;
                }
                else
                {
                    p = false; //если хотя бы один false в цикле - все выражение false

                }
            }
            return p;
        }
      
    }
}
