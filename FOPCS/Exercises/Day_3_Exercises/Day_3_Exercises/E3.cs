using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E3
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int times = 0;
            //because factor comes in pairs, so stop at sqrt(n) to reduce calculate time
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) times++;
            }
            if (times == 0) Console.WriteLine($"Number {n} is Prime.");
            else Console.WriteLine($"Number {n} is Not Prime.");
        }
    }
}
