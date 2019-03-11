using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B9
    {
        static void Main()
        {
            Console.Write("Please enter the distance: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total fare is {Math.Ceiling(d * 4 + 24) / 10}");
        }
    }
}
