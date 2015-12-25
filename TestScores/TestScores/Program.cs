using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student() {Name="Kevin",Chinese=20,English=60,Math=71 },
                new Student() {Name="Albert",Chinese=60,English=50,Math=53 },
                new Student() {Name="Pauline",Chinese=90,English=40,Math=64 },
                new Student() {Name="Betty",Chinese=30,English=100,Math=82 }
            };
            //未排序

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("依國文成績排序");
                        Array.Sort(students);
                        break;

                    case 2:
                        Console.WriteLine("依英文成績排序");
                        Array.Sort(students, new Student.sortEnglish());
                        break;

                    case 3:
                        Console.WriteLine("依數學成績排序");
                        Array.Sort(students, new Student.sortMath());
                        break;

                    case 4:
                        Console.WriteLine("依總分排序");
                        Array.Sort(students, new Student.sortTotal());
                        break;

                    default:
                        Console.WriteLine("未排序");
                        break;
                }
                Console.WriteLine("=====================================");
                Console.WriteLine("姓名\t國文\t英文\t數學\t總分");
                Console.WriteLine("=======\t====\t====\t====\t====");
                foreach (Student student in students)
                {
                    Console.WriteLine(student.Print());
                }
                Console.WriteLine("");
            }
        }
    }
}