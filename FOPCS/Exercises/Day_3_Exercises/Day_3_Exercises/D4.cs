using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class D4
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.Write("Please enter the number N: ");
            int n = int.Parse(Console.ReadLine());
            double g = rnd.NextDouble() * (n - 1) + 1;       //get a random double number from 1 to n
            while (Math.Abs(n - g * g) > 0.0000001)
            {
                g = (g + n / g) / 2;
            }
            Console.WriteLine($"The square root of {n} is {g:0.000}");
        }
    }
}
