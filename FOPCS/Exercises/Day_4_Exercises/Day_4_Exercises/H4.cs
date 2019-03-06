using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H4
    {
        static void Main()
        {
            Console.Write("Enter string 1: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string 2: ");
            string s2 = Console.ReadLine();
            Console.WriteLine(FindWord(s1, s2));
        }
        static int FindWord(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            int p = -1;
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2)
                {
                    p = i;
                    break;
                }
            }
            return p;
        }
    }
}
