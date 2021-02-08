using System;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            byte y = 4;
            int a = (int)y;//преобраз без потери точности
            byte b = (byte)i;// преобразовывает с потерей точности (байт до 255)
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
