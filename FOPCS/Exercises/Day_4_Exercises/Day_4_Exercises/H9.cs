using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H9
    {
        static void Main()
        {
            for (int i = 5; i <= 1000; i++)
            {
                if (IsPrime(i)) Console.WriteLine($"{i} True");
                else Console.WriteLine($"{i} False");
            }
        }
        static bool IsPrime(int n)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) flag = false;
            }
            return flag;
        }
    }
}
