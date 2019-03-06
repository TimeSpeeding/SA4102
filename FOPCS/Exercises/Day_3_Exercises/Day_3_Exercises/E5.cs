using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E5
    {
        static void Main()
        {
            Console.WriteLine("All the prime numbers from 5 to 10000 are as follows.");
            for (int n = 5; n <= 10000; n++)
            {
                int times = 0;
                //because factor comes in pairs, so stop at sqrt(n) to reduce calculate time
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) times++;
                }
                if (times == 0) Console.WriteLine($"{n}");
            }
        }
    }
}
