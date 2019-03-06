using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F2
    {
        static void Main()
        {
            Console.Write("Please enter the string: ");
            string s = Console.ReadLine();
            bool flag = true;
            //to reduce caculate time, we only need to check half string
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) flag = false;
            }
            if (flag) Console.WriteLine("The string you entered is a palindrome.");
            else Console.WriteLine("The string you entered is Not a palindrome.");
        }
    }
}
