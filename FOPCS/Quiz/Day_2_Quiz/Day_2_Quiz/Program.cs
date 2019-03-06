using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Quiz
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the lenth in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The length in inch is {Math.Floor(cm / 2.54 * 1000) / 1000:0.000}");
        }
    }
}
