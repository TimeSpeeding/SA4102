using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C2
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string n = Console.ReadLine();
            Console.Write("Please enter your gender: ");
            string g = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 40)
            {
                if (g == "M")
                {
                    Console.WriteLine($"Good Morning Mr. {n}!");
                }
                else if (g == "F")
                {
                    Console.WriteLine($"Good Morning Ms. {n}!");
                }
            }
            else
            {
                if (g == "M")
                {
                    Console.WriteLine($"Good Morning Uncle {n}!");
                }
                else if (g == "F")
                {
                    Console.WriteLine($"Good Morning Aunty {n}!");
                }
            }
        }
    }
}
