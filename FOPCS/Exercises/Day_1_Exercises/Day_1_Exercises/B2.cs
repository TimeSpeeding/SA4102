using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B2
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The square root of this number is {Math.Sqrt(n):0.000}");
        }
    }
}
