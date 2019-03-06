using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G1
    {
        static void Main()
        {
            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            int[] sales = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int sum = sales[0];
            int minm = 0; //which month have the min sales
            int mins = sales[minm];
            int maxm = 0; //which month have the min sales
            int maxs = sales[maxm];
            //search the whole sales array, if we find current month's sales is larger than the max or smaller than the min, exchange them
            for (int i = 1; i < 12; i++)
            {
                if (sales[i] < mins)
                {
                    minm = i;
                    mins = sales[i];
                }
                else if (sales[i] > maxs)
                {
                    maxm = i;
                    maxs = sales[i];
                }
                sum += sales[i];
            }
            double avg = sum / 12.0;
            Console.WriteLine($"The maximum sales is ${maxs}. It happens in {month[maxm]}.");
            Console.WriteLine($"The minimum sales is ${mins}. It happens in {month[minm]}.");
            Console.WriteLine($"The average monthly sales for the year is ${avg}.");
        }
    }
}
