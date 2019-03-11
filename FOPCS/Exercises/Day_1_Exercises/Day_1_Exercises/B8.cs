using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B8
    {
        static void Main()
        {
            Console.Write("Please enter the distance: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total fare is {Math.Round(d * 0.4 + 2.4, 1):0.00}");
        }
    }
}
