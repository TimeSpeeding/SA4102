using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F3
    {
        static void Main()
        {
            Console.Write("Please enter the string: ");
            string s = Console.ReadLine();
            string sr = "";
            s = s.ToLower();  //let all the letters in lower type
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
            {
                //pick out all the letters without space and punctuation
                if (s[i] >= 'a' && s[i] <= 'z') sr = sr + s[i];
            }
            for (int i = 0; i <= sr.Length / 2 - 1; i++)
            {
                //check the new string as f2
                if (sr[i] != sr[sr.Length - i - 1]) flag = false;
            }
            if (flag) Console.WriteLine("The string you entered is a palindrome.");
            else Console.WriteLine("The string you entered is Not a palindrome.");
        }
    }
}
