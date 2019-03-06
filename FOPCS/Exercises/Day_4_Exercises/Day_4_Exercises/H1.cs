using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class H1
    {
        static void Main()
        {
            ReadInteger("Enter a integer: ");
        }
        static int ReadInteger(string x)
        {
            bool canParse = false;
            int output = -1;
            while (!canParse)
            {
                Console.Write(x);
                string input = Console.ReadLine();
                canParse = int.TryParse(input, out output);
            }
            return output;
        }
    }
}
