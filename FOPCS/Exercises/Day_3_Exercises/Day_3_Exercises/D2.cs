using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class D2
    {
        static void Main()
        {
            Console.Write("Please enter the number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number b: ");
            int b = int.Parse(Console.ReadLine());
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            int hcf, lcm;
            while (min != max)
            {
                max = max - min;
                if (min > max)         //if min is larger than max, exchange them
                {
                    int temp = min;  
                    min = max;
                    max = temp;
                }
            }
            hcf = min;
            lcm = a * b / hcf;
            Console.WriteLine($"A = {a}; B = {b}; HCF = {hcf}; LCM = {lcm};");
        }
    }
}
