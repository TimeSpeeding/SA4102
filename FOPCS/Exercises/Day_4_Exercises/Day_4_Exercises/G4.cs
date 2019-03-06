using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G4
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 };
            Console.Write("[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write($" {a[i]},");
            }
            Console.WriteLine($" {a[a.Length - 1]} ]");
        }
    }
}
