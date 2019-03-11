using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B10
    {
        static void Main()
        {
            Console.WriteLine("Please enter the lengths of a triangle's three sides a, b and c.");
            Console.Write("Please enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;
            Console.WriteLine($"The area of the triangle is {Math.Sqrt(s * (s - a) * (s - b) * (s - c))}");
        }
    }
}
