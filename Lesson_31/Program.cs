using System;

namespace lesson_31
{

        class Program
        {
            static void Main(string[] args)
            {

                string fwd = Console.ReadLine();
                string rvs = Reverse(fwd);
                Console.WriteLine(rvs);
                Console.ReadKey();

            }

            private static string Reverse(string fwd)
            {
            char[] carr = fwd.ToCharArray();            
            char temp;            
            int j= carr.Length - 1;
            for (int i = 0; i < j; i++)
                {
                temp = carr[i];
                carr[i] =carr[j];
                carr[j] = temp;
                j--;
            }
            return new string(carr);
            }
        }
    
}
