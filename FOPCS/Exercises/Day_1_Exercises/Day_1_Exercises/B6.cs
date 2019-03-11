using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Exercises
{
    class B6
    {
        static void Main()
        {
            Console.WriteLine("Please enter the coordinates of two points.");
            /*Console.Write("Please enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());*/
            Console.WriteLine("Enter x1 y1 x2 y2 (seperated with space): ");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(' ');
            double x1 = Convert.ToDouble(inputnum[0]);
            double y1 = Convert.ToDouble(inputnum[1]);
            double x2 = Convert.ToDouble(inputnum[2]);
            double y2 = Convert.ToDouble(inputnum[3]);
            Console.WriteLine($"The Distance is {Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))}");
        }
    }
}
