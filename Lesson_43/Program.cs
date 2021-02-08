using System;
using System.Linq;

namespace Lesson_43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = {"один два три",  "четыре пять шесть",  "семь восемь девять десять"};
            var query =
                from lines in strings
                let words = lines.Split(' ')
                from word in words
                where word[0] == 'д'
                select word;
            foreach(var item in query)
            {
                Console.WriteLine($"{item} ");
            }

        }
    }
}
