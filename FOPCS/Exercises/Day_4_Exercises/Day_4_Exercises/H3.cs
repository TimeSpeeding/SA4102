using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H3
    {
        static void Main()
        {
            Console.Write("Enter string 1: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string 2: ");
            string s2 = Console.ReadLine();
            if (InString(s1, s2)) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
        static bool InString(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool flag = false;
            for (int i = 0; i <= s1.Length - s2.Length; i++ )
            {
                if (s1.Substring(i, s2.Length) == s2)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
