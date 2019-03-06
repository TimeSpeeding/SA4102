using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F5_plus
    {
        public class Student : IComparable
        {
            public string Name { get; set; }
            public int Mark { get; set; }
            
            public int CompareTo(object obj)
            {
                if (obj is Student)
                {
                    return Mark.CompareTo(((Student)obj).Mark);
                }
                return 1;
            }
        }
        public class StudentNameComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
        static void Main()
        {
            Student[] students = new Student[]{
                new Student() {Name = "John", Mark = 63},
                new Student() {Name = "Venkat", Mark = 29},
                new Student() {Name = "Mary", Mark = 75},
                new Student() {Name = "Victor", Mark = 82},
                new Student() {Name = "Betty", Mark = 55},
            };
            Console.WriteLine("--Sorted by marks--");
            Console.WriteLine("Name\tMark");
            Array.Sort(students);
            Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format($"{s.Name}\t{s.Mark}")));

            Console.WriteLine("\n--Sorted by names--");
            Console.WriteLine("Name\tMark");
            Array.Sort(students, new StudentNameComparer());
            Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format($"{s.Name}\t{s.Mark}")));
        }
    }
}
