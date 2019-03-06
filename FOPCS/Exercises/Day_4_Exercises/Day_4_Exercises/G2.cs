using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G2
    {
        static void Main()
        {
            int[] a = new int[10] { 3, 7, 2, 1, 8, 9, 6, 4, 0, 5 };
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Pass {i + 1}: ");
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[j] > a[i])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    Console.WriteLine($"\t{a[0]} {a[1]} {a[2]} {a[3]} {a[4]} {a[5]} {a[6]} {a[7]} {a[8]} {a[9]}");
                }
            }
        }
    }
}
