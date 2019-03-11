using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B5
    {
        static void Main()
        {
            Console.Write("Please enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y is {5 * x * x - 4 * x + 3}");
        }
    }
}
