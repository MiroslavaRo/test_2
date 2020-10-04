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
            for (int i = 3; i <= C; i += 3)
            {
                d++;

//                Console.WriteLine(i);
            }
            Console.WriteLine("дня {0}", d);
        }
    }
}
/*В компьютер князя Владимира поступили сведения о количестве змеев-горынычей и количестве голов у каждого из них. 
Илья Муромец срубает 3 головы в день. 
Используя цикл For решите, за сколько дней богатырь срубит все головы*/
