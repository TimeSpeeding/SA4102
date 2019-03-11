using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B7
    {
        static void Main()
        {
            Console.Write("Please enter the distance: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total fare is {0.4 * d + 2.4}");
        }
    }
}
