using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G8
    {
        static void Main()
        {
            int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            Console.Write("Enter a number: ");
            int cn = int.Parse(Console.ReadLine());  //check number
            bool flag = false;
            int x = 0, y = 0;
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i,j] == cn)
                    {
                        flag = true;
                        x = i; y = j;
                    }
                }
            }

            if (!flag) Console.WriteLine($"Number {cn} is not found in the array.");
            else Console.WriteLine($"Number {cn} is found in the array at [{x},{y}].");
        }
    }
}
