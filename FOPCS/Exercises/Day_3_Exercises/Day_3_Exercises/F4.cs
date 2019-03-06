using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F4
    {
        static void Main()
        {
            Console.WriteLine("Please enter the sentence: ");
            string s = Console.ReadLine();
            //change the first letter of the whole sentence into upper
            s = s.Substring(0, 1).ToUpper() + s.Substring(1);
            for (int i = 0; i < s.Length; i++)
            {
                //when meet with a space, means the next letter need to be change into upper
                if(s[i] == ' ')
                {
                    //form the new sentence with 3 parts:
                    //the letters before the space(include the space)
                    //the next letter after the space, which need to change into upper
                    //other letters after the upper letter
                    s = s.Substring(0, i + 1) + s.Substring(i + 1, 1).ToUpper() + s.Substring(i + 2);
                }
            }
            Console.WriteLine("\nThe first letter of every word has been changed into upper.");
            Console.WriteLine($"{s}");
        }
    }
}
