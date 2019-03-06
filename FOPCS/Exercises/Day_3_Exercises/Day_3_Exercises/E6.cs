using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E6
    {
        static void Main()
        {
            Console.WriteLine("All the perfect numbers from 1 to 1000 are as follows.");
            for (int n = 1; n <= 1000; n++)
            {
                int sum = 1;
                //factors appear in pairs,except sqrt(n) is an integer
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        if (n == i * i) sum += i;
                        else sum = sum + i + n / i;
                    }
                }
                if (sum == n) Console.WriteLine($"{n}");
            }
        }
    }
}
