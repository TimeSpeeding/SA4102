using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B4
    {
        static void Main()
        {
            Console.Write("Please enter the Centigrade temperature: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Fahrenheit temperature is {t * 1.8 + 32}");
        }
    }
}
