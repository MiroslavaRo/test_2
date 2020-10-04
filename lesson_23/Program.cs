using System;

namespace lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = A*B;
            int d = 0;

            for (int i = 1; i <= C; i++)
            {
                C -= 3;
                d = i;
            }
            if (d == 1)
            {
                Console.WriteLine("дня {0}", d);
            }
            else
            {
                Console.WriteLine("дня {0}", d + 1);
            }
                
        }

            
        }
            
        
    
}
/*В компьютер князя Владимира поступили сведения о количестве змеев-горынычей и количестве голов у каждого из них. 
Илья Муромец срубает 3 головы в день. 
Используя цикл For решите, за сколько дней богатырь срубит все головы*/
