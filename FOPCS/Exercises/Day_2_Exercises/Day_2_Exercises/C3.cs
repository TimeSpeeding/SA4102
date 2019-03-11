using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C3
    {
        static void Main()
        {
            Console.Write("Please enter your grade: ");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g < 0 || g >100)
            {
                Console.WriteLine("**Error**");
            }
            else if (g >= 80)
            {
                Console.WriteLine($"You scored {g} marks which is A grade");
            }
            else if (g >= 60)
            {
                Console.WriteLine($"You scored {g} marks which is B grade");
            }
            else if (g >= 40)
            {
                Console.WriteLine($"You scored {g} marks which is C grade");
            }
            else
            {
                Console.WriteLine($"You scored {g} marks which is F grade");
            }
        }
    }
}
