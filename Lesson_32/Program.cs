using System;

namespace Lesson_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Console.WriteLine($"Гласных {Vovels(ch)}\nСогласных {(Consonants(ch)- Vovels(ch))}");
        }
        static int Vovels(char[] ch)
        {
            char[] vovels = { 'у', 'е', 'а', 'о', 'ы', 'я', 'и', 'ю', 'э' };
            int gl = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < vovels.Length; j++)
                {
                    if (ch[i] == vovels[j])
                    {
                        gl++;
                       
                    }

                }
            }
            return gl;
        }
        static int Consonants(char[] ch)
        {
            char[] vovels = { 'у', 'е', 'а', 'о', 'ы', 'я', 'и', 'ю', 'э' };
            int sog=0;
            for (int i =0; i < ch.Length; i++)
            {
                if (char.IsLetter(ch[i]))
                {
                    sog++;
                   
                }
            }

            return sog;
        }
    }
}
