using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E4
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
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
            if (sum == n) Console.WriteLine($"Number {n} is a perfect number.");
            else Console.WriteLine($"Number {n} is Not a perfect number.");
        }
    }
}
