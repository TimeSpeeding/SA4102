using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E1
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            long f = 1;
            //a
            for (int i = 1; i <= n; i++) f *= i;
            //b
            //for (int i = n; i > 0; i--) f *= i;
            Console.WriteLine($"The factorial of {n} is {f}");
        }
    }
}
