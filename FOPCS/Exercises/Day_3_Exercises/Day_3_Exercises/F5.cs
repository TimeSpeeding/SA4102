using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class F5
    {
        static void Main()
        {
            //f5_plus is a advance version of this question
            //f5 is writen in the methods have been taught in slides FOPCS 0 to 9
            string[] name = new string[] {"John","Venakt","Mary","Victor","Betty"};
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            for (int i = 0; i < 5; i++)
            {
                int n = i;
                int max_mark = mark[i]; 
                //find the max mark from i to last, and exchange i with the max
                for (int j = i + 1; j < 5; j++)
                {
                    if (mark[j] > max_mark)
                    {
                        n = j;
                        max_mark = mark[j];
                    }
                }
                //when exchange the mark, name is also need to be exchange, make the name can be combined with mark
                int tempm = mark[n];
                mark[n] = mark[i];
                mark[i] = tempm;
                string tempn = name[n];
                name[n] = name[i];
                name[i] = tempn;
            }
            Console.WriteLine("--Sorted by marks--");
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{name[i]}\t{mark[i]}");
            }
            for (int i = 0; i < 5; i++)
            {
                int n = i;
                string min_name = name[i];
                //need to find smallest name 
                for (int j = i + 1; j < 5; j++)
                {
                    if (name[j].CompareTo(min_name) == -1)
                    {
                        n = j;
                        min_name = name[j];
                    }
                }
                //when exchange the mark, name is also need to be exchange, make the name can be combined with mark
                int tempm = mark[n];
                mark[n] = mark[i];
                mark[i] = tempm;
                string tempn = name[n];
                name[n] = name[i];
                name[i] = tempn;
            }
            Console.WriteLine("\n--Sorted by names--");
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{name[i]}\t{mark[i]}");
            }
        }
    }
}
