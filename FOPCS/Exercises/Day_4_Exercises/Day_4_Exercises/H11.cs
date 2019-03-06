using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H11
    {
        delegate double DoubleOps(double x);
        static void Main()
        {
            double[] a = new double[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join(", ", a));

            DoubleOps myop = (double m) => { return Math.Sqrt(m); };
            Console.WriteLine(String.Join(", ", ProcessArray(a, myop)));
            myop = (double m) => { return m * m; };
            Console.WriteLine(String.Join(", ", ProcessArray(a, myop)));
        }
        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newArray = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = ops(arr[i]);
            }
            return newArray;
        }
    }
}
