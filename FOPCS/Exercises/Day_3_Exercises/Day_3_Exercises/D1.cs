using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class D1
    {
        static void Main()
        {
            int a = 0;
            while (a != 88)
            {
                Console.Write("Please enter a number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.WriteLine("Lucky you...");
        }
    }
}
