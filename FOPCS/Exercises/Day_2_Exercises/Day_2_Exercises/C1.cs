using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C1
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string n = Console.ReadLine();
            Console.Write("Please enter your gender: ");
            string g = Console.ReadLine();
            if (g == "M")
            {
                Console.WriteLine($"Good Morning Mr. {n}!");
            }
            else if (g == "F")
            {
                Console.WriteLine($"Good Morning Ms. {n}!");
            }
        }
    }
}
