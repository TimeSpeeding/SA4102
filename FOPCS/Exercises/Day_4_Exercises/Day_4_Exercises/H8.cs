using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H8
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join(", ", ResizeArray(a, 10)));
        }
        static int[] ResizeArray(int[] arr,int newSize)
        {
            int[] newArray = new int[newSize];
            Array.Copy(arr, newArray, arr.Length);
            return newArray;
        }
    }
}
