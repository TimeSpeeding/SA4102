using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H7
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            SetArray(a, 1);
            Console.WriteLine(String.Join(", ", a));
        }
        static void SetArray(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }
    }
}
