using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F6
    {
        static void Main()
        {
            Console.Write("Please enter your matriculation number: ");
            string s = Console.ReadLine();
            string check = "OPQRS";
            //extract 5 numbers
            int n = int.Parse(s.Substring(1, 5));
            int sum = 0;
            //calculate the sum from the last one to the first one
            for (int i = 2; i <= 6; i++)
            {
                sum += (n % 10) * i;
                n /= 10;
            }
            sum %= 5;
            if (s[6] == check[sum]) Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");
        }
    }
}
