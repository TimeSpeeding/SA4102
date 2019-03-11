using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C5
    {
        static void Main()
        {
            Console.Write("Please enter a three-digit integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            double result = 0;
            while (temp > 0)
            {
                result += Math.Pow(temp % 10, 3);
                temp /= 10;
            }
            if (result == n)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
