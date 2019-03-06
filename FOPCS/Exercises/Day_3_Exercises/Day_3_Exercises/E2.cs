using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class E2
    {
        static void Main()
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------------------------------");
            for (double i = 1; i <= 10; i++)
            {
                //pay attention to the format you need to output
                Console.WriteLine($"{i:0.0}\t\t{1 / i:0.0##}\t\t{Math.Sqrt(i):0.0##}\t\t{i * i:0.0}");
            }
        }
    }
}
