using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Exercises
{
    class C4
    {
        static void Main()
        {
            Console.Write("Please enter the distance travelled: ");
            double d = Convert.ToDouble(Console.ReadLine());
            d = Math.Ceiling(d * 10) / 10;
            double c = 0;
            if (d <= 0.5)
            {
                c = 2.4;
            }
            else if (d <= 9)
            {
                c = 2.4 + (d - 0.5) * 0.4;
            }
            else
            {
                c = 5.8 + (d - 9) * 0.5;
            }
            Console.WriteLine($"The charges you need to pay is ${c}");
        }
    }
}
