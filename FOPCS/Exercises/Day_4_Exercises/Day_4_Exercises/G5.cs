using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G5
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Enter a number: ");
            int cn = int.Parse(Console.ReadLine());  //check number
            int p = -1; //position
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == cn) p = i;
            }
            if (p == -1) Console.WriteLine($"Number {cn} is not found in the array");
            else Console.WriteLine($"Number {cn} is found in the array at the element no {p + 1}.");
        }
    }
}
