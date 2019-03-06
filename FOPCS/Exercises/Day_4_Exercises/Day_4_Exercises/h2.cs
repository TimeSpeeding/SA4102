using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H2
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            PrintArray(a);
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($" {arr[i]},");
            }
            Console.Write($" {arr[arr.Length - 1]} ");
            Console.WriteLine("}");
        }
    }
}
