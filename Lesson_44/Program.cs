using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_44
{
    class Program
    {
        static List<Student> students = new List<Student>() {
                new Student{Name="Иванов", GroupID=001},
                new Student{Name="Петров", GroupID=002},
                new Student{Name="Сидоров", GroupID=002},
                new Student{Name="Смирнов", GroupID=002},
                new Student{Name="Ткачев", GroupID=003},
                new Student{Name="Цукерман", GroupID=003},
                new Student{Name="Токарев", GroupID=001},
                new Student{Name="Оганесян", GroupID=002},
        };
        static void Main(string[] args)
        {
            
            SimpleGroup();
            Console.WriteLine();
            GroupMoreTwo();
            Console.WriteLine();
            Console.ReadLine();

        }
        static void SimpleGroup()
        {
            var query =
               from student in students
               group student by student.GroupID;
            foreach (var items in query)
            {
                Console.Write($"Group #{items.Key}: ");
                foreach (var i in items)
                {
                    Console.Write($"{i.Name} ");
                }
                Console.WriteLine();
            }
        }
        static void GroupMoreTwo()
        {
            var query =
                from stud in students
                group stud by stud.GroupID into Group
                where Group.Count() > 2
                select Group;
            foreach(var item in query)
            {
                Console.Write($"Group #{item.Key}: ");
                foreach(var i in item){
                    Console.Write($"{i.Name} ");
                }
                Console.WriteLine();
            }
        }
       
    }
}
