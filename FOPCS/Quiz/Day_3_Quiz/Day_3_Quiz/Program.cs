using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Please pay $");
            if (a > 12)
            {
                Console.WriteLine($"{a * 500 * 0.92:#,#.00}");
            }
            else if(a > 6)
            {
                Console.WriteLine($"{a * 500 * 0.95:#,#.00}");
            }
            else if (a > 4)
            {
                Console.WriteLine($"{a * 500 * 0.97:#,#.00}");
            }
            else
            {
                Console.WriteLine($"{a * 500:#,#.00}");
            }
        }
    }
}
