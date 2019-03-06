using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H10
    {
        static void Main()
        {
            int[,] a = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] b = new int[2, 3] { { 9, 10, 11 }, { 12, 13, 14 } };
            int[,] c = MatrixMultiply(a, b);
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int ax = A.GetLength(0), ay = A.GetLength(1);
            int bx = B.GetLength(0), by = B.GetLength(1);
            int[,] ans = new int[ax, by];
            for (int i = 0; i < ax; i++)
            {
                for (int j = 0; j < by; j++)
                {
                    ans[i, j] = 0;
                    for (int k = 0; k < ay; k++)
                    {
                        ans[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return ans;
        }
    }
}
