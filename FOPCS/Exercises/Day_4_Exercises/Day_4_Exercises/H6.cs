using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H6
    {
        static void Main()
        {
            Console.Write("Enter the string: ");
            string s = Console.ReadLine();
            Console.Write("Enter the word you want to change: ");
            char c1 = char.Parse(Console.ReadLine());
            Console.Write("Enter the word you want to change into: ");
            char c2 = char.Parse(Console.ReadLine());
            Console.WriteLine($"\n{Substitute(s, c1, c2)}");
        }
        static string Substitute(string s, char c1, char c2)
        {
            string result = "";
            for (int i = 0; i <s.Length; i++)
            {
                if (s[i] == c1) result += c2;
                else result += s[i];
            }
            return result;
        }
    }
}
