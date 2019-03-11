using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B3
    {
        static void Main()
        {
            Console.Write("Please enter your salary: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your total income is ${n*1.13:0.00}");
        }
    }
}
