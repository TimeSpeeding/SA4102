using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F1
    {
        static void Main()
        {
            Console.Write("Please enter the phrase: ");
            string s = Console.ReadLine();
            int[] a = new int[5] { 0, 0, 0, 0, 0 }; //number of a,e,i,o,u
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') a[0]++;
                else if (s[i] == 'e') a[1]++;
                else if (s[i] == 'i') a[2]++;
                else if (s[i] == 'o') a[3]++;
                else if (s[i] == 'u') a[4]++;
            }
            Console.WriteLine($"Number of a is {a[0]}");
            Console.WriteLine($"Number of e is {a[1]}");
            Console.WriteLine($"Number of i is {a[2]}");
            Console.WriteLine($"Number of o is {a[3]}");
            Console.WriteLine($"Number of u is {a[4]}");
        }
    }
}
