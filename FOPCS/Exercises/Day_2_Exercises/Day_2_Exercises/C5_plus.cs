using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C5_plus
    {
        static void Main()
        {
            for (int n = 100; n < 1000; n++)
            {
                int temp = n;
                double result = 0;
                while (temp > 0)
                {
                    result += Math.Pow(temp % 10, 3);
                    temp /= 10;
                }
                if (result == n) Console.WriteLine($"{n}");
            }
        }
    }
}
