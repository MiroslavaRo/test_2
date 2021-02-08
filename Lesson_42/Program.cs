using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_42
{
    class Program
    {
        static List<Group> Groups = new List<Group>()
        {
            new Group(){Name="Начальный уровень", GroupID=001},
            new Group(){ Name="Базовый уровень", GroupID=002},
            new Group(){ Name="Продвинутый уровень", GroupID=003}
        };        //создали второй источник данных
        static List<Student> Students = new List<Student>()
        {
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
            InnerJoin();
            Console.WriteLine();
           GroupJoin();
            Console.ReadKey();          
        }
        static void InnerJoin()
        {
            var query =
                from itemGroup in Groups
                join itemStudent in Students
                on itemGroup.GroupID equals itemStudent.GroupID
                select new { Group = itemGroup.Name, Student = itemStudent.Name };
                Console.WriteLine("==============Внутреннее соединение===============");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Group}: {item.Student}");
            }
        }
        static void GroupJoin()
        {
            var query =
                from itemGroup in Groups
                orderby itemGroup.GroupID
                join itemStudent in Students
                on itemGroup.GroupID equals itemStudent.GroupID into NewGroup
                select new { Group = itemGroup.Name, Student =
                from s in NewGroup
                orderby s.Name
                select s
                };
            Console.WriteLine("==============Групповое соединение===============");
            foreach (var group in query)
            {
                Console.Write($"{group.Group}: ");
                foreach(var item in group.Student)
                {
                    Console.Write($"{item.Name} ");
                }
                Console.WriteLine();
            }

        }

    }
}
