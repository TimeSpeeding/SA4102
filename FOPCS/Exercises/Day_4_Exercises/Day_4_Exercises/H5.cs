using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H5
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"{i}\t{ChangeintoHEX(i)}\t{Convert.ToString(i,16)}");
            }
        }
        static string ChangeintoHEX(int a)
        {
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string s = "";
            if (a < 16) s = hex[a];
            else s = hex[a / 16] + hex[a % 16];
            return s;
        }
    }
}
